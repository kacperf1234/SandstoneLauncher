using System.Net.Http;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class MojangAuthentication : IMojangAuthentication
    {
        public readonly string Endpoint = "https://authserver.mojang.com/authenticate";
        public IHttpClient Client;
        public IDataProcessing<MojangData> DataProcessing;
        public IJsonDeserializer<MojangLoginResponse> Deserializer;
        public IJsonBuilder<MojangCredentials> JsonBuilder;
        public IResponseValidator ResponseValidator;

        public MojangAuthentication(IHttpClient client, IJsonDeserializer<MojangLoginResponse> deserializer,
            IJsonBuilder<MojangCredentials> jsonBuilder, IResponseValidator responseValidator,
            IDataProcessing<MojangData> dataProcessing)
        {
            Client = client;
            Deserializer = deserializer;
            JsonBuilder = jsonBuilder;
            ResponseValidator = responseValidator;
            DataProcessing = dataProcessing;
        }

        public bool Authenticate(MojangCredentials credentials, out MojangLoginResponse response)
        {
            string body = JsonBuilder.Build(credentials);
            HttpResponseMessage responsemsg = Client.GetResponse(Endpoint, HttpMethod.Post, body);
            response = new MojangLoginResponse();
            string content = responsemsg.Content.ReadAsStringAsync().Result;

            DataProcessing.SendData(new MojangData(credentials, response, (int)responsemsg.StatusCode, content));

            if (ResponseValidator.Validate(responsemsg))
            {
                response = Deserializer.Deserialize(content);

                return true;
            }

            return false;
        }
    }
}