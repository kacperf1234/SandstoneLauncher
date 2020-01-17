using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces
{
    public interface IRestRequestGenerator
    {
        RestRequest Generate(DeveloperCredentials developerCredentials, DeveloperToken developerToken, string returnUrl,
            string cancelUrl);
    }
}