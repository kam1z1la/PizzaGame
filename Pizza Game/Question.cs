using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Game
{
    public partial class Question : Form
    {
        private static Form form;
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
            new Picture().scatterPicturesInTheForm(form);
            form.Show(); this.Hide();
        }
    }
}
