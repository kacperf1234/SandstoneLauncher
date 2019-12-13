using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class CredentialsDataProvider : ICredentialsDataProvider
    {
        public ICredentialsDataPathGenerator PathGenerator;
        public IFileReader FileReader;
        public IJsonDeserializer<CredentialsData> Deserializer;

        public CredentialsDataProvider(ICredentialsDataPathGenerator pathGenerator, IFileReader fileReader, IJsonDeserializer<CredentialsData> deserializer)
        {
            PathGenerator = pathGenerator;
            FileReader = fileReader;
            Deserializer = deserializer;
        }

        public CredentialsData ProvideCredentialsData()
        {
            string path = PathGenerator.GeneratePath();
            string content = FileReader.Read(path);
            CredentialsData @data = Deserializer.Deserialize(content);

            return @data;
        }
    }
}