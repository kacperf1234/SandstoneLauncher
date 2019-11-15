using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
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