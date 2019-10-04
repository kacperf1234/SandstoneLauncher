using System;
using System.Linq;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class NativesPropertyGetter : INativesPropertyGetter
    {
        public string GetValue(Natives n, string name)
        {
            Type t = n.GetType();
            PropertyInfo[] props = t.GetProperties();
            PropertyInfo p = props.Where(x => x.Name.ToLower() == name.ToLower()).First();

            return (string) p.GetValue(n);
        }
    }
}