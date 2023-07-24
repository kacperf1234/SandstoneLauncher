#region

using System.Net.Http;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    public class networkclient_getresponse_tests
    {
        private HttpResponseMessage execute(string url = "https://reqres.in/api/users?page=2")
        {
            NetworkClient client = new NetworkClient();
            return client.GetResponse(url, HttpMethod.Get);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void status_code_is_ok()
        {
            Assert.IsTrue((int)execute().StatusCode == 200);
        }
    }
}