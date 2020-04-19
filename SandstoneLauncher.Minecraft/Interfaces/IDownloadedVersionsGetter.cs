using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IDownloadedVersionsGetter
    {
        IEnumerable<FullVersion> GetDownloadedVersions();
    }
}