using System.Windows;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class ResourceDictionaryMerger : IResourceDictionaryMerger
    {
        public void Merge(ResourceDictionary toadd, ref ResourceDictionary resources)
        {
            resources.MergedDictionaries.Add(toadd);
        }
    }
}