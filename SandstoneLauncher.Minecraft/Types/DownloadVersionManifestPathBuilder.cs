using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class DownloadVersionManifestPathBuilder : IDownloadVersionManifestPathBuilder
    {
        public IFileNameExtractor Extractor;
        public IMinecraftDirectory Minecraft;

        public DownloadVersionManifestPathBuilder(IFileNameExtractor extractor, IMinecraftDirectory minecraft)
        {
            Extractor = extractor;
            Minecraft = minecraft;
        }

        public string GetPath(string versionid)
        {
            string id = Extractor.GetName(versionid);
            return Minecraft.GetVersions() + $"{id}\\{id}.json";
        }
    }
}