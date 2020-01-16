using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDeveloperTokenGenerator
    {
        DeveloperToken GenerateToken(Developer developer);
    }
}