using System.Windows;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;
using m = KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class LanguageLoader : ILanguageLoader
    {
        public IActuallyLanguageProvider ActuallyLanguageProvider;
        public ILanguageExtractor Extractor;
        public IResourceDictionaryGenerator Generator;
        public IResourceDictionaryMerger Merger;
        public ILanguagesProvider Provider;

        public LanguageLoader(ILanguagesProvider provider, ILanguageExtractor extractor,
            IResourceDictionaryGenerator generator, IResourceDictionaryMerger merger,
            IActuallyLanguageProvider actuallyLanguageProvider)
        {
            Provider = provider;
            Extractor = extractor;
            Generator = generator;
            Merger = merger;
            ActuallyLanguageProvider = actuallyLanguageProvider;
        }

        public void Load(ResourceDictionary baseResources, string shortname)
        {
            m.Languages languages = Provider.ProvideLanguages();
            m.Language language = Extractor.GetLanguage(languages, shortname);
            ResourceDictionary resourceDictionary = Generator.GenerateResourceDictionary(language);

            Merger.Merge(resourceDictionary, ref baseResources);
        }

        public void Load(ResourceDictionary baseResources, m.Language language)
        {
            ResourceDictionary resourceDictionary = Generator.GenerateResourceDictionary(language);
            Merger.Merge(resourceDictionary, ref baseResources);
        }

        public static void Load(string shortname, ResourceDictionary baseResources)
        {
            LanguageLoader loader = new LanguageLoader(
                new LanguagesProvider(new FileListGenerator(), new LanguageFilesFilter(new LanguageFileNameValidator()),
                    new JsonDeserializer<m.Language>(), new FileReader(), new ApplicationData()),
                new LanguageExtractor(),
                new ResourceDictionaryGenerator(new ResourceKeyNameGenerator()), new ResourceDictionaryMerger(),
                new ActuallyLanguageProvider(new JsonDeserializer<m.Language>(), new FileReader(),
                    new ActuallyLanguagePathGenerator(new ApplicationData())));

            loader.Load(baseResources, shortname);
        }

        public static void Load(m.Language language, ResourceDictionary baseResources)
        {
            LanguageLoader loader = new LanguageLoader(
                new LanguagesProvider(new FileListGenerator(), new LanguageFilesFilter(new LanguageFileNameValidator()),
                    new JsonDeserializer<m.Language>(), new FileReader(), new ApplicationData()),
                new LanguageExtractor(),
                new ResourceDictionaryGenerator(new ResourceKeyNameGenerator()), new ResourceDictionaryMerger(),
                new ActuallyLanguageProvider(new JsonDeserializer<m.Language>(), new FileReader(),
                    new ActuallyLanguagePathGenerator(new ApplicationData())));

            loader.Load(baseResources, language);
        }

        public void LoadActually(ResourceDictionary baseResource)
        {
            m.Languages languages = Provider.ProvideLanguages();
            m.Language actuallyLanguage = ActuallyLanguageProvider.ProvideActuallyLanguage();
            m.Language language = Extractor.GetLanguage(languages, actuallyLanguage.Data.LongName);
            ResourceDictionary resourceDictionary = Generator.GenerateResourceDictionary(language);
            Merger.Merge(resourceDictionary, ref baseResource);
        }
    }
}