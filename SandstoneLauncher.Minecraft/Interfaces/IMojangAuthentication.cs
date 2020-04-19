using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IMojangAuthentication
    {
        bool Authenticate(MojangCredentials credentials, out MojangLoginResponse response);
    }
}