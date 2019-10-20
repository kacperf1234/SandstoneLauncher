using System;
using System.Threading;
using System.Threading.Tasks;
using KacpiiToZiomal.SandstoneLauncher.Windows;

namespace WindowTests
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thread th = new Thread((() =>
            {
                LauncherFrame f = new LauncherFrame();
                f.ShowDialog();
            }));
            
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}