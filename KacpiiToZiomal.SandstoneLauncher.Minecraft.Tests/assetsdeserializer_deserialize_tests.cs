#region

using System.Collections.Generic;
using System.Net.Http;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class assetsdeserializer_deserialize_tests
    {
        private Assets execute(
            string url =
                "https://launchermeta.mojang.com/v1/packages/695d8e3d95465bece605c92e9b0385278018eff9/1.14.json")
        {
            HttpClient c = new HttpClient();
            string content = c.GetStringAsync(url).Result;

            IJsonDeserializer<Assets> deserializer = new AssetsDeserializer();
            Assets assets = deserializer.Deserialize(content);

            return assets;
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_valid_items_lenght()
        {
            Assert.IsTrue(execute().Keys.Count > 2000);
        }

        [Test]
        public void returns_dont_contains_objects_key()
        {
            foreach (KeyValuePair<string, Asset> asset in execute().AssetList) Assert.AreNotEqual("objects", asset.Key);
        }
    }
}