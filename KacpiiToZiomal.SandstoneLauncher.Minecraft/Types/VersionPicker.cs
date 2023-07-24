using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    [Obsolete("use IManifestGetter, ManifestGetter")]
    public class VersionPicker : IVersionPicker
    {
        public IJsonDeserializer<VersionManifest> Deserializer;
        public IManifestApi ManifestApi;

        public VersionPicker(IManifestApi manifestApi, IJsonDeserializer<VersionManifest> deserializer)
        {
            ManifestApi = manifestApi;
            Deserializer = deserializer;
        }

        public VersionManifest PickAll()
        {
            string json = ManifestApi.GetJson();
            return Deserializer.Deserialize(json);
        }
    }
}