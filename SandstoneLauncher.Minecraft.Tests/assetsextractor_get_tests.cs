#region

using SandstoneLauncher.Minecraft.Models;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class assetsextractor_get_tests
    {
        private Asset execute(string name)
        {
            return null;
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("x"));
        }
    }
}