using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models
{
    public class SimpleDeveloperCredentials : IDbModel
    {
        public string ClientId { get; set; }

        public string ClientSecret { get; set; }
        
        public object GetValue() => this;
    }
}