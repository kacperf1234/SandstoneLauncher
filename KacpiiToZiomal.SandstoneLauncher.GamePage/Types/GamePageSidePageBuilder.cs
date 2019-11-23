using System.Windows.Controls;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.GamePage.Controls;

namespace KacpiiToZiomal.SandstoneLauncher.GamePage.Types
{
    public class GamePageSidePageBuilder : ISidePageBuilder
    {
        public int Order { get; set; } = 0;

        public IUserControlContentProvider ContentProvider;

        public GamePageSidePageBuilder(IUserControlContentProvider contentProvider)
        {
            ContentProvider = contentProvider;
        }

        public SidePage BuildSidePage()
        {
            object grid = ContentProvider.ProvideContent<GameGrid>();
            object item = ContentProvider.ProvideContent<GameItem>();
            
            return SidePage.Create(grid, item);
        }
    }
}