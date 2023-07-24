#region

using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class mojangauthentication_authenticate_tests
    {
        private MojangLoginResponse execute(string username, string password, out bool r)
        {
            MojangLoginResponse response = new MojangLoginResponse();
            MojangCredentials c = new MojangCredentials(username, password);
            MojangAuthentication auth = new MojangAuthentication(new NetworkClient(),
                new JsonDeserializer<MojangLoginResponse>(), new CredentialsJsonBuilder(), new ResponseValidator(),
                new data());
            r = auth.Authenticate(c, out response);

            return response;
        }

        [Test]
        public void dont_throws_exceptions()
        {
            bool r = false;
            Assert.That(() => execute("kacperf1234@gmail.com", "@Kacpii1234", out r), Throws.Nothing);
        }

        [Test]
        public void returns_true_when_credentials_are_ok()
        {
            bool r = false;
            MojangLoginResponse e = execute("kacperf1234@gmail.com", "@Kacpii1234", out r);

            Assert.IsTrue(r);
        }

        [Test]
        public void returns_false_when_credentials_are_bad()
        {
            bool r = true;
            MojangLoginResponse e = execute("siema", "hello world", out r);

            Assert.IsFalse(r);
        }

        private class data : IDataProcessing<MojangData>
        {
            public void SendData(MojangData arg)
            {
            }
        }
    }
}