using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.GamePage.Controls;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.GamePage.Types
{
    public class GamePageSidePageBuilder : ISidePageBuilder
    {
        public IUserControlContentProvider ContentProvider;

        public GamePageSidePageBuilder(IUserControlContentProvider contentProvider)
        {
            ContentProvider = contentProvider;
        }

        public int Order { get; set; } = 0;

        public SidePage BuildSidePage()
        {
            object grid = ContentProvider.ProvideContent<GameGrid>();
            object item = ContentProvider.ProvideContent<GameItem>();

            return SidePage.Create(grid, item);
        }
    }
}