using System;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [Obsolete("use IManifestGetter, ManifestGetter")]
    [SingleInstance]
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