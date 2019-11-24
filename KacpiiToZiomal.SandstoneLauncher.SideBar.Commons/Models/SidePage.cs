using System.Windows.Controls;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Models
{
    public class SidePage
    {
        public Grid Grid { get; set; }

        public ListViewItem Item { get; set; }

        public static SidePage Create(Grid grid, ListViewItem item)
        {
            return new SidePage()
            {
                Grid = grid,
                Item = item
            };
        }
        
        public static SidePage Create(object grid, object item)
        {
            return new SidePage()
            {
                Grid = (Grid) grid,
                Item = (ListViewItem) item
            };
        }
    }
}