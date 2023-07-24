#region

using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
public class networkclient_getcontent_tests
    {
        private string execute(string url = "https://reqres.in/api/users?page=2")
        {
            IHttpClient c = new NetworkClient();
            return c.GetContent(url);
        }

        [Test]
        public void does_not_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_string_contains_elements()
        {
            string cnt = execute();

            Assert.IsTrue(cnt.Contains("page"));
        }
    }
}