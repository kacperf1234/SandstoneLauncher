using System;
using System.IO;
using System.Linq;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class filelistgenerator_getfiles_tests
    {
        private string Dirname = Guid.NewGuid().ToString();

        private string[] Files = new string[3]
        {
            Guid.NewGuid().ToString(),
            Guid.NewGuid().ToString(),
            Guid.NewGuid().ToString()
        };

        [SetUp]
        public void setup()
        {
            Directory.CreateDirectory(Dirname);

            foreach (string file in Files) File.Create(Dirname + "\\" + file).Close();
        }

        [TearDown]
        public void teardown()
        {
            Directory.Delete(Dirname, true);
        }

        private string[] execute()
        {
            return new FileListGenerator().GetFiles(Dirname);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_items_len()
        {
            Assert.IsTrue(execute().Length == Files.Length);
        }

        [Test]
        public void returns_excepted_items()
        {
            string[] exec = execute();

            foreach (string file in Files) Assert.DoesNotThrow(() => exec.Where(x => x == file));
        }
    }
}