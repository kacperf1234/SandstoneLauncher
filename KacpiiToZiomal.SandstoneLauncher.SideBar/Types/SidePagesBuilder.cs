using System.Collections.Generic;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Types
{
    public class SidePagesBuilder : ISidePagesBuilder
    {
        public List<ISidePageBuilder> Builders { get; set; }

        public SidePagesBuilder()
        {
            Builders = new List<ISidePageBuilder>();
        }

        public void RegisterBuilder(ISidePageBuilder builder)
        {
            Builders.Add(builder);
        }

        public IEnumerable<SidePage> BuildPages()
        {
            foreach (ISidePageBuilder builder in Builders.OrderBy(x => x.Order))
                yield return builder.BuildSidePage();
        }
    }
}