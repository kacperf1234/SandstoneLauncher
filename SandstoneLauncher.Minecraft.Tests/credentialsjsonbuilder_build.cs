#region

using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class credentialsjsonbuilder_build
    {
        private string execute(string username, string pwd)
        {
            MojangCredentials c = new MojangCredentials(username, pwd);
            CredentialsJsonBuilder jb = new CredentialsJsonBuilder();
            return jb.Build(c);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("kacpii", "pwd"));
        }

        [Test]
        public void returns_excepted_string()
        {
            Assert.AreEqual(
                @"{ 'agent': { 'name': 'Minecraft', 'version': 1 }, 'username': 'ziomale', 'password': 'kacpii', 'clientToken': 'ziomale', 'requestUser': true }"
                    .Replace("'", "\""), execute("ziomale", "kacpii"));
        }
    }
}