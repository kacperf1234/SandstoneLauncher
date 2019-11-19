using System.Collections.Generic;
using System.Windows;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class ResourceDictionaryGenerator : IResourceDictionaryGenerator
    {
        public ResourceDictionary GenerateResourceDictionary(Language lang)
        {
            ResourceDictionary resources = new ResourceDictionary();
            
            foreach (KeyValuePair<string,string> pair in lang.Strings)
            {
                resources.Add(pair.Key, pair.Value);
            }

            return resources;
        }
    }
}