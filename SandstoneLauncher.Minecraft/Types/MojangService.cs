using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Types
{
    public class MojangService : IMojangService
    {
        public IMojangAuthentication Authentication;

        public MojangService(IMojangAuthentication authentication)
        {
            Authentication = authentication;
        }

        public MojangLoginResponse TryLogin(MojangCredentials credentials)
        {
            MojangLoginResponse loginresponse = new MojangLoginResponse();
            bool result = Authentication.Authenticate(credentials, out loginresponse);
            loginresponse.State = result ? AuthenticationState.OK : AuthenticationState.INVALID_CREDENTIALS; // todo extract dependency

            return loginresponse;
        }
    }
}