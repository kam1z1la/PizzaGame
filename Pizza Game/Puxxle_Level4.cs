using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pizza_Game
{
    public partial class Puxxle_Level4 : Form, Direction
    {
        private Picture shuffle = new Picture();
        private PictureBox courier;
        private DataUI dataUI;
        private int indexD = 0;

        public Puxxle_Level4(DataUI ui)
        {
            InitializeComponent();
            dataUI = ui;
        }

        private async void Puxxle_Level4_Load(object sender, EventArgs e)
        {
            await Path.createRoadAsync(Data.road, pictureBox2, pictureBox3, pictureBox9, pictureBox8, pictureBox14, pictureBox15, pictureBox16);
            Console.WriteLine("[INFO] Number of images in road asunc list: {0}.", Data.road.Count);
            courier = Data.courier;
            courier = pictureBox26;
            courier.Tag = 6;
            timer2.Enabled = true;
        }

        public void setDirection(int index, PictureBox courier)
        {
            switch (index)
            {
                case 0:
                    if (!courier.Tag.Equals(6))
                    {
                        courier.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        courier.Size = new Size(54, 28);
                        courier.Tag = 6;
                    }
                    break;
                case 1:
                    if (!courier.Tag.Equals(9))
                    {
                        courier.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        courier.Size = new Size(54, 28);
                        courier.Tag = 9;
                    }
                    break;
                case 2:
                    if (!courier.Tag.Equals(8))
                    {
                        if (indexD == 0)
                        {
                            courier.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        }
                        else
                        {
                            courier.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        }
                        courier.Size = new Size(54, 28);
                        courier.Tag = 8;
                        indexD++;
                    }
                    break;
            }
            Console.WriteLine("Tag switch to {0}", courier.Tag);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dataUI.setParse(ExtraLife, Time, Points);

            if (dataUI.totalSeconds > 0)
            {
                dataUI.totalSeconds--;
                dataUI.minute = dataUI.totalSeconds / 60;
                dataUI.second = dataUI.totalSeconds - (dataUI.minute * 60);
                Time.Text = (dataUI.second < 10) ? string.Format("0{0}:0{1}", dataUI.minute, 
                    dataUI.second) : string.Format("0{0}:{1}", dataUI.minute, dataUI.second);
                dataUI.points -= 10;
                Points.Text = dataUI.points.ToString();
            }
            else
            {              
                endGameInRhisLvl(new Puxxle_Level4(dataUI), false);
                this.Refresh();
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
                int centerY = (picture.Location.Y + (picture.Height / 2)) - 17;

                Console.WriteLine("picture cwnter x;y:\n {0};{1}", centerX, centerY);
                Rectangle courierBounds1 = new Rectangle(courier.Location, courier.Size);


                while (Math.Abs(courier.Location.X - centerX) > 9
                || Math.Abs(courier.Location.Y - centerY) > 19)
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
            endGameInRhisLvl(new Puxxle_Level4(dataUI), true);
            this.Refresh();
        }

        private void endGameInRhisLvl(Form form, bool isWin)
        {
            TotalSource totalSource = new TotalSource();
            dataUI.isWin = isWin;
            timer1.Enabled = false;
            timer2.Enabled = false;
            totalSource.getForm(form);
            totalSource.getNextForm(new Puxxle_Level5(dataUI));
            totalSource.getInfo(dataUI.isWin, ExtraLife.Text, Time.Text, Points.Text);
            shuffle.freeingMemoryFromPictures(Data.road);
            Console.WriteLine("[INFO] Number of images in road list when program end: {0}.", Data.road.Count);
            shuffle.freeingMemoryFromPictures(Data.listPicture);
            Console.WriteLine("[INFO] Number of images in picture list when program end: {0}.", Data.listPicture.Count);
            totalSource.Show(); this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int index = Convert.ToInt32(pictureBox.Tag);

            if (pictureBox != null)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox.Invalidate();
                shuffle.switchTag(pictureBox, index, pictureBox3, pictureBox9, pictureBox8, pictureBox14);
            }

            Data.isCanMove = Path.isThePathCorrect(Data.road);
            if (Data.isCanMove == true)
            {
                Console.WriteLine("YOU CAN MOVE");
                timer1.Enabled = true;
            };
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