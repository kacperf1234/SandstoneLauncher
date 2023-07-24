#region

using System;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
public class launcherprofilespathbuilder_build_tests
    {
        private string execute()
        {
            LauncherProfilesPathBuilder b = new LauncherProfilesPathBuilder(new m());
            return b.Build();
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_string()
        {
            Assert.AreEqual(".minecraft\\launcher_profiles.json", execute());
        }

        private class m : IMinecraftDirectory
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
                return ".minecraft\\";
            }

            public string GetVersions()
            {
                throw new NotImplementedException();
            }
        }
    }
}