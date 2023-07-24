using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class ManifestGetter : IManifestGetter
    {
        public IManifestApi Api;
        public IJsonDeserializer<VersionManifest> Deserializer;

        public ManifestGetter(IManifestApi api, IJsonDeserializer<VersionManifest> deserializer)
        {
            Api = api;
            Deserializer = deserializer;
        }

        public VersionManifest GetManifest()
        {
            return Deserializer.Deserialize(Api.GetJson());
        }
    }
}