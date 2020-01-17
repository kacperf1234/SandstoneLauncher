using System;
using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class ModelValidator : IDbModelValidator
    {
        public bool Validate(IDbModel dbModel) => dbModel.GetValue() != null;
    }
}