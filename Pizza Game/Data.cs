using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Pizza_Game
{
    public class Data
    {
        public static List<PictureBox> listPicture { get; set; }
        public static List<PictureBox> road { get; set; }
        public static PictureBox courier { get; set; }
        public static bool isCanMove { get; set; }
        public static bool isPlaying { get; set; }
        public static SoundPlayer player { get; set; }

        public Data()
        {            
            isPlaying = true;
            listPicture = new List<PictureBox>();
            road = new List<PictureBox>();
            courier = null;
            isCanMove = false;
        }
    }
}