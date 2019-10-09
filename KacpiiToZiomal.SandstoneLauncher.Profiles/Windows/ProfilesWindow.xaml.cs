using System.Collections.Generic;
using System.Windows;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Windows
{
    public partial class ProfilesWindow : Window
    {
        public ProfileCollection ProfileCollection { get; set; }
    
        public List<Profile> Profiles
        {
            get
            {
                return ProfileCollection.Profiles;
            }
        }
        
        public ProfilesWindow(ProfileCollection profiles)
        {
            ProfileCollection = profiles;

            DataContext = this;
            InitializeComponent();
        }
    }
}