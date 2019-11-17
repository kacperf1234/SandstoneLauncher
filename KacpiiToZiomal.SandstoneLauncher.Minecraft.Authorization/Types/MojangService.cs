using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Types
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