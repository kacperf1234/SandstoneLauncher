using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests
{
    public class usercontrolinitializer_initialize_tests
    {
        private void execute(MyUserControl instance)
        {
            new UserControlInitializer(new InitializeMethodFinder(new InitializeMethodNameProvider()))
                .Initialize(instance);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(new MyUserControl()));
        }

        [Test]
        public void initialized_state_are_changed_after_invoke()
        {
            MyUserControl uc = new MyUserControl();
            bool before = uc.Initialized;
            execute(uc);
            bool after = uc.Initialized;

            Assert.IsFalse(before == after);
        }

        [Test]
        public void initialized_state_are_true_after_invoke_and_before_are_false()
        {
            MyUserControl uc = new MyUserControl();
            bool before = uc.Initialized;
            execute(uc);
            bool after = uc.Initialized;

            Assert.IsFalse(before);
            Assert.IsTrue(after);
        }

        private class UserControl
        {
        }

        private class MyUserControl : UserControl
        {
            public bool Initialized;

            public void InitializeComponent()
            {
                Initialized = true;
            }
        }
    }
}