using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class CredentialsDataPathGenerator : ICredentialsDataPathGenerator
    {
        public IApplicationData AppData;

        public CredentialsDataPathGenerator(IApplicationData appData)
        {
            AppData = appData;
        }

        public string GeneratePath()
        {
            return AppData.GetApplicationData() + "credentials.data";
        }
    }
}