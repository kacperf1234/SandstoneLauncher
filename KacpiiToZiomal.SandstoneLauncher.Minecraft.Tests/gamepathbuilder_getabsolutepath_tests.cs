#region

using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class gamepathbuilder_getabsolutepath_tests
    {
        private string execute(string versionid)
        {
            GamePathBuilder b = new GamePathBuilder(new mc());
            return b.GetAbsolutePath(versionid);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("1.1"));
        }

        [Test]
        public void returns_excepted_results()
        {
            Assert.AreEqual("v\\1.1\\1.1.jar", execute("1.1"));
            Assert.AreEqual("v\\1.14.4\\1.14.4.jar", execute("1.14.4"));
        }

        private class mc : IMinecraftDirectory
        {
            public string GetAssets()
            {
                throw new NotImplementedException();
            }

            public string GetLibraries()
            {
                throw new NotImplementedException();
            }

            public string GetMinecraft()
            {
                throw new NotImplementedException();
            }

            public string GetVersions()
            {
                return "v\\";
            }
        }
    }
}