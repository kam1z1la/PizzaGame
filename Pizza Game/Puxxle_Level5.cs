using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Pizza_Game
{
    public partial class Puxxle_Level5 : Form, Direction
    {

        private Picture shuffle = new Picture();
        private Path win = new Path();
        private PictureBox courier;
        private DataUI dataUI;
        private int indexDirection = 0;
        private int indexDirectionTag = 0; 

        public Puxxle_Level5(DataUI ui)
        {
            InitializeComponent();
            dataUI = ui;
        }

        private async void Puxxle_Level5_Load(object sender, EventArgs e)
        {
            await win.createRoadAsync(Data.road, pictureBox16, pictureBox9, pictureBox9, pictureBox8, pictureBox5,
            pictureBox4, pictureBox3, pictureBox2, pictureBox11, pictureBox12);
            Console.WriteLine("[INFO] Number of images in road asunc list: {0}.", Data.road.Count);
            courier = Data.courier;
            courier = pictureBox26;
            courier.Tag = 9;
            timer2.Enabled = true;
        }

        public void setDirection(int index, PictureBox courier)
        {          
            switch (index)
            {
                case 0:
                    if (!courier.Tag.Equals(6))
                    {
                        courier.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        courier.Size = new Size(54, 28);
                        courier.Tag = 6;
                    }
                    break;
                case 1:
                    if (!courier.Tag.Equals(9))
                    {
                        if (indexDirection < 3)
                        {
                            courier.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        }
                        else
                        {
                            courier.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        }
                        courier.Size = new Size(54, 28);
                        courier.Tag = 9;
                    }
                    break;
                case 2:
                    if (!courier.Tag.Equals(8))
                    {
                        if (indexDirection == 0)
                        {
                            courier.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        }
                        else
                        {
                            courier.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        }
                        courier.Size = new Size(40, 28);
                        courier.Tag = 8;
                        indexDirection++;
                    }
                    break;
                case 3:
                    if (!courier.Tag.Equals(7))
                    {
                        if (indexDirection == 0)
                        {
                            courier.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        }
                        else
                        {
                            courier.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        }                       
                        courier.Size = new Size(40, 28);
                        courier.Tag = 7;
                        indexDirection++;
                    }
                    break;
            }
            Console.WriteLine("Tag switch to {0}", courier.Tag);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int index = Convert.ToInt32(pictureBox.Tag);

            if (pictureBox != null)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox.Invalidate();
                shuffle.switchTag(pictureBox, index, pictureBox9, pictureBox5,pictureBox8,pictureBox11);
                switchTagForСrossroadsparams(pictureBox, index, pictureBox16, pictureBox2);
            }

            Data.isCanMove = win.isThePathCorrect(Data.road);
            if (Data.isCanMove == true)
            {
                timer1.Enabled = true;
            };
        }

        private void switchTagForСrossroadsparams(PictureBox picture, int index, params object[] curvedRoad)
        {
            if (curvedRoad.Contains(picture))
            {
                switch (index)
                {
                    case 1:
                        if (indexDirectionTag == 1)
                        {
                            picture.Tag = 2;
                            indexDirectionTag = 0;                          
                        } else
                        {
                            picture.Tag = 1;
                            indexDirectionTag++;
                        }
                        break;
                    case 2:
                        picture.Tag = 3; break;
                    case 3:
                        picture.Tag = 1; break;
                };
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int cx = courier.Location.X;
            int cy = courier.Location.Y;

            foreach (var picture in Data.road)
            {
                int direction = 0;
                int centerX = (picture.Location.X + (picture.Width / 2) - 30);
                int dis = picture.Location.Y + (picture.Height / 2) - courier.Location.Y;

                int centerY = (picture.Location.Y + (picture.Height / 2)) - 23;
                Console.WriteLine("picture cwnter x;y:\n {0};{1}", centerX, centerY);
                Rectangle courierBounds1 = new Rectangle(courier.Location, courier.Size);

                while (Math.Abs(courier.Location.X - centerX) > 9
                || Math.Abs(courier.Location.Y - centerY) > 17)
                {
                    if (dis < 100 && dis > -30)
                    {
                        if (courier.Location.X < centerX)
                        {
                            cx += 15;
                            direction = 0;
                        }
                        else
                        {
                            cx -= 15;
                            direction = 1;
                        }
                    }
                    else
                    {
                        if (courier.Location.Y < centerY)
                        {
                            cy += 20;
                            direction = 2;
                        }
                        else
                        {
                            cy -= 20;
                            direction = 3;
                        }
                    }

                    courier.Location = new Point(cx, cy);
                    this.Refresh();

                    setDirection(direction, courier);

                    Console.WriteLine("courier x;y:\n {0};{1}", cx, cy);
                    System.Threading.Thread.Sleep(200);
                }
                this.Refresh();
            }
            Data.isCanMove = false;           
            endGameInRhisLvl(new Puxxle_Level5(dataUI), true);
            this.Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dataUI.setParse(ExtraLife, Time, Points);

            if (dataUI.totalSeconds > 0)
            {
                dataUI.totalSeconds--;
                dataUI.minute = dataUI.totalSeconds / 60;
                dataUI.second = dataUI.totalSeconds - (dataUI.minute * 60);
                Time.Text = (dataUI.second < 10) ? string.Format("0{0}:0{1}", dataUI.minute, dataUI.second) : string.Format("0{0}:{1}", dataUI.minute, dataUI.second);
                dataUI.points -= 10;
                Points.Text = dataUI.points.ToString();
            }
            else
            {              
                endGameInRhisLvl(new Puxxle_Level5(dataUI), false);
                this.Refresh();
            }
        }

        private void endGameInRhisLvl(Form form, bool isWin)
        {
            TotalSource totalSource = new TotalSource();
            dataUI.isWin = isWin;
            timer1.Enabled = false;
            timer2.Enabled = false;
            totalSource.getForm(form);
            totalSource.getNextForm(new Menu());
            totalSource.getInfo(dataUI.isWin, ExtraLife.Text, Time.Text, Points.Text);
            shuffle.freeingMemoryFromPictures(Data.road);
            Console.WriteLine("[INFO] Number of images in road list when program end: {0}.", Data.road.Count);
            shuffle.freeingMemoryFromPictures(Data.listPicture);
            Console.WriteLine("[INFO] Number of images in picture list when program end: {0}.", Data.listPicture.Count);
            totalSource.Show(); this.Hide();
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
    }
}