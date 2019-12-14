using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Models
{
    public class Credentials
    {
        [JsonProperty("username")]
        [Required(ErrorMessage = "Username field cannot be empty.")]
        [RegularExpression("(\\w+\\@\\w+\\.\\w+|\\w+)", ErrorMessage = "Username not passing to regular expression.")]
        public string Username { get; set; }
        
        [JsonProperty("password")]
        [Required(ErrorMessage = "Password field cannot be empty.")]
        public string Password { get; set; }
        
        [JsonProperty("is_online")]
        public bool IsOnline { get; set; }
    }
}