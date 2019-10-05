using System;
using KacpiiToZiomal.SandstoneLauncher.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Types
{
    public class ApplicationData : IApplicationData
    {
        public string GetDirectory()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SandstoneLauncher\\";
        }

        public string GetBinaries()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SandstoneLauncher\\bin\\";
        }
    }
}