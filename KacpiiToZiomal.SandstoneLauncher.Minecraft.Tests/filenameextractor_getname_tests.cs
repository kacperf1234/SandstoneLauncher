#region

using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class filenameextractor_getname_tests
    {
        private string execute(string path)
        {
            FileNameExtractor e = new FileNameExtractor(new PathConverter());
            return e.GetName(path);
        }

        [Test]
        public void dont_throws()
        {
            Assert.DoesNotThrow(() => execute("google\\com\\file.jar"));
        }

        [Test]
        public void returns_valid_value()
        {
            Assert.AreEqual("kacper.jar", execute("com\\google\\kacper.jar"));
        }
    }
}