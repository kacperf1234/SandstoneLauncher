#region

using SandstoneLauncher.Minecraft.Types;
using Newtonsoft.Json;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class jsondeserializer_deserialize_tests
    {
        private sampleclass execute()
        {
            return new JsonDeserializer<sampleclass>().Deserialize(
                @"{'X': 5, 'Y': 15, 'boruto': 'kacpii'}".Replace("'", "\""));
        }

        [Test]
        public void returns_valid_x()
        {
            Assert.IsTrue(execute().X == 5);
        }

        [Test]
        public void returns_valid_y()
        {
            Assert.IsTrue(execute().Y == 15);
        }

        [Test]
        public void returns_valid_name()
        {
            Assert.AreEqual("kacpii", execute().Name);
        }

        private class sampleclass
        {
            [JsonProperty("boruto")]
            public string Name;

            public int X;
            public int Y;
        }
    }
}