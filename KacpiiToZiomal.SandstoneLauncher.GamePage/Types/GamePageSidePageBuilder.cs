using KacpiiToZiomal.SandstoneLauncher.GamePage.Controls;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.GamePage.Types
{
    public class GamePageSidePageBuilder : ISidePageBuilder
    {
        public IUserControlContentProvider ContentProvider;

        public GamePageSidePageBuilder(IUserControlContentProvider contentProvider)
        {
            ContentProvider = contentProvider;
        }

        public int Order { get; set; } = 2;

        public SidePage BuildSidePage()
        {
            object grid = ContentProvider.ProvideContent<GameGrid>();
            object item = ContentProvider.ProvideContent<GameItem>();

            return SidePage.Create(grid, item);
        }
    }
}