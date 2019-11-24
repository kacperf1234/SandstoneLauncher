using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.GamePage.Types;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;
using KacpiiToZiomal.SandstoneLauncher.Languages.Types;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Types;

namespace KacpiiToZiomal.SandstoneLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            LanguageLoader.Load("en", Resources);
            
            SidePagesBuilder builder = new SidePagesBuilder();
            builder.RegisterBuilder(new GamePageSidePageBuilder(new UserControlContentProvider(new UserControlContentExtractor(), new UserControlActivator(), new UserControlInitializer(), new UserControlContentDestroyer())));
            IEnumerable<SidePage> pages = builder.BuildPages();

            foreach (SidePage page in pages)
            {
                ListView.Items.Add(page.Item);
            }
        }
    }
}