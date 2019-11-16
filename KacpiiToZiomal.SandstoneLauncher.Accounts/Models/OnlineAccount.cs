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
        
        [JsonProperty("save_password")]
        public bool SavePassword { get; set; }
        
        public OnlineAccount() : base(AccountType.ONLINE)
        {
        }
    }
}