using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galactis
{
    public class MapMaker
    {
        public class MapSettings
        {
            public int frequency { get; set; }
            public int octaves { get; set; }
            public int persistence { get; set; }
            public int redistribution { get; set; }
        }

        public MapMaker()
        {
            
        }

        public Map CreateMap(int height,int width,MapSettings elevation_settings, MapSettings moisture_settings)
        {

            var elevation = GetNoiseMap(height,
                                            width,
                                            elevation_settings.frequency,
                                            elevation_settings.octaves,
                                            elevation_settings.persistence,
                                            elevation_settings.redistribution);

            var moisture = GetNoiseMap(height,
                                        width,
                                        moisture_settings.frequency,
                                        moisture_settings.octaves,
                                        moisture_settings.persistence,
                                        moisture_settings.redistribution);


            var map = new Map(height, width);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var e = elevation[y, x];

                    var m = moisture[y, x];

                    var biome = GetBiome(e, m);

                    var b = BiomeColorizer(biome);

                    map.colored[y, x] = b;

                    map.elevation[y, x] = e;
                }
            }

            return map;
        }

        public static Map CreateMap(int height, int width)
        {
            var elevation = GetNoiseMap(height, width, 1, 4, 2, 1);

            var moisture = GetNoiseMap(height, width, 1, 1, 2, 1);

            var map = new Map(height, width);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var e = elevation[y, x];

                    var m = moisture[y, x];

                    var biome = GetBiome(e, m);

                    var b = BiomeColorizer(biome);

                    map.colored[y, x] = b;

                    map.elevation[y, x] = e;
                }
            }

            return map;
        }

        public class Map
        {
            public Color[,] colored;

            public double[,] elevation;

            public Map(int height, int width)
                { colored = new Color[height, width]; elevation = new double[height, width]; }
        }

        public static double[,] GetNoiseMap(
            int height,
            int width,
            int frequency,
            int octaves,
            int persistence,
            int redistribution)
        {
            var noise = new Perlin();
               
            double[,] map = new double[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double nx = Convert.ToDouble(x) / width, ny = Convert.ToDouble(y) / height;

                    var e = noise.OctavePerlin(frequency * nx, frequency * ny, 0,octaves,persistence);
                    
                    map[y,x] = Math.Pow(e,redistribution);
                }
            }

            return map;
        }

        private enum Biome
        {
            LAND,
            WATER,
            OCEAN,
            BEACH,
            SCORCHED,
            BARE,
            TUNDRA,
            SNOW,
            TEMPERATE_DESERT,
            SHRUBLAND,
            TAIGA,
            GRASSLAND,
            TEMPERATE_DECIDUOUS_FOREST,
            TEMPERATE_RAIN_FOREST,
            SUBTROPICAL_DESERT,
            TROPICAL_SEASONAL_FOREST,
            TROPICAL_RAIN_FOREST
        }

        private static Biome GetBiome(double e,double m)
        {

            if (e < 0.1) return Biome.OCEAN;
            if (e < 0.12) return Biome.BEACH;

            if (e > 0.8)
            {
                if (m < 0.1) return Biome.SCORCHED;
                if (m < 0.2) return Biome.BARE;
                if (m < 0.5) return Biome.TUNDRA;
                return Biome.SNOW;
            }

            if (e > 0.6)
            {
                if (m < 0.33) return Biome.TEMPERATE_DESERT;
                if (m < 0.66) return Biome.SHRUBLAND;
                return Biome.TAIGA;
            }

            if (e > 0.3)
            {
                if (m < 0.16) return Biome.TEMPERATE_DESERT;
                if (m < 0.50) return Biome.GRASSLAND;
                if (m < 0.83) return Biome.TEMPERATE_DECIDUOUS_FOREST;
                return Biome.TEMPERATE_RAIN_FOREST;
            }

            if (m < 0.16) return Biome.SUBTROPICAL_DESERT;
            if (m < 0.33) return Biome.GRASSLAND;
            if (m < 0.66) return Biome.TROPICAL_SEASONAL_FOREST;
            return Biome.TROPICAL_RAIN_FOREST;
        }

        private static Color BiomeColorizer(Biome b)
        {
            switch (b)
            {
                case Biome.LAND: return Color.SandyBrown;
                case Biome.BARE: return Color.Silver;
                case Biome.BEACH: return Color.White;
                case Biome.GRASSLAND: return Color.LawnGreen;
                case Biome.OCEAN: return Color.DarkSeaGreen;
                case Biome.SCORCHED: return Color.OrangeRed;
                case Biome.SHRUBLAND: return Color.DarkOliveGreen;
                case Biome.SNOW: return Color.Snow;
                case Biome.SUBTROPICAL_DESERT: return Color.Tan;
                case Biome.TAIGA: return Color.ForestGreen;
                case Biome.TEMPERATE_DECIDUOUS_FOREST: return Color.LimeGreen;
                case Biome.TEMPERATE_DESERT: return Color.IndianRed;
                case Biome.TEMPERATE_RAIN_FOREST: return Color.MediumSpringGreen;
                case Biome.TROPICAL_RAIN_FOREST: return Color.SpringGreen;
                case Biome.TROPICAL_SEASONAL_FOREST: return Color.YellowGreen;
                case Biome.TUNDRA: return Color.Turquoise;
                case Biome.WATER: return Color.DarkBlue;
                default: return Color.Gray;
            }
        }

    }

    public class ImageMaker
    {
        public static System.Drawing.Bitmap CreateImage( Color[,] colormap)
        {
            System.Drawing.Bitmap img = new System.Drawing.Bitmap(colormap.GetLength(0), colormap.GetLength(1));

            for (int x = 0; x < img.Height; ++x)
            {
                for (int y = 0; y < img.Width; ++y)
                {
                    img.SetPixel(x, y, colormap[x, y]);
                }
            }
            return img;
        }

        public static void CreateImage(string filename, Color[,] colormap)
        {
            System.Drawing.Bitmap img = new System.Drawing.Bitmap(colormap.GetLength(0), colormap.GetLength(1));

            for (int x = 0; x < img.Height; ++x)
            {
                for (int y = 0; y < img.Width; ++y)
                {
                    img.SetPixel(x, y, colormap[x, y]);
                }
            }

            img.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        
    }

    public class Perlin
    {
        public int repeat;

        public Perlin(int repeat = -1)
        {

            this.repeat = repeat;

        }

        public double OctavePerlin(double x, double y, double z, int octaves, double persistence)
        {

            double total = 0;

            double frequency = 1;

            double amplitude = 1;

            double maxValue = 0;            // Used for normalizing result to 0.0 - 1.0

            for (int i = 0; i < octaves; i++)
            {

                total += perlin(x * frequency, y * frequency, z * frequency) * amplitude;
                
                maxValue += amplitude;

                amplitude *= persistence;

                frequency *= 2;
            }
            
            return total / maxValue;

        }

        private static readonly int[] permutation = { 151,160,137,91,90,15,					// Hash lookup table as defined by Ken Perlin.  This is a randomly

		131,13,201,95,96,53,194,233,7,225,140,36,103,30,69,142,8,99,37,240,21,10,23,	// arranged array of all numbers from 0-255 inclusive.

		190, 6,148,247,120,234,75,0,26,197,62,94,252,219,203,117,35,11,32,57,177,33,

        88,237,149,56,87,174,20,125,136,171,168, 68,175,74,165,71,134,139,48,27,166,

        77,146,158,231,83,111,229,122,60,211,133,230,220,105,92,41,55,46,245,40,244,

        102,143,54, 65,25,63,161, 1,216,80,73,209,76,132,187,208, 89,18,169,200,196,

        135,130,116,188,159,86,164,100,109,198,173,186, 3,64,52,217,226,250,124,123,

        5,202,38,147,118,126,255,82,85,212,207,206,59,227,47,16,58,17,182,189,28,42,

        223,183,170,213,119,248,152, 2,44,154,163, 70,221,153,101,155,167, 43,172,9,

        129,22,39,253, 19,98,108,110,79,113,224,232,178,185, 112,104,218,246,97,228,

        251,34,242,193,238,210,144,12,191,179,162,241, 81,51,145,235,249,14,239,107,

        49,192,214, 31,181,199,106,157,184, 84,204,176,115,121,50,45,127, 4,150,254,

        138,236,205,93,222,114,67,29,24,72,243,141,128,195,78,66,215,61,156,180

        };

        private static readonly int[] p;                                                    // Doubled permutation to avoid overflow

        static Perlin()
        {

            p = new int[512];

            for (int x = 0; x < 512; x++)
            {

                p[x] = permutation[x % 256];

            }

        }

        public double scaleBetween(double unscaledNum, double minAllowed, double maxAllowed, double min = 0, double max = 1)
        {
            return (maxAllowed - minAllowed) * (unscaledNum - min) / (max - min) + minAllowed;
        }
        public double perlin(double x, double y, double z)
        {

            if (repeat > 0)
            {                                   // If we have any repeat on, change the coordinates to their "local" repetitions

                x = x % repeat;

                y = y % repeat;

                z = z % repeat;

            }



            int xi = (int)x & 255;                              // Calculate the "unit cube" that the point asked will be located in

            int yi = (int)y & 255;                              // The left bound is ( |_x_|,|_y_|,|_z_| ) and the right bound is that

            int zi = (int)z & 255;                              // plus 1.  Next we calculate the location (from 0.0 to 1.0) in that cube.

            double xf = x - (int)x;                             // We also fade the location to smooth the result.

            double yf = y - (int)y;


            double zf = z - (int)z;

            double u = fade(xf);

            double v = fade(yf);

            double w = fade(zf);



            int aaa, aba, aab, abb, baa, bba, bab, bbb;

            aaa = p[p[p[xi] + yi] + zi];

            aba = p[p[p[xi] + inc(yi)] + zi];

            aab = p[p[p[xi] + yi] + inc(zi)];

            abb = p[p[p[xi] + inc(yi)] + inc(zi)];

            baa = p[p[p[inc(xi)] + yi] + zi];

            bba = p[p[p[inc(xi)] + inc(yi)] + zi];

            bab = p[p[p[inc(xi)] + yi] + inc(zi)];

            bbb = p[p[p[inc(xi)] + inc(yi)] + inc(zi)];



            double x1, x2, y1, y2;

            x1 = lerp(grad(aaa, xf, yf, zf),                // The gradient function calculates the dot product between a pseudorandom

                        grad(baa, xf - 1, yf, zf),              // gradient vector and the vector from the input coordinate to the 8

                        u);                                     // surrounding points in its unit cube.

            x2 = lerp(grad(aba, xf, yf - 1, zf),                // This is all then lerped together as a sort of weighted average based on the faded (u,v,w)

                        grad(bba, xf - 1, yf - 1, zf),              // values we made earlier.

                          u);

            y1 = lerp(x1, x2, v);



            x1 = lerp(grad(aab, xf, yf, zf - 1),

                        grad(bab, xf - 1, yf, zf - 1),

                        u);

            x2 = lerp(grad(abb, xf, yf - 1, zf - 1),

                          grad(bbb, xf - 1, yf - 1, zf - 1),

                          u);

            y2 = lerp(x1, x2, v);



            return (lerp(y1, y2, w) + 1) / 2;                       // For convenience we bound it to 0 - 1 (theoretical min/max before is -1 - 1)

        }

        private int inc(int num)
        {

            num++;

            if (repeat > 0) num %= repeat;



            return num;

        }

        private static double grad(int hash, double x, double y, double z)
        {

            int h = hash & 15;                                  // Take the hashed value and take the first 4 bits of it (15 == 0b1111)

            double u = h < 8 /* 0b1000 */ ? x : y;              // If the most significant bit (MSB) of the hash is 0 then set u = x.  Otherwise y.



            double v;                                           // In Ken Perlin's original implementation this was another conditional operator (?:).  I

            // expanded it for readability.



            if (h < 4 /* 0b0100 */)                             // If the first and second significant bits are 0 set v = y

                v = y;

            else if (h == 12 /* 0b1100 */ || h == 14 /* 0b1110*/)// If the first and second significant bits are 1 set v = x

                v = x;

            else                                                // If the first and second significant bits are not equal (0/1, 1/0) set v = z

                v = z;



            return ((h & 1) == 0 ? u : -u) + ((h & 2) == 0 ? v : -v); // Use the last 2 bits to decide if u and v are positive or negative.  Then return their addition.

        }

        private static double fade(double t)
        {

            // Fade function as defined by Ken Perlin.  This eases coordinate values

            // so that they will "ease" towards integral values.  This ends up smoothing

            // the final output.

            return t * t * t * (t * (t * 6 - 15) + 10);         // 6t^5 - 15t^4 + 10t^3

        }

        private static double lerp(double a, double b, double x)
        {

            return a + x * (b - a);

        }

    }
}
