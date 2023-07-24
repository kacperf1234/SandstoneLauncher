using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class CredentialsJsonBuilder : IJsonBuilder<MojangCredentials>
    {
        private readonly string Pattern =
            @"{ 'agent': { 'name': 'Minecraft', 'version': 1 }, 'username': '!username', 'password': '!pwd', 'clientToken': '!username', 'requestUser': true }";

        public string Build(MojangCredentials arg)
        {
            return Pattern.Replace("!username", arg.Username).Replace("!pwd", arg.Password).Replace("'", "\"");
        }
    }
}