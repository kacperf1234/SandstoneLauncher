using System.Windows;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces
{
    public interface IResourceDictionaryGenerator
    {
        ResourceDictionary GenerateResourceDictionary(Language lang);
    }
}