using System;
using System.Windows.Forms;

namespace Pizza_Game
{
    public partial class Question : Form
    {
        private static Form form;
        private Picture picture = new Picture();

        public Question(Form lvl)
        {
            InitializeComponent();
            form = lvl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataUI.EXTRA_LIFE = 0;
            picture.scatterPicturesInTheForm(form);
            form.Show(); this.Hide();
        }

        private void Question_Load(object sender, EventArgs e)
        {

        }
    }
}