using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Interfaces
{
    public interface ISidePagesBuilder
    {
        List<ISidePageBuilder> Builders { get; set; }

        void RegisterBuilder(ISidePageBuilder builder);

        IEnumerable<SidePage> BuildPages();
    }
}