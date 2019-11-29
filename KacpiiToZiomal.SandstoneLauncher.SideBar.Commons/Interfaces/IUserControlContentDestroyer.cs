using System;
using System.Windows.Controls;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces
{
    public interface IUserControlContentDestroyer
    {
        void Destroy(UserControl userControl);

        void Destroy(Type type, object o);
    }
}