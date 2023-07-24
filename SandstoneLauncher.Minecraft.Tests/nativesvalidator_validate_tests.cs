#region

using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    public class nativesvalidator_validate_tests
    {
        private bool execute(OS sys, bool ctor = true)
        {
            NativesValidator v = new NativesValidator(ctor ? new OperatingSystemConverter() : null,
                ctor ? new NativesPropertyGetter() : null);
            Natives n = new Natives
            {
                Windows = "natives-windows"
            };

            return v.Validate(n, sys);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(OS.WINDOWS));
        }

        [Test]
        public void returns_valid_results()
        {
            Assert.IsTrue(execute(OS.WINDOWS));
            Assert.IsFalse(execute(OS.LINUX));
        }

        [Test]
        public void throws_exceptions_when_constructor_was_be_empty()
        {
            Assert.That(() => execute(OS.WINDOWS, false), Throws.Exception);
        }
    }
}