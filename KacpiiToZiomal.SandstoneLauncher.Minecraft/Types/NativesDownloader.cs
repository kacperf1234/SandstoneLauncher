using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class NativesDownloader : INativesDownloader
    {
        public IArtifactFinder ArtifactFinder;
        public IHttpDownloader Downloader;
        public INativesPathFinder Finder;
        public IJarFileExtractor JarExtractor;
        public INativesDirectory NativesDirectory;
        public ILibraryNativesValidator NativesValidator;
        public INativesTemporaryPathFinder TempFinder;

        public NativesDownloader(INativesPathFinder finder, ILibraryNativesValidator nativesValidator,
            IArtifactFinder artifactFinder, IHttpDownloader downloader, INativesTemporaryPathFinder tempFinder,
            IJarFileExtractor jarExtractor, INativesDirectory nativesDirectory)
        {
            Finder = finder;
            NativesValidator = nativesValidator;
            ArtifactFinder = artifactFinder;
            Downloader = downloader;
            TempFinder = tempFinder;
            JarExtractor = jarExtractor;
            NativesDirectory = nativesDirectory;
        }

        public void Download(Library[] libraries, OS system, FullVersion version)
        {
            foreach (Library library in libraries)
                if (NativesValidator.Validate(library, system))
                {
                    DownloadArtifact artifact = ArtifactFinder.GetDownloadArtifact(library, system);
                    string tmpdest = TempFinder.GetTemporaryPath(artifact);

                    Downloader.Download(artifact.Url, tmpdest);

                    JarExtractor.ExtractAll(tmpdest, NativesDirectory.GetDirectory(version.Id));
                }
        }

        public void Download(Library library, OS system, FullVersion version)
        {
            if (NativesValidator.Validate(library, system))
            {
                DownloadArtifact artifact = ArtifactFinder.GetDownloadArtifact(library, system);
                string tmpdest = TempFinder.GetTemporaryPath(artifact);

                Downloader.Download(artifact.Url, tmpdest);

                JarExtractor.ExtractAll(tmpdest, NativesDirectory.GetDirectory(version.Id));
            }
        }
    }
}