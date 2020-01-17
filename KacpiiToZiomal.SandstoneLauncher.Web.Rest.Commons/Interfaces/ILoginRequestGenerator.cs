using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces
{
    public interface ILoginRequestGenerator
    {
        LoginRequest Generate(Developer developer, DeveloperToken developerToken, string returnUrl, string cancelUrl);
    }
}