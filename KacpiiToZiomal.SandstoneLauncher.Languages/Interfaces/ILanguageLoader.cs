using System.Windows;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces
{
    public interface ILanguageLoader
    {
        void Load(ResourceDictionary baseResources, string shortname);
    }
}