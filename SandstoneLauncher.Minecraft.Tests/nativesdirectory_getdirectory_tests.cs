#region

using System;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class nativesdirectory_getdirectory_tests
    {
        private string execute(string id)
        {
            NativesDirectory natives = new NativesDirectory(new mc(), DirectoryCreator.Default);
            return natives.GetDirectory(id);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("1.14.4"));
        }

        [Test]
        public void returns_excepted_results()
        {
            Assert.AreEqual("versions\\1.14.4\\1.14.4-natives\\", execute("1.14.4"));
        }

        private class mc : IMinecraftDirectory
        {
            public string GetAssets()
            {
                throw new NotImplementedException();
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
                return "versions\\";
            }
        }
    }
}