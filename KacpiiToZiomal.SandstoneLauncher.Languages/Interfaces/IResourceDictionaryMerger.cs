using System.Windows;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces
{
    public interface IResourceDictionaryMerger
    {
        void Merge(ResourceDictionary toadd, ref ResourceDictionary resources);
    }
}