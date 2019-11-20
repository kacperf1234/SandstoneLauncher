using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class ActuallyLanguageProvider : IActuallyLanguageProvider
    {
        public IJsonDeserializer<ActuallyLanguage> Deserializer;
        public IFileReader FileReader;
        public IActuallyLanguagePathGenerator PathGenerator;

        public ActuallyLanguageProvider(IJsonDeserializer<ActuallyLanguage> deserializer, IFileReader fileReader, IActuallyLanguagePathGenerator pathGenerator)
        {
            Deserializer = deserializer;
            FileReader = fileReader;
            PathGenerator = pathGenerator;
        }

        public ActuallyLanguage ProvideActuallyLanguage()
        {
            string path = PathGenerator.GeneratePath();
            string content = FileReader.Read(path);
            ActuallyLanguage actually = Deserializer.Deserialize(content);

            return actually;
        }
    }
}