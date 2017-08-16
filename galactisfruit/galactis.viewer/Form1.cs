﻿using System;
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

            var map = MapMaker.CreateMap(512, 512);

            pictureBox1.Image = ImageMaker.CreateImage(map.colored);
        }
    }
}