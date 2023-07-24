namespace SandstoneLauncher.Minecraft.Models
{
    /// <summary>
    ///     full view with used credentials, server response and (if 200) user data. like email
    /// </summary>
    [Spencer.NET.SingleInstance]
public class MojangData
    {
        public MojangData(MojangCredentials credentials, MojangLoginResponse loginResponse, int serverStatusCode,
            string jsonResponse)
        {
            Credentials = credentials;
            LoginResponse = loginResponse;
            ServerStatusCode = serverStatusCode;
            JsonResponse = jsonResponse;
        }

        public MojangCredentials Credentials { get; set; }

        public MojangLoginResponse LoginResponse { get; set; }

        public int ServerStatusCode { get; set; }

        public string JsonResponse { get; set; }
    }
}