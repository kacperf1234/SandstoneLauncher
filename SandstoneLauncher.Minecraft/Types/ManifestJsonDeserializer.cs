using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Types
{
    public class ManifestJsonDeserializer : IJsonDeserializer<VersionManifest>
    {
        public VersionManifest Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<VersionManifest>(json);
        }
    }
}