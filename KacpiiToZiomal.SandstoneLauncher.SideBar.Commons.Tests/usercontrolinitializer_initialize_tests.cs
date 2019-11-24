using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests.Exceptions;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests
{
    public class usercontrolinitializer_initialize_tests
    {
        class UserControl
        {
        }

        class MyUserControl : UserControl
        {
            public void InitializeComponent()
            {
                throw new TestException();
            }
        }
    }
}