using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class jsonserializer_serialize_tests
    {
        private string execute<T>(T arg)
        {
            return new JsonSerializer<T>().Serialize(arg);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => { execute(new sample()); });
        }

        [Test]
        public void returns_not_null()
        {
            Assert.NotNull(execute(new sample()));
        }

        [Test]
        public void returns_not_empty_string()
        {
            Assert.IsNotEmpty(execute(new sample()));
        }

        [Test]
        public void returns_string_with_excepted_segments()
        {
            string s = execute(new sample { x = 5, y = 10 });

            Assert.IsTrue(s.Contains("\"x\": 5"));
            Assert.IsTrue(s.Contains("\"y\": 10"));
        }

        [Test]
        public void returns_string_startwith_brace()
        {
            string s = execute(new sample { x = 5, y = 8 });

            Assert.IsTrue(s.StartsWith("{"));
        }

        [Test]
        public void returns_string_endswith_brace()
        {
            string s = execute(new sample { x = 5, y = 8 });

            Assert.IsTrue(s.EndsWith("}"));
        }

        private class sample
        {
            public int x;
            public int y;
        }
    }
}