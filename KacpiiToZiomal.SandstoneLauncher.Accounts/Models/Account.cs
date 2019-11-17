using KacpiiToZiomal.SandstoneLauncher.Accounts.Enums;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Accounts.Models
{
    public class Account
    {
        [JsonProperty("account_type")] 
        public AccountType Type { get; set; }

        public Account(AccountType type)
        {
            Type = type;
        }
    }
}