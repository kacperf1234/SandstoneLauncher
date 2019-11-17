using KacpiiToZiomal.SandstoneLauncher.Accounts.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Accounts.Interfaces
{
    public interface IAccountCreator
    {
        OnlineAccount CreateOnlineAccount();

        OfflineAccount CreateOfflineAccount();
    }
}