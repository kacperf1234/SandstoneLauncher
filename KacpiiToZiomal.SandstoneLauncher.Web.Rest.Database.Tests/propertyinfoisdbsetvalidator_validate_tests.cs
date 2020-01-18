using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NUnit.Framework;
using DbSetFinder = KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types.DbSetFinder;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Tests
{
    public class propertyinfoisdbsetvalidator_validate_tests
    {
        class Test
        {
            public DbSet<Test2> Tests2 { get; set; }
            public DbSet<Test3> Tests3 { get; set; }
            public Test3 Test3 { get; set; }
        }

        class Test2
        {
        }

        class Test3
        {
        }

        bool execute<T>(string propName = "Tests2")
        {
            PropertyInfo prop = typeof(Test).GetProperty(propName);

            PropertyInfoIsDbSetValidator v = new PropertyInfoIsDbSetValidator(new TypeComparer(), new TypeGetter(), new DbSetTypeProvider(), new GenericArgumentsGetter(), new PropertyInfoContainsGenericArgumentsValidator());

            return v.Validate(prop, typeof(T));
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute<Test2>("Tests2"));
        }

        [Test]
        public void returns_true_if_validating_Tests2_for_Test2()
        {
            Assert.IsTrue(execute<Test2>("Tests2"));
        }

        [Test]
        public void returns_false_if_validating_Tests2_for_Test3()
        {
            Assert.IsFalse(execute<Test3>("Tests2"));
        }
    }
}