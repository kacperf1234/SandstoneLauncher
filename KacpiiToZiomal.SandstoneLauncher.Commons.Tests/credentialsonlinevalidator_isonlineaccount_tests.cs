using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Tests
{
    public class credentialsonlinevalidator_isonlineaccount_tests
    {
        bool execute(Credentials credentials)
        {
            CredentialsOnlineValidator o = new CredentialsOnlineValidator();
            return o.IsOnlineCredentials(credentials);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => {execute(new Credentials());});
        }

        [Test]
        public void returns_true_when_credentials_are_online()
        {
            Assert.IsTrue(execute(new Credentials() {Password = "this is not empty :D", IsOnline = true}));
        }
        
        [Test]
        public void returns_false_when_credentials_arenot_online()
        {
            Assert.IsFalse(execute(new Credentials() {IsOnline = false}));
        }
    }
}