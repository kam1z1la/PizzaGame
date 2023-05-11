using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Game
{
    internal class Path 
    {
        public async Task createRoadAsync(List<PictureBox> listPicture, params object[] pictureBox)
        {
             foreach(PictureBox pb in pictureBox)
             {
                await Task.Delay(100);
                listPicture.Add(pb);
             }          
        }

        public bool isThePathCorrect(List<PictureBox> listPicture)
        {           
            foreach (PictureBox picture in listPicture)
            {
                Console.WriteLine(picture.Name);
                if (picture.Tag.ToString() != "1")
                {
                   Console.WriteLine(picture.Name);
                   return false;
                }
            }          
            return true;
        }
    }
}