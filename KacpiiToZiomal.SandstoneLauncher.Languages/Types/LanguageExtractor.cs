using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class LanguageExtractor : ILanguageExtractor
    {
        public Language GetLanguage(Models.Languages languages, LanguageSettings settings)
        {
            return languages
                .Where(x => x.Data.ShortName == settings.ShortName)
                .First();
        }
    }
}