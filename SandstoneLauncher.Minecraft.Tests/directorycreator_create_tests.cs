#region

using System.IO;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class directorycreator_create_tests
    {
        private const string Path = "testdir\\samplesubdir\\";

        [SetUp]
        public void execute()
        {
            DirectoryCreator c = new DirectoryCreator(new FileNameRemover());
            c.Create(Path);
        }

        [TearDown]
        public void Teardown()
        {
            Directory.Delete(Path);
        }

        [Test]
        public void directory_base_exist()
        {
            Assert.IsTrue(Directory.Exists("testdir"));
        }

        [Test]
        public void subdir_exist()
        {
            Assert.IsTrue(Directory.Exists("testdir\\samplesubdir"));
        }
    }
}