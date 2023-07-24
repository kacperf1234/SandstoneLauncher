#region

using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class hashcombiner_getfirstletters_tests
    {
        private string execute(string hash)
        {
            IHashCombiner c = new HashCombiner();
            return c.GetFirstLetters(hash);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("9a9fd8a9sf7"));
        }

        [Test]
        public void returns_excepted_results()
        {
            Assert.AreEqual("9d", execute("9d14814ninsaf98142"));
        }
    }
}