﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTWARE_TESTING_AND_DEBUGGING_C_SHARP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Calc =  new Calculater(this.Images);
        }

        public void BrightnessNContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBrightness setting = new FormBrightness(Images,this);
            setting.Show();
            setting.Focus();
            return;
        }
        public ProgramImage Images = new ProgramImage();
        public Calculater Calc;
        public int IndexActiviteForm
        {
            get { return IndexActiviteFormImage; }
            set { IndexActiviteFormImage = value; }
        }
        private int IndexActiviteFormImage = 0;

        private void NewImageForVideoCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }

        public void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog system = new OpenFileDialog();
            system.ShowDialog();
            string result = system.FileName;
            Bitmap newimage = new Bitmap(result);
            Images.AddNewImage(newimage);
            return;
        }

        private void BinarizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBinarization setting = new FormBinarization(this, this.Images);
            setting.Show();
            setting.Focus();
        }

        private void MorphoBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.IndexActiviteForm;
            int error = Images.BorderProcessing(index);
            if (error == 0)
            {
                index = Images.GetCountImages();
                Bitmap map = Images.GetLastBitmap();
                FormImage newimage = new FormImage(index, this, map);
                newimage.Show();
                newimage.Focus();
                return;
            }
        }

        private void InfoOfParticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAutoMeasureTable measuretable = new FormAutoMeasureTable(this, this.Images, this.Calc, this.IndexActiviteFormImage);
            measuretable.Show();
            measuretable.Focus();
            return;
        }
    }
}
