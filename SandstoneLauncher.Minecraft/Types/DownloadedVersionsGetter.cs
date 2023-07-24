using System.Collections.Generic;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class DownloadedVersionsGetter : IDownloadedVersionsGetter
    {
        public IJsonDeserializer<FullVersion> Deserializer;
        public IDirectoryListCreator DirectoryList;
        public IFileReader FileReader;
        public IMinecraftDirectory Minecraft;
        public IDownloadVersionManifestPathBuilder PathBuilder;

        public DownloadedVersionsGetter(IMinecraftDirectory minecraft, IDirectoryListCreator directoryList,
            IDownloadVersionManifestPathBuilder pathBuilder, IFileReader fileReader,
            IJsonDeserializer<FullVersion> deserializer)
        {
            Minecraft = minecraft;
            DirectoryList = directoryList;
            PathBuilder = pathBuilder;
            FileReader = fileReader;
            Deserializer = deserializer;
        }

        public IEnumerable<FullVersion> GetDownloadedVersions()
        {
            string[] directories = DirectoryList.GetDirectories(Minecraft.GetVersions());

            foreach (string directory in directories)
            {
                string manifestpath = PathBuilder.GetPath(directory);
                string content = FileReader.Read(manifestpath);

                yield return Deserializer.Deserialize(content);
            }
        }
    }
}