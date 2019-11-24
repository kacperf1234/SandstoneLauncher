using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class LanguageFilesFilter : ILanguageFilesFilter
    {
        public ILanguageFileNameValidator Validator;

        public LanguageFilesFilter(ILanguageFileNameValidator validator)
        {
            Validator = validator;
        }

        public IEnumerable<string> Filter(string[] files)
        {
            foreach (string file in files)
                if (Validator.Validate(file))
                    yield return file;
        }
    }
}