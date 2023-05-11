using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Pizza_Game
{
    internal class Data
    {
        public List<PictureBox> listPicture { get; set; }
        public List<PictureBox> road { get; set; }
        public PictureBox courier { get; set; }
        public bool isCanMove { get; set; }
        public  bool isPlaying { get; set; }
        public  SoundPlayer player { get; set; }

        public Data()
        {
            player = new SoundPlayer(@"C:\Users\piban\Music\BestMusic\yatashigang-demons-around-mp3 (online-audio-converter.com).wav");
            isPlaying = true;
            listPicture = new List<PictureBox>();
            road = new List<PictureBox>();
            courier = null;
            isCanMove = false;
        }
    }
}
