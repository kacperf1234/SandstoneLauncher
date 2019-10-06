using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Types;
using KacpiiToZiomal.SandstoneLauncher.Types;

namespace ConsoleLauncher
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            ProfileGetter getter = new ProfileGetter();
            getter.ProfilesReader = new ProfilesReader(new ProfilesPathGenerator(new ApplicationData()), new FileReader(), new ProfilesDeserializer());
            Profile profile = null;

            while (true)
            {
                profile = getter.GetProfile(new ProfileGetterSettings());
                Console.WriteLine(profile.ProfileName);
            }
                
        }
    }
}