using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class ActuallyPathGenerator : IActuallyPathGenerator
    {
        public IApplicationData AppData { get; set; }
        
        public string GetPath()
        {
            return AppData.GetApplicationData() + "actually_language.json";
        }
    }
}