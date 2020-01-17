using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class ModelValidator : IDbModelValidator
    {
        public bool Validate(IDbModel dbModel) => dbModel.GetValue() != null;
    }
}