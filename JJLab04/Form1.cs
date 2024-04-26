using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJLab04
{
    public partial class Form1 : Form
    {
        Bitmap obrazekOrginal;
        Bitmap obrazekCopy;
        int wysokosc;
        int szerokosc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog okienko = new OpenFileDialog();
            okienko.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp|TIFF|*.tif";
            if (okienko.ShowDialog() == DialogResult.OK && okienko.CheckFileExists == true)
                pictureBoxOriginal.Image = Image.FromFile(okienko.FileName);
            obrazekOrginal = (Bitmap)pictureBoxOriginal.Image;
            obrazekCopy = new Bitmap(obrazekOrginal);
            wysokosc = obrazekCopy.Height;
            szerokosc = obrazekCopy.Width;
            pictureBoxResult.Image = obrazekCopy;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

     

        private void Zapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog okienko = new SaveFileDialog();
            okienko.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp|TIFF|*.tif";
            if (okienko.ShowDialog() == DialogResult.OK)
            {
                pictureBoxResult.Image.Save(okienko.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Zapisano plik");
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            obrazekCopy = new Bitmap(obrazekOrginal);
            pictureBoxResult.Image = obrazekCopy;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Color pxl;
            int R;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    R = pxl.R;

                    pxl = Color.FromArgb(R, 0, 0);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Color pxl;
            int G;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    G = pxl.G;
                    pxl = Color.FromArgb(0, G, 0);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Color pxl;
            int B; ;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    B = pxl.B;
                    pxl = Color.FromArgb(0, 0, B);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void Zeruj_Click(object sender, EventArgs e)
        {
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = Color.FromArgb(0, 0, 0);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void pictureBoxResult_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void hSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[] hsv = new float[3];
            

        }

        private void yUVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void metodaSredniejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            int szary;
            int R;
            int G;
            int B;

            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    R = pxl.R;
                    G = pxl.G;
                    B = pxl.B;
                    szary = (R + G + B) / 3;
                    pxl = Color.FromArgb(szary, szary, szary);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void zModeluYUVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            int szary;
            double R,G,B;
            int Ri, Gi, Bi;

            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    R = pxl.R*0.299;
                    G = pxl.G*0.587;
                    B = pxl.B*0.114;
                    Ri = (int)Math.Round(R);
                    Gi = (int)Math.Round(G);
                    Bi = (int)Math.Round(B);

                    szary = (Ri+Gi+Bi);
                    pxl = Color.FromArgb(szary, szary, szary);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }
    }
}
