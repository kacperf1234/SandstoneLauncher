using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class LanguageFileNameValidator : ILanguageFileNameValidator
    {
        public bool Validate(string filename)
        {
            return filename.EndsWith("-lang.json");
        }
    }
}