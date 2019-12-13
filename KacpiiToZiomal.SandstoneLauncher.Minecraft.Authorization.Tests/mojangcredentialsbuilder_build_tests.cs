using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Tests
{
    public class mojangcredentialsbuilder_build_tests
    {
        MojangCredentials execute(string u, string pwd)
        {
            return new MojangCredentialsBuilder().Build(u, pwd);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => { execute("", "");});
        }

        [Test]
        public void returns_excepted_username()
        {
            Assert.AreEqual("username", execute("username", "").Username);
        }

        [Test]
        public void returns_excepted_password()
        {
            Assert.AreEqual("password", execute("", "password").Password);
        }
    }
}