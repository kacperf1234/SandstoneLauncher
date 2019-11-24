using System.Windows.Controls;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class UserControlContentExtractor : IUserControlContentExtractor
    {
        public object ExtractContent(UserControl uc)
        {
            return uc.Content;
        }
    }
}