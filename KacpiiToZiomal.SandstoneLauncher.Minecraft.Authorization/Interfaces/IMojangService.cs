using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Interfaces
{
    public interface IMojangService
    {
        MojangLoginResponse TryLogin(MojangCredentials credentials);
    }
}