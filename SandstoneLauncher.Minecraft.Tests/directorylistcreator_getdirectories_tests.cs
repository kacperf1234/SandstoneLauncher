#region

using System.Collections.Generic;
using System.IO;
using System.Linq;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class directorylistcreator_getdirectories_tests
    {
        private readonly string basepath = "tests\\";

        private readonly string[] paths = new string[3]
        {
            "tests\\directory-1",
            "tests\\directory-2",
            "tests\\directory-3"
        };

        private IEnumerable<string> execute()
        {
            DirectoryListCreator c = new DirectoryListCreator();
            return new List<string>(c.GetDirectories(basepath));
        }

        [SetUp]
        public void setup()
        {
            foreach (string path in paths) Directory.CreateDirectory(path);
        }

        [TearDown]
        public void teardown()
        {
            foreach (string path in paths) Directory.Delete(path);
        }

        [Test]
        public void returns_valid_items_count()
        {
            Assert.IsTrue(execute().Count() == 3);
        }

        [Test]
        public void returns_contains_paths_array_items()
        {
            foreach (string item in execute())
            {
                string s = paths.Where(x => x == item).FirstOrDefault();

                Assert.AreNotEqual(default(string), s);
            }
        }
    }
}