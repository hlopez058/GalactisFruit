using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galactisfruit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Galactis Fruit - Generate Planet Textures");




            //inputs : solar system information


            var img_size = 256;
            var map = new double[img_size, img_size];
            var img_map = new List<KeyValuePair<Point, Color>>();
            
            //center the image
            var origin = new Point(img_size / 2, img_size / 2);
            var radius = img_size / 2;

            //create surface model
            var globe = new Surface(origin, radius, 100, 10, .6);
            var atmosphere = new Surface(origin, radius, 50, 3, 0.5);
            var terrain = new Surface(origin, radius, 100, 20, 0.8);

            //walk through pixels on image
            for (int x = 0; x < img_size; x++)
            {
                for (int y = 0; y < img_size; y++)
                {
                    var zcolor = new Color();
                    zcolor = Color.FromArgb( globe.GetPointVal(x,y), terrain.GetPointVal(x,y), atmosphere.GetPointVal(x, y));
                    img_map.Add(new KeyValuePair<Point, Color>(new Point() { X = x, Y = y }, zcolor));
                }
            }

            //publish map to an image
            //Publish.CreateImage("map.jpg", map);
            Publish.CreateImageMap("map.jpg", img_map,img_size);

        }
    }

    public class Surface
    {
        private Point origin;
        private int radius;
        private double depth;
        private int octaves;
        private double persistence;

        public Perlin Noise;

        public Surface(Point origin, int radius, double depth = 1, int octaves = 1, double persistence = 0.1)
        {
            this.origin = origin;
            this.radius = radius;
            this.depth = depth;
            this.octaves = octaves;
            this.persistence = persistence;
            Noise = new Perlin();

        }

        public Point3D GetPoint(int x, int y, double scalar = 1)
        {
            var point_xy_plane = cart2polar(x, y);
            //var z = Math.Sqrt(Math.Pow(point_xy_plane.r,2) - Math.Pow(radius, 2));
            var z = Math.Acos(point_xy_plane.r / radius);

            return new Point3D() { X = x / scalar, Y = y / scalar, Z = (z / scalar) * depth };
        }

        public class Point3D
        {
            public double X { get; internal set; }
            public double Y { get; internal set; }
            public double Z { get; internal set; }
        }

        public bool TestPoint(int x, int y)
        {
            if (cart2polar(x, y).r > this.radius) { return false; } else { return true; }
        }

        private PolarPoint cart2polar(int x, int y)
        {
            var polar = new PolarPoint();

            polar.r = Math.Sqrt(Math.Pow((x - this.origin.X), 2) + Math.Pow((y - this.origin.Y), 2));

            if (x != 0)
            {
                polar.theta = Math.Atan(y / x);
            }
            else
            {
                polar.theta = 0;
            }
            return polar;
        }

        internal int GetPointVal(int x, int y)
        {

            if (this.TestPoint(x, y))
            {
                var p = this.GetPoint(x, y, this.radius);

                var n = Noise.OctavePerlin(p.X, p.Y, p.Z, this.octaves, this.persistence);
                //var n = white_noise.Next(0, 1);
                //var n = noise.perlin(p.X, p.Y, p.Z);

                return Convert.ToInt16(Noise.scaleBetween(n, 0, 256));
            }
            else
            {
                return 0;
            }
        }

        class PolarPoint
        {
            public double r;
            public double theta;
        }
    }

}
