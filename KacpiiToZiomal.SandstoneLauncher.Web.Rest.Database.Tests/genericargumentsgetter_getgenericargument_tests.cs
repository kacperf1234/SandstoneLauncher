using System;
using System.Linq;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Tests
{
    public class genericargumentsgetter_getgenericargument_tests
    {
        class Test
        {
            public Test2<float> First { get; set; }
            public Test2<int, bool> Second { get; set; }
            public Test2 Third { get; set; }
        }

        partial class Test2
        {
        }

        partial class Test2<T>
        {
        }

        partial class Test2<T1, T2>
        {
        }

        Type execute(Func<Type[], Type> func, string propName = "First")
        {
            Test test = new Test();
            Type t = test.GetType();
            PropertyInfo prop = t.GetProperty(propName);

            GenericArgumentsGetter getter = new GenericArgumentsGetter();
            return getter.GetGenericArgument(prop.PropertyType, func);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(f => f.First(), "First"));
        }

        [Test]
        public void returns_typeof_float_if_targets_is_first_parameter()
        {
            Assert.IsTrue(typeof(float) == execute(f => f.First()));
        }

        [Test]
        public void returns_typeof_int_if_targets_if_first_parameter_of_second_test_property()
        {
            Assert.IsTrue(typeof(int) == execute(f => f.First(), "Second"));
        }

        [Test]
        public void returns_bool_if_targets_is_second_parameter_of_second_test_property()
        {
            Assert.IsTrue(typeof(bool) == execute(f => f.Last(), "Second"));
        }

        [Test]
        public void throws_exceptions_if_targets_is_third_and_linq_selects_first()
        {
            Assert.That(() => execute(f => f.First(), "Third"), Throws.InvalidOperationException);
        }

        [Test]
        public void dont_throws_exceptions_if_targets_is_third_and_linq_dont_select_anything()
        {
            Assert.DoesNotThrow(() => execute(f => typeof(int), "Third"));
        }
    }
}