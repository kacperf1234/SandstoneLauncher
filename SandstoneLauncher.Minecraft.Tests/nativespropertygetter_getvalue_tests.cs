#region

using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class nativespropertygetter_getvalue_tests
    {
        private string execute(string name = "windows", string wndval = "natives-windows",
            string lnxval = "natives-linux")
        {
            return new NativesPropertyGetter().GetValue(new Natives { Linux = lnxval, Windows = wndval }, name);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("Windows"));
        }

        [Test]
        public void returns_valid_values()
        {
            Assert.AreEqual("natives-windows", execute());
            Assert.AreEqual("natives-linux", execute("LINux"));
        }
    }
}