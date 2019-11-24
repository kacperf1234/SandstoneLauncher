using System.Windows.Controls;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class UserControlContentDestroyer : IUserControlContentDestroyer
    {
        public void Destroy(UserControl userControl)
        {
            userControl.Content = null;
        }
    }
}