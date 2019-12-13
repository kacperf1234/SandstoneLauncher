using KacpiiToZiomal.SandstoneLauncher.Accounts.Models;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Types;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Accounts.Tests
{
    public class accountcreator_create_mojangloginresponse_tests
    {
        private MojangLoginResponse def()
        {
            return new MojangLoginResponse
            {
                SelectedProfile = new MojangProfile
                {
                    Id = "uuid",
                    Name = "username"
                },
                AccessToken = "accesstoken",
                ClientToken = "clienttoken"
            };
        }

        private Account execute(MojangLoginResponse response)
        {
            return new AccountCreator().Create(response);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(def()));
        }

        [Test]
        public void returns_excepted_username()
        {
            Assert.AreEqual("username", execute(def()).Username);
        }

        [Test]
        public void returns_excepted_uuid()
        {
            Assert.AreEqual("uuid", execute(def()).Uuid);
        }

        [Test]
        public void returns_excepted_accesstoken()
        {
            Assert.AreEqual("accesstoken", execute(def()).AccessToken);
        }

        [Test]
        public void returns_excepted_clienttoken()
        {
            Assert.AreEqual("clienttoken", execute(def()).ClientToken);
        }
    }
}