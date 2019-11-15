#region

using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class librarynativevalidator_validate_tests
    {
        private readonly Library BadLibrary = new Library
        {
            Download = new DownloadLibrary()
        };

        private readonly Library GoodLibrary = new Library
        {
            Download = new DownloadLibrary
            {
                Classifiers = new Classifiers
                {
                    Windows = new DownloadArtifact(),
                    Linux = new DownloadArtifact()
                }
            },
            Natives = new Natives
            {
                Windows = "natives-windows",
                Linux = "natives-linux"
            }
        };

        private bool execute(Library l)
        {
            LibraryNativesValidator v = new LibraryNativesValidator(
                new NativesValidator(new OperatingSystemConverter(), new NativesPropertyGetter()),
                new ClassifiersValidator());
            return v.Validate(l, OS.WINDOWS);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(GoodLibrary));
            Assert.DoesNotThrow(() => execute(BadLibrary));
        }

        [Test]
        public void returns_true_when_gived_has_goodlibrary()
        {
            Assert.IsTrue(execute(GoodLibrary));
        }

        [Test]
        public void returns_false_when_gived_has_badlibrary()
        {
            Assert.IsFalse(execute(BadLibrary));
        }
    }
}