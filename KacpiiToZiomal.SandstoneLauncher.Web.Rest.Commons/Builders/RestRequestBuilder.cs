using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Builders
{
    public class RestRequestBuilder : Builder<RestRequestBuilder, RestRequest>
    {
        public RestRequestBuilder()
        {
        }

        public RestRequestBuilder(RestRequest instance) : base(instance)
        {
        }

        public RestRequestBuilder WithId(string id)
            => Update(d => d.Id = id);

        public RestRequestBuilder WithId()
            => Update(d => d.Id = Guid.NewGuid().ToString());

        public RestRequestBuilder WithTokenId(string tokenId)
            => Update(d => d.TokenId = tokenId);
        
        public RestRequestBuilder WithReturnUrl(string returnUrl)
            => Update(d => d.ReturnUrl = returnUrl);

        public RestRequestBuilder WithCancelUrl(string cancelUrl)
            => Update(d => d.CancelUrl = cancelUrl);

        public RestRequestBuilder WithDeveloperId(string developerId)
            => Update(d => d.DeveloperId = developerId);

        public RestRequestBuilder SetInvoked(bool invoked)
            => Update(d => d.Invoked = invoked);
        
        public RestRequestBuilder SetGeneratedAt() 
            => Update(d => d.GeneratedAt = DateTime.Now);

        public RestRequestBuilder SetGeneratedAt(DateTime? generatedAt) 
            => Update(d => d.GeneratedAt = generatedAt);
    }
}