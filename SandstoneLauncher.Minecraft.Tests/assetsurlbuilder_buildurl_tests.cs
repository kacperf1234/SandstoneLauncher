#region

using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class assetsurlbuilder_buildurl_tests
    {
        private string execute(string hash = "991b421dfd401f115241601b2b373140a8d78572")
        {
            AssetsUrlBuilder b = new AssetsUrlBuilder(new HashCombiner());
            return b.BuildUrl(hash);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_results()
        {
            Assert.AreEqual("http://resources.download.minecraft.net/99/991b421dfd401f115241601b2b373140a8d78572",
                execute());
        }

        [Test]
        public void returns_excepted_results_second()
        {
            Assert.AreEqual("http://resources.download.minecraft.net/99/991b421dfd401f115241601b2b373140a8d78572",
                execute());
        }
    }
}