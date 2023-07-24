using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class ManifestJsonDeserializer : IJsonDeserializer<VersionManifest>
    {
        public VersionManifest Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<VersionManifest>(json);
        }
    }
}