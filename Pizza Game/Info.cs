using System;
using System.Windows.Forms;

namespace Pizza_Game
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Menu info = new Menu();
            info.Show(); this.Hide();
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }
    }
}
