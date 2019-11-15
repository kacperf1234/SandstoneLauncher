#region

using System;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class librarypathbuilder_build_tests
    {
        private string execute(string name)
        {
            LibraryPathBuilder b = new LibraryPathBuilder(new MinecraftDirectory(), new PathConverter());
            return b.Build(new Library
            {
                Download = new DownloadLibrary
                {
                    Artifact = new DownloadArtifact
                    {
                        Path = name
                    }
                }
            });
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("com/kacpii/to/ziomal/lib.jar"));
        }

        [Test]
        public void returns_valid_path_regex()
        {
            Assert.AreEqual(execute("com/kacpii/to/ziomal/lib.jar"),
                $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\.minecraft\libraries\com\kacpii\to\ziomal\lib.jar");
        }
    }
}