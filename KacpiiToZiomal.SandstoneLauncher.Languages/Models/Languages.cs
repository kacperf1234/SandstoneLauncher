using System.Collections.Generic;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Models
{
    public class Languages : List<Language>
    {
        public static Languages Empty() => new Languages(); 
    }
}