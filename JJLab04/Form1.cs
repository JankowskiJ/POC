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
using System.Windows.Forms.DataVisualization.Charting;

namespace JJLab04
{
    public partial class Form1 : Form
    {
        Bitmap obrazekOrginal;
        Bitmap obrazekCopy;
        Bitmap obrazekOdejm;
        int obrazekOdejmW, obrazekOdejmS;
        int wysokosc;
        int szerokosc;
        public static int prog = 0;
        public static bool isAtuomatic = false;
        public Form1()
        {
            InitializeComponent();
        }

        private static void FromRGBtoHSV(Color orginal,out double hue,out double saturation,out double value)
        {
            hue = orginal.GetHue();
            saturation = orginal.GetSaturation();
            value = orginal.GetBrightness();
        }

        private static void FromRGBtoYUV(Color orginal, out int y, out double u, out double v)
        {
            double yDouble = (orginal.R * 0.299 + orginal.G * 0.587 + orginal.B * 0.114);
            y = (int)Math.Round(yDouble);
            u = (0.493 * (orginal.B - y));
            v = (0.877 * (orginal.R - y));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Title = "Odcień szarości";
            chart1.ChartAreas[0].AxisY.Title = "Liczba pikseli";
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Interval = 10;
            chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "#";
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "#";

            chart1.ChartAreas[0].BackColor = Color.White;
            chart1.Legends.Clear();
            chart1.Series["Szarosc"].IsValueShownAsLabel = false;
            chart1.Series["Szarosc"].BorderWidth = 1;
            chart1.Titles.Add("Histogram Szarości");
            chart1.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
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
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out int y, out double u, out double v);
                    pxl = Color.FromArgb(y, y, y);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }


        private void progowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgowaniePopUp progowanie = new ProgowaniePopUp();
            progowanie.ShowDialog();

            if(isAtuomatic == true)
            {
                int[] tablicaszarosci = new int[256];
                Color pxl;
                int max = 0;
                int maxi = 0;
                for (int i = 0; i < wysokosc; i++)
                {
                    for (int j = 0; j < szerokosc; j++)
                    {
                        pxl = obrazekCopy.GetPixel(j, i);
                        FromRGBtoYUV(pxl, out int y, out double u, out double v);
                        tablicaszarosci[y]++;
                    }
                }
                for(int i = 0; i < 256; i++)
                {
                    if (tablicaszarosci[i] > max)
                    {
                        max = tablicaszarosci[i];
                        maxi = i;
                    }
                }
                for (int i = 0; i < wysokosc; i++)
                {
                    for (int j = 0; j < szerokosc; j++)
                    {
                        pxl = obrazekCopy.GetPixel(j, i);
                        FromRGBtoYUV(pxl, out int y, out double u, out double v);

                        if (y >= maxi)
                        {
                            pxl = Color.FromArgb(255, 255, 255);
                        }
                        else
                        {
                            pxl = Color.FromArgb(0, 0, 0);
                        }
                        obrazekCopy.SetPixel(j, i, pxl);
                    }
                }
                isAtuomatic = false;
                pictureBoxResult.Image = obrazekCopy;

            }
            else
            {
                Color pxl;
                for (int i = 0; i < wysokosc; i++)
                {
                    for (int j = 0; j < szerokosc; j++)
                    {
                        pxl = obrazekCopy.GetPixel(j, i);
                        FromRGBtoYUV(pxl, out int y, out double u, out double v);

                        if (y >= prog) {
                            pxl = Color.FromArgb(255, 255, 255);
                        }
                        else
                        {
                            pxl = Color.FromArgb(0, 0, 0);
                        }
                        obrazekCopy.SetPixel(j, i, pxl);
                    }
                }
                pictureBoxResult.Image = obrazekCopy;
            }

        }

        private void odejmowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            int szary,szary2,szary3;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out int y, out double u, out double v);
                    szary = y;

                    pxl = obrazekOdejm.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out y, out u, out v);
                    szary2 = y;

                    szary3 = szary - szary2;
                    if (szary3 < 0)
                    {
                        szary3 = 0;
                    }

                    pxl = Color.FromArgb(szary3, szary3, szary3);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] tablicaszarosci = new int[256];
            Color pxl;
            chart1.Series["Szarosc"].Points.Clear();
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out int y, out double u, out double v);
                    tablicaszarosci[y]++;
                }
            }
            for (int i = 0; i < 256; i++)
            {
                chart1.Series["Szarosc"].Points.AddXY(i, tablicaszarosci[i]);
                tablicaszarosci[i] = 0;
            }
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void multiProgowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out int y, out double u, out double v);
                    pxl = Color.FromArgb(y, y, y);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void filtracjaLiniowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltracjaLiniowa filtracjaLiniowa = new FiltracjaLiniowa();
            filtracjaLiniowa.ShowDialog();
        }

        private void PictureButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog okienko = new OpenFileDialog();
            okienko.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp|TIFF|*.tif";
            if (okienko.ShowDialog() == DialogResult.OK && okienko.CheckFileExists == true)
                pictureBoxOdejm.Image = Image.FromFile(okienko.FileName);
            obrazekOdejm = (Bitmap)pictureBoxOdejm.Image;
        }
    }
}
