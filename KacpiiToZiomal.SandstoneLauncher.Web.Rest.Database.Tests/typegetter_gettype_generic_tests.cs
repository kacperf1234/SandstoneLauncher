using System;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Tests
{
    public class typegetter_gettype_generic_tests
    {
        class Test
        {
        }

        Type execute<T>() => new TypeGetter().GetType<T>();

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute<Test>());
        }

        [Test]
        public void returns_same_results_that_typeof()
        {
            Assert.IsTrue(typeof(Test) == execute<Test>());
        }

        [Test]
        public void returns_another_results_than_typeof_if_method_takes_another_type()
        {
            Assert.IsFalse(typeof(Test) == execute<typegetter_gettype_generic_tests>());
        }
    }
}