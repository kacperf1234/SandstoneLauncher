using KacpiiToZiomal.SandstoneLauncher.Accounts.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Models;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Accounts.Types
{
    public class AccountGenerator : IAccountGenerator
    {
        public ICredentialsOnlineValidator OnlineValidator;
        public IMojangCredentialsBuilder MojangCredentialsBuilder;
        public IMojangService MojangService;
        public IAccountCreator AccountCreator;

        public AccountGenerator(ICredentialsOnlineValidator onlineValidator, IMojangCredentialsBuilder mojangCredentialsBuilder, IMojangService mojangService, IAccountCreator accountCreator)
        {
            OnlineValidator = onlineValidator;
            MojangCredentialsBuilder = mojangCredentialsBuilder;
            MojangService = mojangService;
            AccountCreator = accountCreator;
        }

        public Account GenerateAccount(Credentials credentials)
        {
            if (OnlineValidator.IsOnlineCredentials(credentials))
            {
                MojangCredentials mojangCredentials = MojangCredentialsBuilder.Build(credentials.Username, credentials.Password);
                MojangLoginResponse mojangLoginResponse = MojangService.TryLogin(mojangCredentials);

                return AccountCreator.Create(mojangLoginResponse);
            }

            return AccountCreator.Create(credentials.Username);
        }
    }
}