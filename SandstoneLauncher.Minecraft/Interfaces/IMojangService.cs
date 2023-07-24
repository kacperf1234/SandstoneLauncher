using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IMojangService
    {
        MojangLoginResponse TryLogin(MojangCredentials credentials);
    }
}