using System.Collections.Generic;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces
{
    public interface ILanguageFilesFilter
    {
        IEnumerable<string> Filter(string[] files);
    }
}