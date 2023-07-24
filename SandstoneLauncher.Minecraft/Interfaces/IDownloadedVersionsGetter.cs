using System.Collections.Generic;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IDownloadedVersionsGetter
    {
        IEnumerable<FullVersion> GetDownloadedVersions();
    }
}