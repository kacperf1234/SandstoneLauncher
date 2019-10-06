using System;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Windows;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Types
{
    public class ProfileGetter : IProfileGetter
    {
        public IProfilesReader ProfilesReader;
        
        public Profile GetProfile(ProfileGetterSettings settings)
        {
            // get all data about existing profiles...
            ProfileCollection profileCollection = ProfilesReader.ReadProfiles();
            
            // use received data as model in window.
            ProfilesWindow profilesWnd = new ProfilesWindow(profileCollection);
            profilesWnd.ShowDialog();
            
            
            throw new NotImplementedException();
        }
    }
}