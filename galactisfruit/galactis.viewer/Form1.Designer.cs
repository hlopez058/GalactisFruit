namespace galactis.viewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trkOctave2 = new System.Windows.Forms.TrackBar();
            this.trkOctave1 = new System.Windows.Forms.TrackBar();
            this.trkPers2 = new System.Windows.Forms.TrackBar();
            this.trkPers1 = new System.Windows.Forms.TrackBar();
            this.trkRedis2 = new System.Windows.Forms.TrackBar();
            this.trkRedis1 = new System.Windows.Forms.TrackBar();
            this.trkFreq2 = new System.Windows.Forms.TrackBar();
            this.trkFreq1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkOctave2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkOctave1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPers2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRedis2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRedis1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 594);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.trkOctave2);
            this.splitContainer1.Panel1.Controls.Add(this.trkOctave1);
            this.splitContainer1.Panel1.Controls.Add(this.trkPers2);
            this.splitContainer1.Panel1.Controls.Add(this.trkPers1);
            this.splitContainer1.Panel1.Controls.Add(this.trkRedis2);
            this.splitContainer1.Panel1.Controls.Add(this.trkRedis1);
            this.splitContainer1.Panel1.Controls.Add(this.trkFreq2);
            this.splitContainer1.Panel1.Controls.Add(this.trkFreq1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1063, 594);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Persistence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Redistribution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Frequency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Octave";
            // 
            // trkOctave2
            // 
            this.trkOctave2.Location = new System.Drawing.Point(11, 110);
            this.trkOctave2.Maximum = 20;
            this.trkOctave2.Name = "trkOctave2";
            this.trkOctave2.Size = new System.Drawing.Size(180, 56);
            this.trkOctave2.TabIndex = 9;
            this.trkOctave2.Scroll += new System.EventHandler(this.trkOctave2_Scroll);
            this.trkOctave2.ValueChanged += new System.EventHandler(this.trkOctave2_ValueChanged);
            // 
            // trkOctave1
            // 
            this.trkOctave1.Location = new System.Drawing.Point(11, 48);
            this.trkOctave1.Maximum = 20;
            this.trkOctave1.Name = "trkOctave1";
            this.trkOctave1.Size = new System.Drawing.Size(180, 56);
            this.trkOctave1.TabIndex = 8;
            this.trkOctave1.ValueChanged += new System.EventHandler(this.trkOctave1_ValueChanged);
            // 
            // trkPers2
            // 
            this.trkPers2.Location = new System.Drawing.Point(11, 533);
            this.trkPers2.Maximum = 20;
            this.trkPers2.Name = "trkPers2";
            this.trkPers2.Size = new System.Drawing.Size(180, 56);
            this.trkPers2.TabIndex = 7;
            this.trkPers2.Scroll += new System.EventHandler(this.trkPers2_Scroll);
            this.trkPers2.ValueChanged += new System.EventHandler(this.trkPers2_ValueChanged);
            // 
            // trkPers1
            // 
            this.trkPers1.Location = new System.Drawing.Point(11, 471);
            this.trkPers1.Maximum = 20;
            this.trkPers1.Name = "trkPers1";
            this.trkPers1.Size = new System.Drawing.Size(180, 56);
            this.trkPers1.TabIndex = 6;
            this.trkPers1.ValueChanged += new System.EventHandler(this.trkPers1_ValueChanged);
            // 
            // trkRedis2
            // 
            this.trkRedis2.Location = new System.Drawing.Point(11, 393);
            this.trkRedis2.Maximum = 20;
            this.trkRedis2.Name = "trkRedis2";
            this.trkRedis2.Size = new System.Drawing.Size(180, 56);
            this.trkRedis2.TabIndex = 5;
            this.trkRedis2.ValueChanged += new System.EventHandler(this.trkRedis2_ValueChanged);
            // 
            // trkRedis1
            // 
            this.trkRedis1.Location = new System.Drawing.Point(11, 331);
            this.trkRedis1.Maximum = 20;
            this.trkRedis1.Name = "trkRedis1";
            this.trkRedis1.Size = new System.Drawing.Size(180, 56);
            this.trkRedis1.TabIndex = 4;
            this.trkRedis1.ValueChanged += new System.EventHandler(this.trkRedis1_ValueChanged);
            // 
            // trkFreq2
            // 
            this.trkFreq2.Location = new System.Drawing.Point(11, 242);
            this.trkFreq2.Maximum = 20;
            this.trkFreq2.Name = "trkFreq2";
            this.trkFreq2.Size = new System.Drawing.Size(180, 56);
            this.trkFreq2.TabIndex = 3;
            this.trkFreq2.ValueChanged += new System.EventHandler(this.trkFreq2_ValueChanged);
            // 
            // trkFreq1
            // 
            this.trkFreq1.Location = new System.Drawing.Point(11, 180);
            this.trkFreq1.Maximum = 20;
            this.trkFreq1.Name = "trkFreq1";
            this.trkFreq1.Size = new System.Drawing.Size(180, 56);
            this.trkFreq1.TabIndex = 2;
            this.trkFreq1.Scroll += new System.EventHandler(this.slider_Option1_Scroll);
            this.trkFreq1.ValueChanged += new System.EventHandler(this.trkFreq1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 594);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkOctave2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkOctave1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPers2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRedis2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRedis1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TrackBar trkFreq2;
        private System.Windows.Forms.TrackBar trkFreq1;
        private System.Windows.Forms.TrackBar trkOctave2;
        private System.Windows.Forms.TrackBar trkOctave1;
        private System.Windows.Forms.TrackBar trkPers2;
        private System.Windows.Forms.TrackBar trkPers1;
        private System.Windows.Forms.TrackBar trkRedis2;
        private System.Windows.Forms.TrackBar trkRedis1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

