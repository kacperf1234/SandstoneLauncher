#region

using System;
using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
public class librariesconverter_tostringarray_tests
    {
        private readonly Library[] libraries = new Library[5]
        {
            new Library
            {
                Download = new DownloadLibrary
                {
                    Artifact = new DownloadArtifact
                    {
                        Path = "com/google/dev/developertools.jar"
                    }
                }
            },
            new Library
            {
                Download = new DownloadLibrary
                {
                    Artifact = new DownloadArtifact
                    {
                        Path = "com/google/kacpiitoziomal.jar"
                    }
                }
            },
            new Library
            {
                Download = new DownloadLibrary
                {
                    Artifact = new DownloadArtifact
                    {
                        Path = "com/google/for/mojang/hello.jar"
                    }
                }
            },
            new Library
            {
                Download = new DownloadLibrary
                {
                    Artifact = new DownloadArtifact
                    {
                        Path = "com/mojang/text2.jar"
                    }
                }
            },
            new Library
            {
                Download = new DownloadLibrary
                {
                    Artifact = new DownloadArtifact
                    {
                        Path = "com/oracle/java.jar"
                    }
                }
            }
        };

        private string[] execute()
        {
            LibrariesConverter c = new LibrariesConverter(new mc(), new PathConverter(),
                new LibraryPathBuilder(new mc(), new PathConverter()), new LibraryFileChecker(),
                new LibraryValidator(new RulesValidator()));
            return c.ToStringArray(libraries, OS.WINDOWS);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_array_contains_excepted_string()
        {
            Assert.Contains("libs\\com\\oracle\\java.jar", execute());
        }

        [Test]
        public void dont_contains_string_didnt_should_be_there()
        {
            Assert.That(execute(), Is.All.Not.Contain("libs\\com\\siema\\jar.jar"));
        }

        private class mc : IMinecraftDirectory
        {
            public string GetAssets()
            {
                throw new NotImplementedException();
            }

            public string GetLibraries()
            {
                return "libs\\";
            }

            public string GetMinecraft()
            {
                throw new NotImplementedException();
            }

            public string GetVersions()
            {
                throw new NotImplementedException();
            }
        }
    }
}