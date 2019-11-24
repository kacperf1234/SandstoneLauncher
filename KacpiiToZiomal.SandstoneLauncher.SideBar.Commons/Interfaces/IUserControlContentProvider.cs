using System.Windows.Controls;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces
{
    public interface IUserControlContentProvider
    {
        object ProvideContent<T>() where T : UserControl;
    }
}