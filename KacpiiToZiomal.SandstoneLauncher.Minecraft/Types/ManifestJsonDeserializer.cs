using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class ManifestJsonDeserializer : IJsonDeserializer<VersionManifest>
    {
        public VersionManifest Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<VersionManifest>(json);
        }
    }
}