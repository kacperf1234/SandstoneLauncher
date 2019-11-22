using System.Windows;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
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
        public IActuallyLanguageProvider ActuallyLanguageProvider;

        public LanguageLoader(ILanguagesProvider provider, ILanguageExtractor extractor, IResourceDictionaryGenerator generator, IResourceDictionaryMerger merger, IActuallyLanguageProvider actuallyLanguageProvider)
        {
            Provider = provider;
            Extractor = extractor;
            Generator = generator;
            Merger = merger;
            ActuallyLanguageProvider = actuallyLanguageProvider;
        }

        public static void Load(string shortname, ResourceDictionary baseResources)
        {
            LanguageLoader loader = new LanguageLoader(
                new LanguagesProvider(new FileListGenerator(), new LanguageFilesFilter(new LanguageFileNameValidator()),
                    new JsonDeserializer<Language>(), new FileReader(), new ApplicationData()), new LanguageExtractor(),
                new ResourceDictionaryGenerator(new ResourceKeyNameGenerator()), new ResourceDictionaryMerger(), new ActuallyLanguageProvider(new JsonDeserializer<Language>(), new FileReader(), new ActuallyLanguagePathGenerator(new ApplicationData())));
            
            loader.Load(baseResources, shortname);
        }

        public static void Load(Language language, ResourceDictionary baseResources)
        {
            LanguageLoader loader = new LanguageLoader(
                new LanguagesProvider(new FileListGenerator(), new LanguageFilesFilter(new LanguageFileNameValidator()),
                    new JsonDeserializer<Language>(), new FileReader(), new ApplicationData()), new LanguageExtractor(),
                new ResourceDictionaryGenerator(new ResourceKeyNameGenerator()), new ResourceDictionaryMerger(), new ActuallyLanguageProvider(new JsonDeserializer<Language>(), new FileReader(), new ActuallyLanguagePathGenerator(new ApplicationData())));

            loader.Load(baseResources, language);
        }

        public void Load(ResourceDictionary baseResources, string shortname)
        {
            m.Languages languages = Provider.ProvideLanguages();
            Language language = Extractor.GetLanguage(languages, shortname);
            ResourceDictionary resourceDictionary = Generator.GenerateResourceDictionary(language);
            
            Merger.Merge(resourceDictionary, ref baseResources);
        }

        public void Load(ResourceDictionary baseResources, Language language)
        {
            ResourceDictionary resourceDictionary = Generator.GenerateResourceDictionary(language);
            Merger.Merge(resourceDictionary, ref baseResources);
        }

        public void LoadActually(ResourceDictionary baseResource)
        {
            m.Languages languages = Provider.ProvideLanguages();
            Language actuallyLanguage = ActuallyLanguageProvider.ProvideActuallyLanguage();
            Language language = Extractor.GetLanguage(languages, actuallyLanguage.Data.LongName);
            ResourceDictionary resourceDictionary = Generator.GenerateResourceDictionary(language);
            Merger.Merge(resourceDictionary, ref baseResource);
        }
    }
}