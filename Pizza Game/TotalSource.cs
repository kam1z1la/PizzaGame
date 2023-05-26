using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Pizza_Game
{
    public partial class TotalSource : Form
    {
        private Form formLvl;
        private Form nextFormLvl;
        private Picture picture = new Picture();

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
            Life.Text = life;
            Time.Text = getElapsedTime(time);
            Point.Text = point;
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

        public void getNextForm(Form form)
        {
            Console.WriteLine("[INFO] umber of images in listPicture: {0}.", Data.listPicture.Count);
            nextFormLvl = form;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            picture.scatterPicturesInTheForm(nextFormLvl);
            nextFormLvl.Show(); this.Hide();
        }

        private void TotalSource_Load(object sender, EventArgs e)
        {
            Head.Font = DataUI.GetCustomFont(27);
            label1.Font = DataUI.GetCustomFont(27);
            label2.Font = DataUI.GetCustomFont(27);
            CountTime.Font = DataUI.GetCustomFont(27);
            Life.Font = DataUI.GetCustomFont(20);
            Point.Font = DataUI.GetCustomFont(20);
            Time.Font = DataUI.GetCustomFont(20);
        }
    }
}