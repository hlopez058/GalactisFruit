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
                    var N = scaleBetween(map[x, y], 0, 255, 0, 1);
                    flag.SetPixel(x, y, Color.FromArgb(N, 0, 0));
                }
            }

            
            flag.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private static int scaleBetween(double unscaledNum, double minAllowed, double maxAllowed,double  min,double max)
        {
            return Convert.ToInt16((maxAllowed - minAllowed) * (unscaledNum - min) / (max - min) + minAllowed);
        }
    }
}
