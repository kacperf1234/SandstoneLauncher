using System;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests
{
    public class contentpropertyvalidator_validate_tests
    {
        class BadTest
        {
            public int Content { get; set; }
        }

        class NonPublicTest
        {
            private string Content { get;  set; }
        }

        class GoodTest
        {
            public string Content { get; set; }
        }

        class NullTest
        {
        }

        bool execute<T>()
        {
            T t = Activator.CreateInstance<T>();
            PropertyInfo propertyInfo = t.GetType().GetProperty("Content");

            ContentPropertyValidator contentPropertyValidator = new ContentPropertyValidator();
            return contentPropertyValidator.Validate(propertyInfo);
        }

        [Test]
        public void goodtest_dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute<GoodTest>());
        }

        [Test]
        public void badtest_dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute<BadTest>());
        }

        [Test]
        public void returns_true_if_gived_is_goodtest()
        {
            Assert.IsTrue(execute<GoodTest>());
        }

        [Test]
        public void returns_false_if_gived_is_nonpublic_test()
        {
            Assert.IsFalse(execute<NonPublicTest>());
        }

        [Test]
        public void returns_false_if_gived_is_badtest()
        {
            Assert.IsFalse(execute<BadTest>());
        }

        [Test]
        public void returns_false_if_gived_is_nulltest()
        {
            Assert.IsFalse(execute<NullTest>());
        }
    }
}