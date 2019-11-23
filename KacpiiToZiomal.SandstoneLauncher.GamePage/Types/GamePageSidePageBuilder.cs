using System.Windows.Controls;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.GamePage.Controls;

namespace KacpiiToZiomal.SandstoneLauncher.GamePage.Types
{
    public class GamePageSidePageBuilder : ISidePageBuilder
    {
        public int Order { get; set; } = 0;
        
        public SidePage BuildSidePage()
        {
            GameGrid grid = new GameGrid();
            grid.InitializeComponent();
            
            GameItem item = new GameItem();
            item.InitializeComponent();

            ListViewItem listViewItem = (ListViewItem) item.Content;
            Grid gridContent = (Grid) grid.Content;

            item.Content = null;
            grid.Content = null;
            
            return SidePage.Create(gridContent, listViewItem);
        }
    }
}