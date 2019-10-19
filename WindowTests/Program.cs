using System;
using KacpiiToZiomal.SandstoneLauncher.Windows;

namespace WindowTests
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            LauncherFrame f = new LauncherFrame();
            f.Show();
        }
    }
}