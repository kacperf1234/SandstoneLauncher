using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests
{
    public class contentpropertyfinder_find_tests
    {
        class GoodTest
        {
            public string Content { get; set; }
        }

        class BadTest
        {
            public int Content { get; set; }
        }

        PropertyInfo execute<T>()
        {
            ContentPropertyFinder finder = new ContentPropertyFinder(new ContentPropertyNameGenerator(), new ContentPropertyValidator());
            return finder.FindAndThrowIfDontValid(typeof(T));
        }

        [Test]
        public void dont_throws_exceptions_when_gived_is_a_goodtest()
        {
            Assert.DoesNotThrow(() => { execute<GoodTest>();});
        }

        [Test]
        public void throws_invalidoperationexception_when_gived_is_badtest()
        {
            Assert.That(execute<BadTest>, Throws.InvalidOperationException);
        }

        [Test]
        public void returns_notnull_with_gived_goodtest()
        {
            Assert.NotNull(execute<GoodTest>());
        }

        [Test]
        public void returns_propertyinfo_propertytype_equals_to_string()
        {
            Assert.AreEqual(typeof(string), execute<GoodTest>().PropertyType);
        }

        [Test]
        public void returns_propertyinfo_name_equals_to_Content()
        {
            Assert.AreEqual("Content", execute<GoodTest>().Name);
        }
    }
}