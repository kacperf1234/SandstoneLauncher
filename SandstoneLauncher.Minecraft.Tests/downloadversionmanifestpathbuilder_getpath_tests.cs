#region

using System;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class downloadversionmanifestpathbuilder_getpath_tests
    {
        private string execute(string vid = "1.14")
        {
            DownloadVersionManifestPathBuilder builder =
                new DownloadVersionManifestPathBuilder(new FileNameExtractor(new PathConverter()), new mc());
            return builder.GetPath(vid);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("1.9"));
        }

        [Test]
        public void returns_excepted_string()
        {
            Assert.AreEqual("versions\\1.14.4\\1.14.4.json", execute("1.14.4"));
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