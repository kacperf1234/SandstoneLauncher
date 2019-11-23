using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class LanguageService : ILanguageService
    {
        public IJsonDeserializer<Language> Deserializer;
        public IJsonSerializer<Language> Serializer;
        public IFileReader Reader;
        public IFileCreator Creator;
        public IActuallyLanguagePathGenerator PathGenerator;

        private static LanguageService _service;

        public LanguageService(IJsonDeserializer<Language> deserializer, IJsonSerializer<Language> serializer, IFileReader reader, IFileCreator creator, IActuallyLanguagePathGenerator pathGenerator)
        {
            Deserializer = deserializer;
            Serializer = serializer;
            Reader = reader;
            Creator = creator;
            PathGenerator = pathGenerator;
        }

        public static LanguageService GetLanguageService()
        {
            return _service ??= new LanguageService(new JsonDeserializer<Language>(),
                new JsonSerializer<Language>(), new FileReader(), new FileCreator(new FileNameRemover()),
                new ActuallyLanguagePathGenerator(new ApplicationData()));
        }

        public void SetLanguage(Language language)
        {
            string content = Serializer.Serialize(language);
            string path = PathGenerator.GeneratePath();
            Creator.Create(path, content);
        }

        public Language GetLangugage()
        {
            string path = PathGenerator.GeneratePath();
            string content = Reader.Read(path);

            return Deserializer.Deserialize(content);
        }
    }
}