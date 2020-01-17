using System;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class StringComparer : IStringComparer
    {
        public bool Compare(string x1, string x2, bool ignoreCase = false) 
            => string.Equals(x1, x2, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
    }
}