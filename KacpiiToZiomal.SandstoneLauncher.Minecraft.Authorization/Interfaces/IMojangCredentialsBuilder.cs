using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Interfaces
{
    public interface IMojangCredentialsBuilder
    {
        MojangCredentials Build(string username, string password);
    }
}