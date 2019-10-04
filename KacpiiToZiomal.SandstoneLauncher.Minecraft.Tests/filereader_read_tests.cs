#region

using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class filereader_read_tests
    {
        private readonly string content = "hello world!";
        private readonly string path = "tests\\sample.txt";

        private string execute()
        {
            FileReader r = new FileReader();
            return r.Read(path);
        }

        [SetUp]
        public void setup()
        {
            StreamWriter w = File.CreateText(path);
            w.Write(content);
            w.Flush();
            w.Close();
        }

        [TearDown]
        public void teardown()
        {
            File.Delete(path);
        }

        [Test]
        public void returns_valid_content()
        {
            Assert.AreEqual(content, execute());
        }
    }
}