using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class LibrariesDownloader : ILibrariesDownloader
    {
        public ILibraryPathBuilder Builder;
        public IHttpDownloader Downloader;
        public ILibraryValidator Validator;

        public LibrariesDownloader(IHttpDownloader downloader, ILibraryPathBuilder builder, ILibraryValidator validator)
        {
            Downloader = downloader;
            Builder = builder;
            Validator = validator;
        }

        public void Download(Library library, OS sys)
        {
            if (!Validator.Validate(library, sys))
                return;

            string path = Builder.Build(library);
            Downloader.Download(library.Download.Artifact.Url, path);
        }

        public void Download(Library[] libraries, OS sys)
        {
            foreach (Library library in libraries)
            {
                if (!Validator.Validate(library, sys))
                    continue;

                string path = Builder.Build(library);
                Downloader.Download(library.Download.Artifact.Url, path);
            }
        }
    }
}