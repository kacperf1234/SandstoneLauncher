using KacpiiToZiomal.SandstoneLauncher.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface ISidePageBuilder
    {
        int Order { get; set; }
        
        SidePage BuildSidePage();
    }
}