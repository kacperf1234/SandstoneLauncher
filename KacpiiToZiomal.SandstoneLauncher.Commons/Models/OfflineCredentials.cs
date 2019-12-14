using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Models
{
    public class OfflineCredentials
    {
        [JsonProperty("username")]
        [Required(ErrorMessage = "Username field cannot be empty.")]
        [RegularExpression("(\\w+\\@\\w+\\.\\w+|\\w+)", ErrorMessage = "Username not passing to regular expression.")]
        public string Username { get; set; }
    }
}