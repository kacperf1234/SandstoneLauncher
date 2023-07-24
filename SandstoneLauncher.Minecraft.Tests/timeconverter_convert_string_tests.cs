#region

using System;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    public class timeconverter_convert_string_tests
    {
        private DateTime execute(string s = "2014-05-14T15:24:47+00:00")
        {
            TimeConverter c = new TimeConverter();
            return c.Convert(s);
        }

        [Test]
        public void does_not_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_not_null()
        {
            Assert.NotNull(execute());
        }

        [Test]
        public void returns_valid_year()
        {
            Assert.IsTrue(execute().Year == 2014);
        }

        [Test]
        public void returns_valid_month()
        {
            Assert.IsTrue(execute().Month == 5);
        }

        [Test]
        public void returns_valid_day()
        {
            Assert.IsTrue(execute().Day == 14);
        }

        [Test]
        public void returns_valid_hour()
        {
            Assert.IsTrue(execute().Hour == 15);
        }

        [Test]
        public void returns_valid_minute()
        {
            Assert.IsTrue(execute().Minute == 24);
        }

        [Test]
        public void returns_valid_second()
        {
            Assert.IsTrue(execute().Second == 47);
        }

        [Test]
        public void throws_when_string_is_bad()
        {
            Assert.That(() => execute("2014-24242-42424215525252-xxx"), Throws.ArgumentException);
        }
    }
}