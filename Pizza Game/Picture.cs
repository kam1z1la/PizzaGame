using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace Pizza_Game
{
    public class Picture : FillList
    {    
        public void fillingListWithPicturesFromTheForm(Form form)
        {
            Console.WriteLine("[INFO] Number of images before loaded in listPicture: {0}", Data.listPicture.Count);
            foreach (Control control in form.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    if (control.Tag.ToString() == "0")
                    {
                        Data.listPicture.Add(pictureBox);
                    }
                }
            }
            Console.WriteLine("[INFO] Number of images after loaded in listPicture: {0}", Data.listPicture.Count);
        }

        public void scatterPicturesInTheForm(Form form)
        {
            try
            {
                var images = creatingListOfImagesFromResources();
                fillingListWithPicturesFromTheForm(form);

                long startMemory = Process.GetCurrentProcess().WorkingSet64;

                for (int i = 0; i < Data.listPicture.Count; i++)
                {
                      int image_c = (new Random().Next(images.Count));
                      if (image_c >= 0 && image_c < images.Count && images[image_c].Key != "panel")
                      {
                        var image = images[image_c].Value;
                        Data.listPicture[i].Image = image;
                        Data.listPicture[i].Tag = image_c;
                        images.RemoveAt(image_c);
                      }
                }
                Console.WriteLine("[INFO] Size list image: {0}", images.Count);

                сlearImages(images);

                long endMemory = Process.GetCurrentProcess().WorkingSet64;
                long methodMemory = endMemory - startMemory;

                Console.WriteLine("Memory used by scatterPicturesInTheForm: {0} bytes", methodMemory);
                Console.WriteLine("Memory freed after scatterPicturesInTheForm: {0} bytes", methodMemory - (images.Count * sizeof(int))); 

            } catch(Exception ex) {
                Console.WriteLine("[EXCEPTION] Mistake in random pictures: {0}", ex);
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

        public void сlearImages(List<KeyValuePair<string, Bitmap>> images)
        {
            foreach (var image in images)
            {
                image.Value.Dispose();
            }
            images.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void switchTag(PictureBox picture,int index, params object[] curvedRoad)
        {
            switch (index)
            {
                case 1:
                    picture.Tag = 2; break;
                case 2:
                    picture.Tag = curvedRoad.Contains(picture)? 3 : 1; break;
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
                pictureBox.Image?.Dispose();
                pictureBox.Dispose();
            }
            pictureBoxes.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
} 