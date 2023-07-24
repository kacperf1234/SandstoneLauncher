#region

using System;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    public class clientpathfinder_getpath_tests
    {
        private string execute(string v = "1.14")
        {
            IClientPathFinder finder = new ClientPathFinder(new minecraftdir());
            return finder.GetPath(v);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_results()
        {
            Assert.AreEqual("kacperziomal\\versions\\1.14\\1.14.jar", execute());
        }

        private class minecraftdir : IMinecraftDirectory
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
                return "kacperziomal\\versions\\";
            }
        }
    }
}