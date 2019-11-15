#region

using System;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class librariespathconverter_convert_tests
    {
        private string execute()
        {
            Library[] lib =
            {
                new Library
                {
                    Download = new DownloadLibrary
                    {
                        Artifact = new DownloadArtifact
                        {
                            Path = "com/kacpiitoziomal/library.jar"
                        }
                    }
                }
            };
            LibrariesConverter c = new LibrariesConverter(new MinecraftDirectory(), new PathConverter(),
                new LibraryPathBuilder(new MinecraftDirectory(), new PathConverter()), new checker(),
                new LibraryValidator(new RulesValidator()));
            return c.Convert(c.ToStringArray(lib, OS.WINDOWS));
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_string()
        {
            Assert.AreEqual(
                $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\.minecraft\libraries\com\kacpiitoziomal\library.jar;",
                execute());
        }

        private class checker : ILibraryFileChecker
        {
            public bool CheckFile(string path)
            {
                return true;
            }
        }
    }
}