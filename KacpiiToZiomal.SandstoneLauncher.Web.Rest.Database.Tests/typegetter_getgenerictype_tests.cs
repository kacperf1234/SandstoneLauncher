using System;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Tests
{
    public class typegetter_getgenerictype_tests
    {
        class Test<T> {}
        class Test2 {}
        
        Type execute() => new TypeGetter().GetGenericType(typeof(Test<>));

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_valid_generic_type_definition()
        {
            Assert.IsTrue(execute().IsGenericTypeDefinition);
        }
    }
}