using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Interfaces
{
    public interface IMojangAuthentication
    {
        bool Authenticate(MojangCredentials credentials, out MojangLoginResponse response);
    }
}