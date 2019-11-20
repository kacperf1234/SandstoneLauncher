using KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces
{
    public interface ILanguageExtractor
    {
        Language GetLanguage(Models.Languages languages, string shortname);
    }
}