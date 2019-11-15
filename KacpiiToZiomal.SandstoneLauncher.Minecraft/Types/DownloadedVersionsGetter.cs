using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
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