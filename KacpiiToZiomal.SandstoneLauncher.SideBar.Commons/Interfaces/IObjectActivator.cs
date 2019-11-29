using System.Windows.Controls;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces
{
    public interface IObjectActivator<in TBase>
    {
        T Activate<T>() where T : TBase;
    }
}