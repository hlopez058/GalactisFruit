using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace galactisfruit
{
    class Publish
    {
        public static void CreateImage(string filename, double[,] map)
        {
            System.Drawing.Bitmap flag = new System.Drawing.Bitmap(map.GetLength(0), map.GetLength(1));

            for (int x = 0; x < flag.Height; ++x)
            {
                for (int y = 0; y < flag.Width; ++y)
                {
                    flag.SetPixel(x, y, Color.FromArgb(Convert.ToInt16(map[x,y]),0, 0));
                }
            }

            
            flag.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        
    }
}
