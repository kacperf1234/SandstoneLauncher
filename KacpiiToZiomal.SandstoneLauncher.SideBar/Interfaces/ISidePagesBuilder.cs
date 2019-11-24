using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Interfaces
{
    public interface ISidePagesBuilder
    {
        List<ISidePageBuilder> Builders { get; set; }

        void RegisterBuilder(ISidePageBuilder builder);

        IEnumerable<SidePage> BuildPages();
    }
}