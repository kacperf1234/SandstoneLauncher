using System.Collections.Generic;
using System.Windows;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Windows
{
    public partial class ProfilesWindow : Window
    {
        public List<Profile> Profiles { get; set; }
        
        public ProfilesWindow(ProfileCollection profiles)
        {
            Profiles = profiles.Profiles;

            DataContext = this;
            InitializeComponent();
        }
    }
}