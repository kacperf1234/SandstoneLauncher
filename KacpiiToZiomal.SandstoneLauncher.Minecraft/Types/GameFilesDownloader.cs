using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class GameFilesDownloader : IGameFilesDownloader
    {
        public IAssetsDownloader AssetsDownloader;
        public IAssetsFinder AssetsFinder;
        public IClientDownloader ClientDownloader;
        public IFullVersionFinder FullVersionFinder;
        public ILibrariesDownloader LibrariesDownloader;
        public IFullVersionManifestDownloader ManifestDownloader;
        public INativesDownloader NativesDownloader;

        public GameFilesDownloader(IFullVersionFinder fullVersionFinder, IAssetsFinder assetsFinder,
            INativesDownloader nativesDownloader, ILibrariesDownloader librariesDownloader,
            IAssetsDownloader assetsDownloader, IClientDownloader clientDownloader,
            IFullVersionManifestDownloader manifestDownloader)
        {
            FullVersionFinder = fullVersionFinder;
            AssetsFinder = assetsFinder;
            NativesDownloader = nativesDownloader;
            LibrariesDownloader = librariesDownloader;
            AssetsDownloader = assetsDownloader;
            ClientDownloader = clientDownloader;
            ManifestDownloader = manifestDownloader;
        }

        public void Download(GameVersion gameVersion, OS os)
        {
            FullVersion version = FullVersionFinder.Find(gameVersion.Url);
            Assets assets = AssetsFinder.GetAssets(version.AssetsIndex.Url, version);

            AssetsDownloader.Download(assets, version);
            LibrariesDownloader.Download(version.Libraries, os);
            NativesDownloader.Download(version.Libraries, os, version);
            ClientDownloader.Download(version.Downloads.Client, version.Id);
            ManifestDownloader.Download(gameVersion);
        }

        public static GameFilesDownloader GetGameFilesDownloader()
        {
            return new GameFilesDownloader(new FullVersionFinder(new NetworkClient(), new FullVersionParser()),
                new AssetsFinder(new NetworkClient(), new AssetsDeserializer()),
                new NativesDownloader(new NativesPathFinder(new MinecraftDirectory(), new PathConverter()),
                    new LibraryNativesValidator(
                        new NativesValidator(new OperatingSystemConverter(), new NativesPropertyGetter()),
                        new ClassifiersValidator()), new ArtifactFinder(),
                    new HttpDownloader(new HttpBytesReader(), new FileCreator(new FileNameRemover())),
                    new NativesTemporaryPathFinder(new FileNameExtractor(new PathConverter()),
                        new MinecraftDirectory()), new JarFileExtractor(),
                    new NativesDirectory(new MinecraftDirectory(), new DirectoryCreator(new FileNameRemover()))),
                new LibrariesDownloader(
                    new HttpDownloader(new HttpBytesReader(), new FileCreator(new FileNameRemover())),
                    new LibraryPathBuilder(new MinecraftDirectory(), new PathConverter()),
                    new LibraryValidator(new RulesValidator())),
                new AssetsDownloader(new AssetsExtractor(), new AssetsUrlBuilder(new HashCombiner()),
                    new HttpDownloader(new HttpBytesReader(), new FileCreator(new FileNameRemover())),
                    new AssetsPathBuilder(new MinecraftDirectory(), new HashCombiner()),
                    new AssetsIndexCreator(new MinecraftDirectory(), new FileCreator(new FileNameRemover())),
                    new AssetsListFilter()),
                new ClientDownloader(new ClientPathFinder(new MinecraftDirectory()),
                    new HttpDownloader(new HttpBytesReader(), new FileCreator(new FileNameRemover()))),
                new FullVersionManifestDownloader(new MinecraftDirectory(),
                    new HttpDownloader(new HttpBytesReader(), new FileCreator(new FileNameRemover()))));
        }
    }
}