using System;
using System.Media;
using System.Windows.Forms;

namespace Pizza_Game
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();          
        }

        private void InfoBtn_Click_1(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show(); this.Hide();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            Puxxle_Level1 lvl_1 = new Puxxle_Level1(new DataUI());
            new Picture().scatterPicturesInTheForm(lvl_1);
            lvl_1.Show(); this.Hide();
        }

        private void BeastMusic_Click(object sender, EventArgs e)
        {
            if (!Data.isPlaying)
            {
                Data.player.Play();
                Data.isPlaying = true;
            }
            else
            {
                Data.player.Stop();
                Data.isPlaying = false;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Data data = new Data();       
        }
    }
}