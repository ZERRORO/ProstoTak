using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace FonDesktop
{
    internal class Program
    {
        const int SPI_SETDESLWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        static void Main(string[] args)
        {
            SystemParametersInfo(SPI_SETDESLWALLPAPER, 0, @"C:\Users\stud\Pictures\Saved Pictures\fff.jpg", SPIF_UPDATEINIFILE);
        }
    }
}
