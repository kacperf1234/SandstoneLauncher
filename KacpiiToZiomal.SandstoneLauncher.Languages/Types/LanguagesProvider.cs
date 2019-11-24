using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class LanguagesProvider : ILanguagesProvider
    {
        public IApplicationData AppData;
        public IFileListGenerator FileListGenerator;
        public IFileReader FileReader;
        public IJsonDeserializer<Language> LanguageDeserializer;
        public ILanguageFilesFilter LanguageFilesFilter;

        public LanguagesProvider(IFileListGenerator fileListGenerator, ILanguageFilesFilter languageFilesFilter,
            IJsonDeserializer<Language> languageDeserializer, IFileReader fileReader, IApplicationData appData)
        {
            FileListGenerator = fileListGenerator;
            LanguageFilesFilter = languageFilesFilter;
            LanguageDeserializer = languageDeserializer;
            FileReader = fileReader;
            AppData = appData;
        }

        public Models.Languages ProvideLanguages()
        {
            string directorypath = AppData.GetApplicationData();
            string[] files = FileListGenerator.GetFiles(directorypath, "*.json");
            string[] filteredFiles = LanguageFilesFilter.Filter(files).ToArray();
            Models.Languages languages = Models.Languages.Empty();

            foreach (string file in filteredFiles)
            {
                string filecontent = FileReader.Read(file);
                Language language = LanguageDeserializer.Deserialize(filecontent);

                languages.Add(language);
            }

            return languages;
        }
    }
}