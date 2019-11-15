using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Interfaces
{
    public interface IMojangAuthentication
    {
        bool Authenticate(MojangCredentials credentials, out MojangLoginResponse response);
    }
}