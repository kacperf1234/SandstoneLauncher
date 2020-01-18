using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Builders
{
    public class DeveloperBuilder : Builder<DeveloperBuilder, Developer>
    {
        public DeveloperBuilder() : base()
        {
        }

        public DeveloperBuilder(Developer workedInstance) : base(workedInstance)
        {
        }

        public DeveloperBuilder WithId() => Update(d => d.Id = Guid.NewGuid().ToString());

        public DeveloperBuilder WithId(string id) => Update(d => d.Id = id);

        public DeveloperBuilder WithCredentialsId(string id) => Update(d => d.CredentialsId = id);
    }
}