using KacpiiToZiomal.SandstoneLauncher.Accounts.Models;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Types;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Accounts.Tests
{
    public class accountcreator_create_string_tests
    {
        Account execute(string username)
        {
            AccountCreator c = new AccountCreator();
            return c.Create(username);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("kacpii"));
        }

        [Test]
        public void returns_excepted_username()
        {
            Assert.AreEqual("kacpii", execute("kacpii").Username);
        }

        [Test]
        public void returns_excepted_uuid()
        {
            Assert.AreEqual("N/A", execute("kacpii").Uuid);
        }

        [Test]
        public void returns_excepted_accesstoken()
        {
            Assert.AreEqual(string.Empty, execute("kacpii").AccessToken);
        }

        [Test]
        public void returns_excepted_clienttoken()
        {
            Assert.AreEqual(string.Empty, execute("kacpiii").ClientToken);
        }
    }
}