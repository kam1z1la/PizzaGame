using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Pizza_Game
{
    public class Picture : FillList
    {    
        Data data = new Data();

        public void fillingListWithPicturesFromTheForm(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    data.listPicture.Add(pictureBox);
                }
            }
            Console.WriteLine("Loaded {0} photos into the List.", data.listPicture.Count);
        }

        public void scatterPicturesInTheForm(Form form)
        {
            try
            {
                var images = creatingListOfImagesFromResources();
                fillingListWithPicturesFromTheForm(form);

                for (int i = 0; i < data.listPicture.Count; i++)
                {
                   if (data.listPicture[i].Tag.ToString() == "0")
                   {
                      int image_c = (new Random().Next(images.Count));
                      if (images[image_c].Key != "panel")
                      {
                        var image = images[image_c].Value;
                        data.listPicture[i].Image = image;
                        data.listPicture[i].Tag = image_c;
                        images.RemoveAt(image_c);
                      }
                   }
                }
                Console.WriteLine("Size list image {0}", images.Count);
            } catch(Exception ex) {
                Console.WriteLine("Mistake in random pictures:\n {0}", ex);
            }           
        }

        private static List<KeyValuePair<string, Bitmap>> creatingListOfImagesFromResources()
        {
            return Properties.Resources.ResourceManager
                .GetResourceSet(CultureInfo.CurrentCulture, true, true)
                .Cast<DictionaryEntry>()
                .Where(x => x.Value.GetType() == typeof(Bitmap))
                .Select(x => new KeyValuePair<string, Bitmap>(x.Key.ToString(), (Bitmap)x.Value))
                .ToList();
        }

        public void switchTag(PictureBox picture,int index, params object[] curvedRoad)
        {
            switch (index)
            {
                case 1:
                    picture.Tag = 2; break;
                case 2:
                    picture.Tag = (picture.Equals(curvedRoad)) ? 3 : 1; break;
                case 3:
                    picture.Tag = 4; break;
                case 4:
                    picture.Tag = 1; break;
            };
        }

        public void freeingMemoryFromPictures(List<PictureBox> pictureBoxes)
        {
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Image = null;
                pictureBox.Dispose();
            }
            pictureBoxes.Clear();
        }
    }
}