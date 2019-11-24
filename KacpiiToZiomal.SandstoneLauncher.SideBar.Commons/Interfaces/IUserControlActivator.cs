using System.Windows.Controls;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces
{
    public interface IUserControlActivator
    {
        T Activate<T>() where T : UserControl;
    }
}