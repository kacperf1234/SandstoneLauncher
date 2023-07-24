#region

using System;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    public class assetspathbuilder_getabsolutepath_tests
    {
        private string execute(string hash)
        {
            IAssetsPathBuilder b = new AssetsPathBuilder(new minecraftdir(), new HashCombiner());
            return b.GetAbsolutePath(hash);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("9d91414"));
        }

        [Test]
        public void returns_excepted_results()
        {
            Assert.AreEqual(".mc\\assets\\objects\\9d\\9d14nd1", execute("9d14nd1"));
        }

        private class minecraftdir : IMinecraftDirectory
        {
            public string GetAssets()
            {
                return ".mc\\assets\\";
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
                throw new NotImplementedException();
            }
        }
    }
}