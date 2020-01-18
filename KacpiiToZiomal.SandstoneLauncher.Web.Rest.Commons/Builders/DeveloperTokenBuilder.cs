using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Builders
{
    public class DeveloperTokenBuilder : Builder<DeveloperTokenBuilder, DeveloperToken>
    {
        public DeveloperTokenBuilder()
        {
        }

        public DeveloperTokenBuilder(DeveloperToken workedInstance) : base(workedInstance)
        {
        }

        public DeveloperTokenBuilder WithId() => Update(x => x.Id = Guid.NewGuid().ToString());
        
        public DeveloperTokenBuilder WithId(string id) => Update(x => x.Id = id);
        
        public DeveloperTokenBuilder WithDeveloperId() => Update(x => x.DeveloperId = Guid.NewGuid().ToString());
        
        public DeveloperTokenBuilder SetGeneratedAt() => Update(x => x.GeneratedAt = DateTime.Now);
        
        public DeveloperTokenBuilder SetGeneratedAt(DateTime dt) => Update(x => x.GeneratedAt = dt);
        
        public DeveloperTokenBuilder SetExpiredAt() => Update(x => x.ExpiredAt = DateTime.Now);
        
        public DeveloperTokenBuilder SetExpiredAt(DateTime dt) => Update(x => x.ExpiredAt = dt);
        
        public DeveloperTokenBuilder SetArchived(bool archived = true) => Update(x => x.Archived = archived);
        
        public DeveloperTokenBuilder SetAuthorized(bool authorized = true) => Update(x => x.Authorized = authorized);
        
        public DeveloperTokenBuilder SetAuthorizedAt() => Update(x => x.AuthorizedAt = DateTime.Now);
        
        public DeveloperTokenBuilder SetAuthorizedAt(DateTime dt) => Update(x => x.AuthorizedAt = dt);
        
        public DeveloperTokenBuilder SetUnauthorizedAt() => Update(x => x.UnauthorizedAt = DateTime.Now);
        
        public DeveloperTokenBuilder SetUnauthorizedAt(DateTime dt) => Update(x => x.UnauthorizedAt = dt);
        
        public DeveloperTokenBuilder SetUnauthorized(bool unauthorized = true) => Update(x => x.Unauthorized = unauthorized);

        public DeveloperTokenBuilder WithUpdatedTimes(int times) => Update(x => x.UpdatedTimes = times);
        
        public DeveloperTokenBuilder AddUpdatedTimes() => Update(x => x.UpdatedTimes++);
        
        public DeveloperTokenBuilder MinusUpdatedTimes() => Update(x => x.UpdatedTimes--);
        
        public DeveloperTokenBuilder SetLastUpdatedAt(DateTime dt) => Update(x => x.LastUpdatedAt = dt);
        
        public DeveloperTokenBuilder SetLastUpdatedAt() => Update(x => x.LastUpdatedAt = DateTime.Now);
    }
}