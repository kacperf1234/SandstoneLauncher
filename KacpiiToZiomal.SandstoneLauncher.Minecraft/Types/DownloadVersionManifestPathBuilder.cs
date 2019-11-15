using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
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