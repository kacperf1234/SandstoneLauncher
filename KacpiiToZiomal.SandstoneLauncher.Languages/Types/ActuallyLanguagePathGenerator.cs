using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class ActuallyLanguagePathGenerator : IActuallyLanguagePathGenerator
    {
        public IApplicationData AppData;

        public ActuallyLanguagePathGenerator(IApplicationData appData)
        {
            AppData = appData;
        }

        public string GeneratePath()
        {
            return AppData.GetApplicationData() + "actually_language.json";
        }
    }
}