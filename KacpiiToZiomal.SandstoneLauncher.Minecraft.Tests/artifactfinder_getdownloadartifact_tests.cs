#region

using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class artifactfinder_getdownloadartifact_tests
    {
        private DownloadArtifact execute(OS os, Library lib = null)
        {
            if (lib == null)
                lib = new Library
                {
                    Download = new DownloadLibrary
                    {
                        Artifact = new DownloadArtifact
                        {
                            Path = "xd"
                        },
                        Classifiers = new Classifiers
                        {
                            Linux = new DownloadArtifact
                            {
                                Path = "linux"
                            },
                            Windows = new DownloadArtifact
                            {
                                Path = "windows"
                            }
                        }
                    }
                };

            ArtifactFinder f = new ArtifactFinder();
            return f.GetDownloadArtifact(lib, os);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(OS.LINUX));
        }

        [Test]
        public void returns_valid_path_name()
        {
            Assert.AreEqual("windows", execute(OS.WINDOWS).Path);
            Assert.AreEqual("linux", execute(OS.LINUX).Path);
        }
    }
}