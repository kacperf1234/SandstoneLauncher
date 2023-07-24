#region

using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class nativespathfinder_getpath_tests
    {
        private string execute()
        {
            DownloadArtifact art = new DownloadArtifact();
            art.Path = "com/google/google.jar";

            NativesPathFinder f = new NativesPathFinder(new mc(), new PathConverter());
            return f.GetPath(art);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_results()
        {
            Assert.AreEqual("versions\\natives\\com\\google\\google.jar", execute());
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
                return "versions\\";
            }
        }
    }
}