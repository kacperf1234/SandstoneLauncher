using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Interfaces
{
    public interface IMojangService
    {
        MojangLoginResponse TryLogin(MojangCredentials credentials);
    }
}