using System;
using System.Media;
using System.Windows.Forms;

namespace Pizza_Game
{
    public partial class Menu : Form
    {
        private static Picture shuffle = new Picture();
        public static DataUI UI = new DataUI();
        Data data = new Data();



        public Menu()
        {
            InitializeComponent();
            data.player.Play();
        }

        private void InfoBtn_Click_1(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show(); this.Hide();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            Puxxle_Level1 lvl_1 = new Puxxle_Level1(UI);
            shuffle.scatterPicturesInTheForm(lvl_1);
            lvl_1.Show(); this.Hide();
        }

        private void BeastMusic_Click(object sender, EventArgs e)
        {
            if (!data.isPlaying)
            {
                data.player.Play();
                data.isPlaying = true;
            }
            else
            {
                data.player.Stop();
                data.isPlaying = false;
            }
        }
    }
}