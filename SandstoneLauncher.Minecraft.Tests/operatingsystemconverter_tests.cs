#region

using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    public class operatingsystemconverter_tests
    {
        private string execute(OS s)
        {
            OperatingSystemConverter c = new OperatingSystemConverter();
            return c.Convert(s);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(OS.WINDOWS));
        }

        [Test]
        public void returns_valid_values()
        {
            Assert.AreEqual("windows", execute(OS.WINDOWS));
            Assert.AreEqual("linux", execute(OS.LINUX));
        }
    }
}