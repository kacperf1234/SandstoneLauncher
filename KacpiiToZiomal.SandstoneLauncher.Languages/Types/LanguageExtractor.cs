using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class LanguageExtractor : ILanguageExtractor
    {
        public Language GetLanguage(Models.Languages languages, string shortname)
        {
            return languages
                .Where(x => x.Data.ShortName == shortname)
                .First();
        }
    }
}