namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models
{
    public class MojangCredentials
    {
        public MojangCredentials()
        {
        }

        public MojangCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        ///     can be username or email
        /// </summary>
        public string Username { get; set; }

        public string Password { get; set; }
    }
}