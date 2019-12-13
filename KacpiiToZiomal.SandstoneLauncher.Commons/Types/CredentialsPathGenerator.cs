using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class CredentialsPathGenerator : ICredentialsPathGenerator
    {
        public IApplicationData AppData;
        
        public string GeneratePath()
        {
            return AppData.GetApplicationData() + "credentials.data";
        }
    }
}