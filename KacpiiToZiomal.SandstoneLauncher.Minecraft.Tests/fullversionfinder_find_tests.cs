#region

using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class fullversionfinder_find_tests
    {
        private FullVersion execute(string url)
        {
            FullVersionFinder finder = new FullVersionFinder(new NetworkClient(), new FullVersionParser());
            return finder.Find(
                "https://launchermeta.mojang.com/v1/packages/7f40b382dedcfe9eca74a5b14d615075ec34c108/1.9.4.json");
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() =>
                execute(
                    "https://launchermeta.mojang.com/v1/packages/7f40b382dedcfe9eca74a5b14d615075ec34c108/1.9.4.json"));
        }

        [Test]
        public void returns_valid_full_version_id()
        {
            Assert.AreEqual("1.9.4",
                execute(
                        "https://launchermeta.mojang.com/v1/packages/7f40b382dedcfe9eca74a5b14d615075ec34c108/1.9.4.json")
                    .Id);
        }
    }
}