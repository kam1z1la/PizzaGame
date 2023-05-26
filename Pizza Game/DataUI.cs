using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Pizza_Game
{
    public class DataUI
    {
        public static int EXTRA_LIFE { get; set; }
        public int points { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public int totalSeconds { get; set; }
        public bool isWin { get; set; }

        public DataUI()
        {
            EXTRA_LIFE = 1;
        }

        public void setParse(Label life, Label time, Label point)
        {
            life.Text = EXTRA_LIFE.ToString();
            points = int.Parse(point.Text);
            string[] timeArray = time.Text.Split(':');
            minute = int.Parse(timeArray[0]);
            second = int.Parse(timeArray[1]);
            totalSeconds = (minute * 60) + second;
        }

        public static Font GetCustomFont(float fontSize)
        {
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("skogenspelfont.ttf"); 
            FontFamily family = fontCollection.Families[0];
            return new Font(family, fontSize);
        }
    }
}