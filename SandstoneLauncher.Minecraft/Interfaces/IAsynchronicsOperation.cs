using System;
using System.Collections.Generic;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAsynchronicsOperation
    {
        List<Action> Actions { get; set; }

        void InvokeActions();
    }
}