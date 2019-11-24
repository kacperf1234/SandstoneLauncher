using System.Collections.Generic;
using System.Windows;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.GamePage.Types;
using KacpiiToZiomal.SandstoneLauncher.Languages.Types;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Types;

namespace KacpiiToZiomal.SandstoneLauncher
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LanguageLoader.Load("en", Resources);

            SidePagesBuilder builder = new SidePagesBuilder();
            builder.RegisterBuilder(new GamePageSidePageBuilder(new UserControlContentProvider(
                new UserControlContentExtractor(), new UserControlActivator(),
                new UserControlInitializer(new InitializeMethodFinder(new InitializeMethodNameProvider())),
                new UserControlContentDestroyer())));
            IEnumerable<SidePage> pages = builder.BuildPages();

            foreach (SidePage page in pages) ListView.Items.Add(page.Item);
        }
    }
}