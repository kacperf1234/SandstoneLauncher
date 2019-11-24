using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class SidePageBuilder : ISidePageBuilder
    {
        public ISidePageGridProvider GridProvider;

        public int Order { get; set; }

        public SidePage BuildSidePage()
        {
            return null;
        }
    }
}