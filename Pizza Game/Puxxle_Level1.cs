using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Pizza_Game
{
    public partial class Puxxle_Level1 : Form, Direction
    {
        private static Path win = new Path();
        Picture shuffle = new Picture();
        Data data = new Data();
        DataUI dataUI;
        TotalSource totalSource = new TotalSource();

        private async void Puxxle_Level1_Load(object sender, EventArgs e)
        {
            await win.createRoadAsync(data.road,  pictureBox6, pictureBox5, pictureBox4, pictureBox3, pictureBox2,
            pictureBox23, pictureBox22, pictureBox21, pictureBox20, pictureBox19, pictureBox24);
            Console.WriteLine("Loaded {0} photos into the ArrayList. From class Win", data.road.Count);
            data.courier = pictureBox25;
            timer2.Enabled = true;
        }

        public Puxxle_Level1(DataUI ui)
        {
            InitializeComponent();
            dataUI = ui;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int index = Convert.ToInt32(pictureBox.Tag);

            if (pictureBox != null)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox.Invalidate();
                shuffle.switchTag(pictureBox, index, pictureBox2, pictureBox23);
                Console.WriteLine("PictureBox {0} has Tag {1}.", pictureBox.Name, pictureBox.Tag);
            }

            data.isCanMove = win.isThePathCorrect(data.road);
            if (data.isCanMove == true)
            {
                timer1.Enabled = true;
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {         
            int cx = data.courier.Location.X;
            int cy = data.courier.Location.Y;
            

            Console.WriteLine("cx {0} cy {1}", cx, cy);
            foreach (var picture in data.road)
            {
                int direction = 0;
                int centerX = (picture.Location.X + (picture.Width / 2) - 30);
                int dis =  picture.Location.Y + (picture.Height / 2) - data.courier.Location.Y;
                Console.WriteLine("dis {0}", dis);

                int centerY = picture.Location.Y + (picture.Height / 2);
                Console.WriteLine("centerX {0} centerY {1}", centerX, centerY);
                Rectangle courierBounds1 = new Rectangle(data.courier.Location, data.courier.Size);


                while (Math.Abs(data.courier.Location.X - centerX) > 9 
                || Math.Abs(data.courier.Location.Y - centerY) > 20)
                {                  
                    if (dis < 100)
                    {
                        if (data.courier.Location.X < centerX)
                        {
                            cx += 10;
                            direction = 0;
                        }
                        else
                        {
                            cx -= 10;
                            direction = 1;
                            
                        }
                    }
                    else
                    {
                        if (data.courier.Location.Y < centerY)
                        {
                            cy += 10;
                            direction = 3;
                        }
                        else
                        {
                            cy -= 10;
                            direction = 2;
                        }
                    }

                    data.courier.Location = new Point(cx, cy);
                    this.Refresh();

                    setDirection(direction, data.courier);
                    Console.WriteLine("switchTag {0}", data.courier.Tag);


                    Console.WriteLine("cx {0} cy {1}", cx, cy);
                    System.Threading.Thread.Sleep(200);
                }
                this.Refresh();
            }
            dataUI.isWin = true;
            timer1.Enabled = false;
            timer2.Enabled = false;
            data.isCanMove = false;
            totalSource.getForm(new Puxxle_Level1(dataUI));
            totalSource.getInfo(dataUI.isWin, ExtraLife.Text, Time.Text, Points.Text);
            totalSource.Show(); this.Hide();
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
            } else
            {
                dataUI.isWin = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
                totalSource.getForm(new Puxxle_Level1(dataUI));
                totalSource.getInfo(dataUI.isWin, ExtraLife.Text, Time.Text, Points.Text);
                totalSource.Show(); this.Hide();
            }
        }

        public void setDirection(int index, PictureBox courier)
        {
            switch(index)
            {
                case 1:
                    if (!courier.Tag.Equals(6))
                    {
                        courier.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        courier.Size = new Size(54, 28);
                        courier.Tag = 6;                     
                    }
                    break;  
                case 3:
                    if (!courier.Tag.Equals(8))
                    {
                        courier.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        courier.Size = new Size(41, 35);
                        courier.Tag = 8;
                    }
                    break; 
            }
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