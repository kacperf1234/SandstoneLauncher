#region

using System;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class minecraftdirectory_getassets_tests
    {
        private string execute()
        {
            MinecraftDirectory dir = new MinecraftDirectory();
            return dir.GetAssets();
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
                $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\.minecraft\assets\"
                    .ToLower());
        }
    }
}