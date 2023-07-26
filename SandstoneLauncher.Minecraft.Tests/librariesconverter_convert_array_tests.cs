#region

using System;
using System.Text.RegularExpressions;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
public class librariesconverter_convert_array_tests
    {
        private readonly string[] stringarray = new string[5]
        {
            "com\\google.jar",
            "com\\mojang\\mc.jar",
            "com\\mojang\\tools\\n.jar",
            "org\\google.jar",
            "org\\google\\devs\\developers.jar"
        };

        private string execute()
        {
            LibrariesConverter c = new LibrariesConverter(new mc(), new PathConverter(),
                new LibraryPathBuilder(new MinecraftDirectory(), new PathConverter()), new checker(),
                new LibraryValidator(new RulesValidator()));
            return c.Convert(stringarray);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_contains_5_semicolons()
        {
            Regex r = new Regex(";");
            MatchCollection matches = r.Matches(execute());

            Assert.IsTrue(matches.Count == 5);
        }

        [Test]
        public void returns_contains_excepted_results()
        {
            string excepted =
                "com\\google.jar;com\\mojang\\mc.jar;com\\mojang\\tools\\n.jar;org\\google.jar;org\\google\\devs\\developers.jar;";
            string exec = execute();

            Console.WriteLine(exec);

            Assert.AreEqual(excepted, exec);
        }

        private class mc : IMinecraftDirectory
        {
            public string GetAssets()
            {
                throw new NotImplementedException();
            }

            public string GetLibraries()
            {
                return "";
            }

            public string GetMinecraft()
            {
                throw new NotImplementedException();
            }

            public string GetLauncherProfiles()
            {
                throw new NotImplementedException();
            }

            public string GetVersions()
            {
                throw new NotImplementedException();
            }
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