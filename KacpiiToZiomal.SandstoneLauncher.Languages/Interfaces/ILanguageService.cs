using KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces
{
    public interface ILanguageService
    {
        void SetLanguage(Language language);

        Language GetLangugage();
    }
}