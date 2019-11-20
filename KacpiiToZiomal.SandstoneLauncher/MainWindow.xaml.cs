using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;
using KacpiiToZiomal.SandstoneLauncher.Languages.Types;

namespace KacpiiToZiomal.SandstoneLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            LanguageLoader loader = new LanguageLoader(
                new LanguagesProvider(new FileListGenerator(), new LanguageFilesFilter(new LanguageFileNameValidator()),
                    new JsonDeserializer<Language>(), new FileReader(), new ApplicationData()), new LanguageExtractor(),
                new ResourceDictionaryGenerator(new ResourceKeyNameGenerator()), new ResourceDictionaryMerger(), new ActuallyLanguageProvider(new JsonDeserializer<ActuallyLanguage>(), new FileReader(), new ActuallyLanguagePathGenerator(new ApplicationData())));
            
            loader.LoadActually(Resources);
            
            InitializeComponent();
        }
    }
}
