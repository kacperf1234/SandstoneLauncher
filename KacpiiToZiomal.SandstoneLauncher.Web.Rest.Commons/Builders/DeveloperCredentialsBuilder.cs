using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Builders
{
    public class DeveloperCredentialsBuilder : Builder<DeveloperCredentialsBuilder, DeveloperCredentials>
    {
        public DeveloperCredentialsBuilder() : base()
        {
        }

        public DeveloperCredentialsBuilder(DeveloperCredentials workedInstance) : base(workedInstance)
        {
        }

        public DeveloperCredentialsBuilder WithId(string id) => Update(d => d.Id = id);
        
        public DeveloperCredentialsBuilder WithId() => Update(d => d.Id = Guid.NewGuid().ToString());
        
        public DeveloperCredentialsBuilder WithDeveloperId(string developerId) => Update(d => d.DeveloperId = developerId);

        public DeveloperCredentialsBuilder WithClientId(string clientId) => Update(d => d.ClientId = clientId);

        public DeveloperCredentialsBuilder WithClientSecret(string clientSecret) => Update(d => d.ClientSecret = clientSecret);
    }
}