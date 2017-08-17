using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galactis.viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
               
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
        
        private void Generate()
        {

            var elevation_settings = new MapMaker.MapSettings();
            elevation_settings.frequency = trkFreq1.Value;
            elevation_settings.octaves = trkOctave1.Value;
            elevation_settings.persistence = trkPers1.Value;
            elevation_settings.redistribution = trkRedis1.Value;

            var moisture_settings = new MapMaker.MapSettings();
            moisture_settings.frequency = trkFreq2.Value;
            moisture_settings.octaves = trkOctave2.Value;
            moisture_settings.persistence = trkPers2.Value;
            moisture_settings.redistribution = trkRedis2.Value;


            var mapmaker = new MapMaker();

            var map = mapmaker.CreateMap(512, 512, elevation_settings, moisture_settings);


            pictureBox1.Image = ImageMaker.CreateImage(map.colored);


        }

        private void slider_Option1_Scroll(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trkOctave1_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void trkOctave2_Scroll(object sender, EventArgs e)
        {

        }

        private void trkOctave2_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void trkFreq1_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void trkFreq2_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void trkRedis1_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void trkRedis2_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void trkPers1_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void trkPers2_Scroll(object sender, EventArgs e)
        {
           
        }

        private void trkPers2_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }
    }
}
