using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class FullVersionFinder : IFullVersionFinder
    {
        public IHttpClient Client;
        public IJsonParser<FullVersion> Parser;

        public FullVersionFinder(IHttpClient client, IJsonParser<FullVersion> parser)
        {
            Client = client;
            Parser = parser;
        }

        public FullVersion Find(GameVersion version)
        {
            string json = Client.GetContent(version.Url);
            return Parser.Parse(json);
        }
    }
}