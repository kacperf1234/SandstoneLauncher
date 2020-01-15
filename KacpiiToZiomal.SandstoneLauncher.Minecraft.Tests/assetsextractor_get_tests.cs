#region

using System.Collections.Generic;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
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