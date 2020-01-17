using System;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Tests
{
    public class typegetter_gettype_object_tests
    {
        class Test
        {
        }

        Type execute(object o = default(object)) => new TypeGetter().GetType(o);

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(new Test()));
        }

        [Test]
        public void returns_excepted_type_of_typeof()
        {
            Assert.IsTrue(execute(new Test()) == typeof(Test));
        }

        [Test]
        public void returns_excepted_type_of_gettype_method()
        {
            Assert.IsTrue(execute(new Test()) == new Test().GetType());
        }
    }
}