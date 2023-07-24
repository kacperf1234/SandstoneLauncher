using System;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    /// <summary>
    ///     finding every game versions. ENDPOINT = https://launchermeta.mojang.com/mc/game/version_manifest.json
    /// </summary>
    [Obsolete("use IManifestGetter, ManifestGetter")]
    public interface IVersionPicker
    {
        VersionManifest PickAll();
    }
}