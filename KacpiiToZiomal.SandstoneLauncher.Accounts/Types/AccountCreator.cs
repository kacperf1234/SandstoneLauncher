using System;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Accounts.Types
{
    public class AccountCreator : IAccountCreator
    {
        public OnlineAccount CreateOnlineAccount()
        {
            throw new NotImplementedException();
        }

        public OfflineAccount CreateOfflineAccount()
        {
            throw new System.NotImplementedException();
        }
    }
}