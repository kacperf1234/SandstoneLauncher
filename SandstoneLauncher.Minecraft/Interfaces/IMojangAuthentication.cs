using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IMojangAuthentication
    {
        bool Authenticate(MojangCredentials credentials, out MojangLoginResponse response);
    }
}