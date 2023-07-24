using System;
using System.Text.RegularExpressions;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class TimeConverter : ITimeConverter
    {
        public readonly string Pattern =
            @"(?'year'\w+)\-(?'month'\w+)\-(?'day'\w+)T(?'hour'\w+)\:(?'minute'\w+):(?'second'\w+)";

        public DateTime Convert(string obj)
        {
            Regex r = new Regex(Pattern);
            Match m = r.Match(obj);

            if (m.Success)
            {
                GroupCollection g = m.Groups;

                int years = System.Convert.ToInt32(g["year"].Value);
                int months = System.Convert.ToInt32(g["month"].Value);
                int days = System.Convert.ToInt32(g["day"].Value);
                int hours = System.Convert.ToInt32(g["hour"].Value);
                int minute = System.Convert.ToInt32(g["minute"].Value);
                int seconds = System.Convert.ToInt32(g["second"].Value);

                return new DateTime(years, months, days, hours, minute, seconds);
            }

            throw new ArgumentException($"input \"{obj}\" not passing to pattern \"{Pattern}\"");
        }

        public string Convert(DateTime obj)
        {
            throw new NotImplementedException();
        }
    }
}