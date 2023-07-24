#region

using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class assetsindexpathbuilder_build_tests
    {
        private string execute(string v = "1.14")
        {
            AssetsIndexPathBuilder b = new AssetsIndexPathBuilder(new mc());
            return b.Build(v);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_string()
        {
            Assert.AreEqual("assets\\indexes\\1.14.json", execute());
        }

        private class mc : IMinecraftDirectory
        {
            public string GetAssets()
            {
                return "assets\\";
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