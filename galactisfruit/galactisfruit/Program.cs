using System;
using System.Collections.Generic;
using System.Diagnostics;
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


            //create map with white noise
            //image size
            var size = 256;
            var map = new double[size,size];
            
            //change texture with perlin noise
            var noise = new Perlin();
            var white_noise = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    double ni = (i + 1) * .00390625; // (1/256)
                    double nj = (j + 1) * .00390625;

                    map[i, j] = noise.OctavePerlin(ni, nj, 0,9,0.75);
                    
                    //map[i, j] = noise.perlin(ni, nj, 0);

                    //map[i, j] = white_noise.Next(0, 100)*0.01;
                }
            }
            
            //publish map to an image
            Publish.CreateImage("map.jpg",map);
            
            //create image file for new planet texture
        }
    }
}
