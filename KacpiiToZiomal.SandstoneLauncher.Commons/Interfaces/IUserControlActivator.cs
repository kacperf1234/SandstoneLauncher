using System.Windows.Controls;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IUserControlActivator
    {
        T Activate<T>() where T : UserControl;
    }
}