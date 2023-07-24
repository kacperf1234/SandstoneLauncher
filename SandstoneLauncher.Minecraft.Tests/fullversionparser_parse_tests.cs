#region

using System.Net.Http;
using System.Reflection;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    public class fullversionparser_parse_tests
    {
        private FullVersion execute()
        {
            HttpClient http = new HttpClient();
            string json = http
                .GetStringAsync(
                    "https://launchermeta.mojang.com/v1/packages/132979c36455cc1e17e5f9cc767b4e13c6947033/1.14.4.json")
                .Result;

            IJsonParser<FullVersion> parser = new FullVersionParser();
            return parser.Parse(json);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_valid_assets_string()
        {
            Assert.AreEqual(execute().Assets, "1.14");
        }

        [Test]
        public void returns_valid_id_string()
        {
            Assert.AreEqual(execute().Id, "1.14.4");
        }

        [Test]
        public void returns_valid_mainclass()
        {
            Assert.AreEqual(execute().MainClass, "net.minecraft.client.main.Main");
        }

        [Test]
        public void returns_doesnt_reflection_null_properties()
        {
            FullVersion e = execute();

            foreach (PropertyInfo prop in e.GetType().GetProperties()) Assert.NotNull(prop.GetValue(e));
        }
    }
}