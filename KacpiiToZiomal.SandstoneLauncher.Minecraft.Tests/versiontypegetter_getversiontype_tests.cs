#region

using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class versiontypegetter_getversiontype_tests
    {
        private VersionType execute(string type = "release")
        {
            VersionTypeGetter g = new VersionTypeGetter();
            return g.GetVersionType(GameVersion.CreateVersion(type: type));
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_alpha_when_gived_release()
        {
            Assert.IsTrue(execute() == VersionType.ALPHA);
        }

        [Test]
        public void returns_alpha_when_gived_old_alpha()
        {
            Assert.IsTrue(execute("old_alpha") == VersionType.ALPHA);
        }

        [Test]
        public void returns_beta_when_gived_old_beta()
        {
            Assert.IsTrue(execute("old_beta") == VersionType.BETA);
        }

        [Test]
        public void returns_beta_when_gived_snapshot()
        {
            Assert.IsTrue(execute("snapshot") == VersionType.BETA);
        }

        [Test]
        public void throws_argumentexception_when_gameversion_type_is_valid()
        {
            Assert.That(() => execute("onfasoas"), Throws.ArgumentException);
        }
    }
}