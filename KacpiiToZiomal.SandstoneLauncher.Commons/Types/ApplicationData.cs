using System;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class ApplicationData : IApplicationData
    {
        public string GetLanguages()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SandstoneLauncher\\";
        }

        public string GetApplicationData()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SandstoneLauncher\\";
        }
    }
}