using System;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace Pizza_Game
{
    public partial class TotalSource : Form
    {
        private Form formLvl;
        public TotalSource()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (DataUI.EXTRA_LIFE == 1)
            {
                Question question = new Question(formLvl);
                question.Show(); this.Hide();
            }
            else
            {
              Menu menu = new Menu();
              menu.Show(); this.Hide();
            }          
        }

        public void getInfo(bool isWin, string life, string time, string point)
        {                            
            this.Life.Text = life;
            Time.Text = getElapsedTime(time);
            this.Point.Text = point;
            if (isWin == true)
            {
              Head.Text = "Вітаємо, ви перемогли!";
            } else
            { 
              Head.Text = "На жаль, ви програли";
              NextBtn.Visible = false;
                BackBtn.Left = 224;
                BackBtn.Top = 243;
            }
        }

        private String getElapsedTime(string time)
        {
            string[] timeArray = time.Split(':');
            int minute = int.Parse(timeArray[0]);
            int second = int.Parse(timeArray[1]);
            int totalSeconds = 120 - ((minute * 60) + second);
            minute = totalSeconds / 60;
            second = totalSeconds - (minute * 60);
            return (second < 10) ? string.Format("0{0}:0{1}", minute, second) : string.Format("0{0}:{1}", minute, second);
        }

        public void getForm(Form form)
        {
            formLvl = form;
        }   
    }
}