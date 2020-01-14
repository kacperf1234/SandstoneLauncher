﻿using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces
{
    public interface IDeveloperFinder
    {
        Developer Find(DeveloperCredentials credentials);

        Developer Find(string credentialsId);
    }
}