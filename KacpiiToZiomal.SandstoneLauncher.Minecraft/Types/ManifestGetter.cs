using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
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