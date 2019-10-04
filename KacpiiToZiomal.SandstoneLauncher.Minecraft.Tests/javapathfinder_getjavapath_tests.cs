#region

using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class javapathfinder_getjavapath_tests
    {
        private string execute()
        {
            return new JavaPathFinder().GetJavaPath();
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
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) +
                "\\Common Files\\Oracle\\Java\\javapath\\javaw.exe", execute());
        }
    }
}