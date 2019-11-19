using System.Windows;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;
using m = KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class LanguageLoader : ILanguageLoader
    {
        public ILanguagesProvider Provider;
        public ILanguageExtractor Extractor;
        public IResourceDictionaryGenerator Generator;
        public IResourceDictionaryMerger Merger;

        public LanguageLoader(ILanguagesProvider provider, ILanguageExtractor extractor, IResourceDictionaryGenerator generator, IResourceDictionaryMerger merger)
        {
            Provider = provider;
            Extractor = extractor;
            Generator = generator;
            Merger = merger;
        }

        public void Load(LanguageSettings settings, ref ResourceDictionary resources)
        {
            m.Languages languages = Provider.ProvideLanguages();
            Language language = Extractor.GetLanguage(languages, settings);
            ResourceDictionary resourceDictionary = Generator.GenerateResourceDictionary(language);
            
            Merger.Merge(resourceDictionary, ref resources);
        }
    }
}