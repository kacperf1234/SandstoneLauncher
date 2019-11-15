#region

using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class assetsfinder_getassets_tests
    {
        private readonly string url =
            "https://launchermeta.mojang.com/v1/packages/695d8e3d95465bece605c92e9b0385278018eff9/1.14.json";

        private Assets execute()
        {
            AssetsFinder f = new AssetsFinder(new NetworkClient(), new AssetsDeserializer());
            Assets assets = f.GetAssets(url, new FullVersion
            {
                Assets = "1.14",
                AssetsIndex = new AssetsIndex
                {
                    Url =
                        "https://launchermeta.mojang.com/v1/packages/695d8e3d95465bece605c92e9b0385278018eff9/1.14.json"
                }
            });
            return assets;
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_not_empty_basejson()
        {
            Assert.AreNotEqual("", execute().BaseJson);
        }

        [Test]
        public void returns_valid_items_count()
        {
            Assert.IsTrue(execute().AssetList.Count == 2032);
        }
    }
}