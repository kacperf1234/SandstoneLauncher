#region

using System;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
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