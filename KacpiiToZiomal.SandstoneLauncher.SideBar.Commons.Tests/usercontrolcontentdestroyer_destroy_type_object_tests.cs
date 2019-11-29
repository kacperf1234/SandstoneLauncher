using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests
{
    public class usercontrolcontentdestroyer_destroy_type_object_tests
    {
        class Test
        {
            public string Content { get; set; } = string.Empty;
        }

        class BadTest
        {
            public int Content { get; set; }
        }
        
        object execute(object instance)
        {
            UserControlContentDestroyer destroyer
                = new UserControlContentDestroyer(new ContentPropertyFinder(new ContentPropertyNameGenerator(), new ContentPropertyValidator()), new PropertyValueRemover(), new ContentPropertyValidator());
            
            destroyer.Destroy(instance.GetType(), instance);

            return instance;
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(new Test()));
        }

        [Test]
        public void content_property_are_different_values_before_and_after()
        {
            Test test = new Test();
            Assert.AreNotEqual(test.Content, execute(test));
        }

        [Test]
        public void throws_exceptions_if_gived_is_badtest()
        {
            Assert.That(() => { execute(new BadTest()); }, Throws.InvalidOperationException);
        }

        [Test]
        public void returns_null_if_gived_is_test()
        {
            Test test = new Test();
            execute(test);
            
            Assert.IsNull(test.Content);
        }
    }
}