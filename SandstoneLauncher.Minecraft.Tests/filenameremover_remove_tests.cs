#region

using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    public class filenameremover_remove_tests
    {
        private string execute(string path)
        {
            FileNameRemover r = new FileNameRemover();
            return r.Remove(path);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("com\\kacpii\to\\ziomal.txt"));
        }

        [Test]
        public void returns_valid_string()
        {
            Assert.AreEqual(execute("com\\kacpii\\cheats.exe"), "com\\kacpii\\");
        }

        [Test]
        public void returns_file_name_when_only_file_name_gived()
        {
            Assert.AreEqual("kacpii.json", execute("kacpii.json"));
        }
    }
}