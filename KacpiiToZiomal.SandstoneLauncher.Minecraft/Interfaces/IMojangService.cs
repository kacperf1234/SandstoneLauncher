using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IMojangService
    {
        MojangLoginResponse TryLogin(MojangCredentials credentials);
    }
}