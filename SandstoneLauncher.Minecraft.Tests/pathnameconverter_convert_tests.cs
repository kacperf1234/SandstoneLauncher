#region

using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
public class pathnameconverter_convert_tests
    {
        private string execute(string path)
        {
            PathNameConverter c = new PathNameConverter();
            return c.Convert(path);
        }

        [Test]
        public void returns_excepted_result()
        {
            Assert.AreEqual("google.jar", execute("com/google/net/google.jar"));
        }
    }
}