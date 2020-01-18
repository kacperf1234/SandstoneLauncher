using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Tests
{
    public class propertyinfocontainsgenericargumentsvalidator_containsgenericarguments_tests
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
        
        bool execute(string propName = "First")
        {
            Type t = typeof(Test).GetProperty(propName).PropertyType;

            return new PropertyInfoContainsGenericArgumentsValidator().ContainsGenericArguments(t);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_false_if_property_not_have_a_generic_arguments()
        {
            Assert.IsFalse(execute("Third"));
        }

        [Test]
        public void returns_true_if_property_have_generic_parameters()
        {
            Assert.IsTrue(execute("Second"));
        }
        
        [Test]
        public void returns_true_if_property_have_generic_parameter()
        {
            Assert.IsTrue(execute("First"));
        }
    }
}