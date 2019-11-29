using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests
{
    public class objectactivator_activate_tests
    {
        class TestBase
        {
        }

        class Test : TestBase
        {
        }

        Test execute()
        {
            ObjectActivator<TestBase> activator = new ObjectActivator<TestBase>();
            return activator.Activate<Test>();
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => { execute();});
        }

        [Test]
        public void returns_result_are_not_null()
        {
            Assert.NotNull(execute());
        }

        [Test]
        public void returns_type_of_results_equals_to_test()
        {
            Assert.AreEqual(typeof(Test), execute().GetType());
        }

        [Test]
        public void returns_basetype_of_results_equals_to_testbase()
        {
            Assert.AreEqual(typeof(TestBase), execute().GetType().GetTypeInfo().BaseType);
        }
    }
}