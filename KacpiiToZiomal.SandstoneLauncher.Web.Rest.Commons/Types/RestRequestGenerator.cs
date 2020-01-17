using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Builders;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class RestRequestGenerator : IRestRequestGenerator
    {
        public RestRequest Generate(DeveloperCredentials developerCredentials, DeveloperToken developerToken, string returnUrl, string cancelUrl)
        {
            RestRequestBuilder builder = new RestRequestBuilder();
            RestRequest request = builder
                .InitializeBuilder()
                .WithCancelUrl(cancelUrl)
                .WithReturnUrl(returnUrl)
                .WithDeveloperId(developerCredentials.DeveloperId)
                .WithTokenId(developerToken.Id)
                .SetGeneratedAt()
                .WithId()
                .Build();

            return request;
        }
    }
}