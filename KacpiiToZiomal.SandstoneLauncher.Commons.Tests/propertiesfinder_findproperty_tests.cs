using System;
using System.Linq;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Tests
{
    public class propertiesfinder_findproperty_tests
    {
        class Test
        {
            public int Integer { get; set; }

            public string String { get; set; }

            public bool Boolean { get; set; }
        }

        PropertyInfo execute<T>(Func<PropertyInfo[], PropertyInfo> f) => new PropertiesFinder().FindProperty(typeof(T), f);

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute<Test>(a => a.First()));
        }

        [Test]
        public void returns_excepted_property_targets_in_func()
        {
            Assert.AreEqual("Integer", execute<Test>(a => a.Single(x => x.PropertyType == typeof(int))).Name);
            Assert.AreEqual("Boolean", execute<Test>(a => a.Single(x => x.PropertyType == typeof(bool))).Name);
        }

        [Test]
        public void returns_null_if_any_property_not_matching_for_a_func()
        {
            Assert.IsNull(execute<Test>(a => a.SingleOrDefault(x => x.PropertyType == typeof(float))));
        }
    }
}