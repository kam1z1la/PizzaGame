using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Game
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Data.player = new SoundPlayer(@"C:\Users\piban\source\repos\Pizza Game\Pizza Game\Turbo Tunnel Race.wav");
            Data.player.Play();
            Application.Run(new Menu());
        }
    }
}
