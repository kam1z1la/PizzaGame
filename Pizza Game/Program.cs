using System;
using System.Media;
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
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream =  assembly.GetManifestResourceStream(@"Pizza_Game.Turbo Tunnel Race.wav");
            Data.player = new SoundPlayer(resourceStream);
            Data.player.Play();
            Application.Run(new Menu());
        }
    }
}