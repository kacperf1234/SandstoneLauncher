using KacpiiToZiomal.SandstoneLauncher.Accounts.Models;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Accounts.Interfaces
{
    public interface IAccountGenerator
    {
        Account GenerateAccount(Credentials credentials);
    }
}