using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
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