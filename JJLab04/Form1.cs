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
            obrazekCopy = obrazekOrginal;
            wysokosc = obrazekCopy.Height;
            szerokosc = obrazekCopy.Width;
            pictureBoxResult.Image = obrazekCopy;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Red_Click(object sender, EventArgs e)
        {
            Color pxl;
            for(int i = 0; i < wysokosc; i++)
            {
                for(int j = 0; j < szerokosc; j++)
                {
                    pxl = Color.FromArgb(255, 0, 0);
                    obrazekCopy.SetPixel(i, j, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;   

        }

        private void Green_Click(object sender, EventArgs e)
        {
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = Color.FromArgb(0, 255, 0);
                    obrazekCopy.SetPixel(i, j, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = Color.FromArgb(0, 0, 255);
                    obrazekCopy.SetPixel(i, j, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
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

        }
    }
}
