using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class LanguagesProvider : ILanguagesProvider
    {
        public ILanguageDirectoryPathGenerator LanguageDirectoryPathGenerator;
        public IFileListGenerator FileListGenerator;
        public ILanguageFilesFilter LanguageFilesFilter;
        public IJsonDeserializer<Language> LanguageDeserializer;
        public IFileReader FileReader;

        public LanguagesProvider(ILanguageDirectoryPathGenerator languageDirectoryPathGenerator, IFileListGenerator fileListGenerator, ILanguageFilesFilter languageFilesFilter, IJsonDeserializer<Language> languageDeserializer, IFileReader fileReader)
        {
            LanguageDirectoryPathGenerator = languageDirectoryPathGenerator;
            FileListGenerator = fileListGenerator;
            LanguageFilesFilter = languageFilesFilter;
            LanguageDeserializer = languageDeserializer;
            FileReader = fileReader;
        }

        public Models.Languages ProvideLanguages()
        {
            string directorypath = LanguageDirectoryPathGenerator.GetPath();
            string[] files = FileListGenerator.GetFiles(directorypath);
            string[] filteredFiles = LanguageFilesFilter.Filter(files).ToArray();
            Models.Languages languages = Models.Languages.Empty();

            foreach (string file in filteredFiles)
            {
                string filecontent = FileReader?.Read(file);
                Language language = LanguageDeserializer.Deserialize(filecontent);
                
                languages.Add(language);
            }

            return languages;
        }
    }
}