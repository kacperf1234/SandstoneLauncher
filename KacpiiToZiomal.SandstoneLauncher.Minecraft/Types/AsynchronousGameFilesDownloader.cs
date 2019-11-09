using System.Threading.Tasks;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class AsynchronousGameFilesDownloader : IGameFilesDownloader
    {
        public IAssetsDownloader AssetsDownloader;
        public IAssetsFinder AssetsFinder;
        public IClientDownloader ClientDownloader;
        public IFullVersionFinder FullVersionFinder;
        public ILibrariesDownloader LibrariesDownloader;
        public IFullVersionManifestDownloader ManifestDownloader;
        public INativesDownloader NativesDownloader;

        public AsynchronousGameFilesDownloader(IAssetsFinder assetsFinder, IFullVersionFinder fullVersionFinder,
            INativesDownloader nativesDownloader, ILibrariesDownloader librariesDownloader,
            IClientDownloader clientDownloader, IAssetsDownloader assetsDownloader,
            IFullVersionManifestDownloader manifestDownloader)
        {
            AssetsFinder = assetsFinder;
            FullVersionFinder = fullVersionFinder;
            NativesDownloader = nativesDownloader;
            LibrariesDownloader = librariesDownloader;
            ClientDownloader = clientDownloader;
            AssetsDownloader = assetsDownloader;
            ManifestDownloader = manifestDownloader;
        }

        public void Download(GameVersion gameVersion, OS sys)
        {
            FullVersion version = FullVersionFinder.Find(gameVersion.Url);
            Assets assets = AssetsFinder.GetAssets(version.AssetsIndex.Url, version);

            Task otherTask = Task.Run(() =>
            {
                ClientDownloader.Download(version.Downloads.Client, version.Id);
                ManifestDownloader.Download(gameVersion);
                LibrariesDownloader.Download(version.Libraries, sys);
                NativesDownloader.Download(version.Libraries, sys, version);
            });

            Task assetsTask = Task.Run(() => { AssetsDownloader.Download(assets, version); });

            Task.WaitAll(otherTask, assetsTask);
        }

        public AsynchronousGameFilesDownloader GetAsynchronousGameFilesDownloader(IMinecraftDirectory minecraft)
        {
            return new AsynchronousGameFilesDownloader(new AssetsFinder(new NetworkClient(), new AssetsDeserializer()),
                new FullVersionFinder(new NetworkClient(), new FullVersionParser()),
                new NativesDownloader(new NativesPathFinder(minecraft, new PathConverter()),
                    new LibraryNativesValidator(
                        new NativesValidator(new OperatingSystemConverter(), new NativesPropertyGetter()),
                        new ClassifiersValidator()), new ArtifactFinder(),
                    new HttpDownloader(new DirectoryCreator(new FileNameRemover())),
                    new NativesTemporaryPathFinder(new FileNameExtractor(new PathConverter()), minecraft),
                    new JarFileExtractor(),
                    new NativesDirectory(minecraft, new DirectoryCreator(new FileNameRemover()))),
                new LibrariesDownloader(new HttpDownloader(new DirectoryCreator(new FileNameRemover())),
                    new LibraryPathBuilder(minecraft, new PathConverter()), new LibraryValidator(new RulesValidator())),
                new ClientDownloader(new ClientPathFinder(minecraft),
                    new HttpDownloader(new DirectoryCreator(new FileNameRemover()))),
                new AssetsDownloader(new AssetsExtractor(), new AssetsUrlBuilder(new HashCombiner()),
                    new HttpDownloader(new DirectoryCreator(new FileNameRemover())),
                    new AssetsPathBuilder(minecraft, new HashCombiner()),
                    new AssetsIndexCreator(minecraft, new FileCreator(new FileNameRemover()))),
                new FullVersionManifestDownloader(minecraft,
                    new HttpDownloader(new DirectoryCreator(new FileNameRemover()))));
        }
    }
}