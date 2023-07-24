#region

using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class minecraftdirectory_getlibraries_tests
    {
        private string execute()
        {
            MinecraftDirectory dir = new MinecraftDirectory();
            return dir.GetLibraries();
        }

        [Test]
        public void dont_throws()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_string()
        {
            Assert.AreEqual(execute().ToLower(),
                $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\.minecraft\libraries\"
                    .ToLower());
        }
    }
}