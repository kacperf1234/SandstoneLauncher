using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Types
{
    public class MojangCredentialsBuilder : IMojangCredentialsBuilder
    {
        public MojangCredentials Build(string username, string password)
        {
            return new MojangCredentials(username, password);
        }
    }
}