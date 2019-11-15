using KacpiiToZiomal.SandstoneLauncher.Accounts.Enums;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Accounts.Models
{
    public class OnlineAccount : Account
    {    
        [JsonProperty("email")]
        public string Email { get; set; }
        
        [JsonProperty("password")]
        public string Password { get; set; }
        
        [JsonProperty("password_store_type")]
        public AccountStoreType PasswordStoreType { get; set; }
        
        public OnlineAccount() : base(AccountType.ONLINE)
        {
        }
    }
}