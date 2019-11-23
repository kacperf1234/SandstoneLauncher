using System;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class SidePageBuilder : ISidePageBuilder
    {
        public ISidePageGridProvider GridProvider;

        public int Order { get; set; }

        public SidePage BuildSidePage()
        {
            return null;
        }
    }
}