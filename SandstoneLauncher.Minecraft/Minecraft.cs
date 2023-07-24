using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using Spencer.NET;

#nullable enable

namespace SandstoneLauncher.Minecraft
{
    [SingleInstance]
    public class Minecraft
    {
        private IAccountCreator AccountCreator;
        private MojangAuthentication MojangAuthentication;
        private IManifestGetter ManifestGetter;

        public Minecraft(IAccountCreator accountCreator, MojangAuthentication mojangAuthentication, IManifestGetter manifestGetter)
        {
            AccountCreator = accountCreator;
            MojangAuthentication = mojangAuthentication;
            ManifestGetter = manifestGetter;
        }

        public static Minecraft GetInstance()
        {
            IContainer container = ContainerFactory.Container();
            container.RegisterAssembly<AccountCreator>();

            return container.Resolve<Minecraft>();
        }

        public Account CreateAccount(string username)
        {
            return AccountCreator.Create(username);
        }

        public Account CreateAccount(string username, string password)
        {
            MojangCredentials credentials = new MojangCredentials()
            {
                Username = username,
                Password = password
            };
            
            MojangLoginResponse? r = null;

            MojangAuthentication.Authenticate(credentials, out r);

            return AccountCreator.Create(r);
        }

        public VersionManifest GetVersionManifest()
        {
            return ManifestGetter.GetManifest();
        }
    }
}