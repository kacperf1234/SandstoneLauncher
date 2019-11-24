using System.Windows.Controls;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces
{
    public interface IUserControlContentExtractor
    {
        object ExtractContent(UserControl uc);
    }
}