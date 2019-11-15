using KacpiiToZiomal.SandstoneLauncher.Accounts.Enums;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Accounts.Models
{
    public class OfflineAccount : Account
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        
        public OfflineAccount() : base(AccountType.OFFLINE)
        {
        }
    }
}