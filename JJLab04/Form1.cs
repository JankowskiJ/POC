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
        Bitmap obrazekCopy2;
        int obrazekOdejmW, obrazekOdejmS;
        int wysokosc;
        int szerokosc;
        public static int prog = 0;
        public static int progD = 0;
        public static int progG = 0;
        public static bool isAtuomatic = false;
        public Form1()
        {
            InitializeComponent();
        }
        private static void FromRGBtoHSV(Color orginal, out double hue, out double saturation, out double value)
        {
            hue = orginal.GetHue();
            saturation = orginal.GetSaturation();
            value = orginal.GetBrightness();
        }

        private static void FromRGBtoYUV(Color orginal, out int y, out int u, out int v)
        {
            double yDouble = (orginal.R * 0.299 + orginal.G * 0.587 + orginal.B * 0.114);
            double uDouble = (0.493 * (orginal.B - yDouble)) + 180;
            double vDouble = (0.877 * (orginal.R - yDouble)) + 180;

            y = Math.Max(0, Math.Min(255, (int)yDouble));
            u = Math.Max(0, Math.Min(255, (int)uDouble));
            v = Math.Max(0, Math.Min(255, (int)vDouble));

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
            obrazekCopy2 = new Bitmap(obrazekOrginal);
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
                    FromRGBtoYUV(pxl, out int y, out int u, out int v);
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

            if (isAtuomatic == true)
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
                        FromRGBtoYUV(pxl, out int y, out int u, out int v);
                        tablicaszarosci[y]++;
                    }
                }
                for (int i = 0; i < 256; i++)
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
                        FromRGBtoYUV(pxl, out int y, out int u, out int v);

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
                        FromRGBtoYUV(pxl, out int y, out int u, out int v);

                        if (y >= prog)
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
                pictureBoxResult.Image = obrazekCopy;
            }

        }

        private void odejmowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            int szary, szary2, szary3;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out int y, out int u, out int v);
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
                    FromRGBtoYUV(pxl, out int y, out int u, out int v);
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
            MultiProgowaniePopUp multiProgowaniePopUp = new MultiProgowaniePopUp();
            multiProgowaniePopUp.ShowDialog();
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out int y, out int u, out int v);

                    if (y <= progG && y>=progD)
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
            pictureBoxResult.Image = obrazekCopy;


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
                    FromRGBtoYUV(pxl, out int y, out int u, out int v);
                    pxl = Color.FromArgb(y, y, y);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out int y, out int u, out int v);
                    pxl = Color.FromArgb(0, v, u);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void filtracjaLiniowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out int y, out int u, out int v);
                    pxl = Color.FromArgb(v, u, 0);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hSVToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Color pxl;

            pxl = obrazekCopy.GetPixel(1, 1);
            FromRGBtoHSV(pxl, out double hue, out double saturation, out double value);
            HSVLabel.Text = "Hue: " + hue + " Saturation: " + saturation + " Value: " + value;

        }

        private void krawedzieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            int szary, szary2, szary3;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out int y, out int u, out int v);
                    szary = y;

                    int shiftedX = j + 1;
                    if (shiftedX >= szerokosc) shiftedX = szerokosc - 1; 
                    pxl = obrazekCopy2.GetPixel(shiftedX, i);
                    FromRGBtoYUV(pxl, out y, out u, out v);
                    szary2 = y;

                    szary3 = szary - szary2;
                    if (szary3 < 0)
                    {
                        szary3 = 0;
                    }

                    // Ustaw nowy piksel w obrazie wynikowym
                    pxl = Color.FromArgb(szary3, szary3, szary3);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void pionoweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            int szary, szary2, szary3;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out int y, out int u, out int v);
                    szary = y;

                    int shiftedY = i + 1;
                    if (shiftedY >= wysokosc) shiftedY = wysokosc - 1;
                    pxl = obrazekCopy2.GetPixel(j, shiftedY);
                    FromRGBtoYUV(pxl, out y, out u, out v);
                    szary2 = y;

                    szary3 = szary - szary2;
                    if (szary3 < 0)
                    {
                        szary3 = 0;
                    }

                    // Ustaw nowy piksel w obrazie wynikowym
                    pxl = Color.FromArgb(szary3, szary3, szary3);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void ukosneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            int szary, szary2, szary3;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    FromRGBtoYUV(pxl, out int y, out int u, out int v);
                    szary = y;

                    int shiftedX = j + 1;
                    int shiftedY = i + 1;
                    if (shiftedX >= szerokosc) shiftedX = szerokosc - 1;
                    if (shiftedY >= wysokosc) shiftedY = wysokosc - 1;
                    pxl = obrazekCopy2.GetPixel(shiftedX, shiftedY);
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            Color pxl;
            int r1, g1, b1,r2,g2,b2;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    pxl = obrazekCopy.GetPixel(j, i);
                    r1 = pxl.R;
                    g1 = pxl.G;
                    b1 = pxl.B;


                    pxl = obrazekOdejm.GetPixel(j, i);
                    r2 = pxl.R;
                    g2 = pxl.G;
                    b2 = pxl.B;

                    r1 = r1 + r2;
                    g1 = g1 + g2;
                    b1 = b1 + b2;
                    if(r1 > 255)
                    {
                        r1 = 255;
                    }
                    if (g1 > 255)
                    {
                        g1 = 255;
                    }
                    if (b1 > 255)
                    {
                        b1 = 255;
                    }

                    pxl = Color.FromArgb(r1, g1, b1);
                    obrazekCopy.SetPixel(j, i, pxl);
                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }
        public static double[,] HighPassFilter3x3 = new double[,]
        {
            { (-1), (-1), (-1) },
            { (-1),  9, (-1) },
            { (-1), (-1), (-1) }
         };
        public static double[,] LowPassFilter3x3 = new double[,]
       {
            { 1, 1, 1 },
            { 1,  1, 1 },
            { 1, 1, 1 }
        };
        public static double[,] PoziomeFilter3x3 = new double[,]
       {
            { 0, 0, 0 },
            { -1,  1, 0 },
            { 0, 0, 0 }
        };
        public static double[,] PionoweFilter3x3 = new double[,]
      {
            { 0, 0, 0 },
            { -1,  1, 0 },
            { 0, 0, 0 }
       };
        public static double[,] UkosneFilter3x3 = new double[,]
      {
            { -1, 0, 0 },
            { 0,  1, 0 },
            { 0, 0, 0 }
       };
        private void górnoprzepustowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    double rdouble = 0;
                    double gdouble = 0;
                    double bdouble = 0;

                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            int i2 = i + x - 1;
                            int j2 = j + y - 1;

                            if (i2 < 0) i2 = 0;
                            if (i2 >= wysokosc) i2 = wysokosc - 1;
                            if (j2 < 0) j2 = 0;
                            if (j2 >= szerokosc) j2 = szerokosc - 1;

                            pxl = obrazekOrginal.GetPixel(j2, i2);
                            rdouble += (pxl.R * HighPassFilter3x3[x, y]);
                            gdouble += (pxl.G * HighPassFilter3x3[x, y]);
                            bdouble += (pxl.B * HighPassFilter3x3[x, y]);
                        }
                    }           
                    int r = Math.Max(0, Math.Min(255, (int)rdouble));
                    int g = Math.Max(0, Math.Min(255, (int)gdouble));
                    int b = Math.Max(0, Math.Min(255, (int)bdouble));
                    pxl = Color.FromArgb(r, g, b);
                    obrazekCopy.SetPixel(j, i, pxl);

                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void dolnoprzepustowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    double rdouble = 0;
                    double gdouble = 0;
                    double bdouble = 0;

                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            int i2 = i + x - 1;
                            int j2 = j + y - 1;

                            if (i2 < 0) i2 = 0;
                            if (i2 >= wysokosc) i2 = wysokosc - 1;
                            if (j2 < 0) j2 = 0;
                            if (j2 >= szerokosc) j2 = szerokosc - 1;

                            pxl = obrazekOrginal.GetPixel(j2, i2);
                            rdouble += (pxl.R * LowPassFilter3x3[x, y]);
                            gdouble += (pxl.G * LowPassFilter3x3[x, y]);
                            bdouble += (pxl.B * LowPassFilter3x3[x, y]);
                        }
                    }
                    rdouble = rdouble / 9;
                    gdouble = gdouble / 9;
                    bdouble = bdouble / 9;

                    int r = Math.Max(0, Math.Min(255, (int)rdouble));
                    int g = Math.Max(0, Math.Min(255, (int)gdouble));
                    int b = Math.Max(0, Math.Min(255, (int)bdouble));
                    pxl = Color.FromArgb(r, g, b);
                    obrazekCopy.SetPixel(j, i, pxl);

                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void poziomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    double rdouble = 0;
                    double gdouble = 0;
                    double bdouble = 0;

                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            int i2 = i + x - 1;
                            int j2 = j + y - 1;

                            if (i2 < 0) i2 = 0;
                            if (i2 >= wysokosc) i2 = wysokosc - 1;
                            if (j2 < 0) j2 = 0;
                            if (j2 >= szerokosc) j2 = szerokosc - 1;

                            pxl = obrazekOrginal.GetPixel(j2, i2);
                            rdouble += (pxl.R * PoziomeFilter3x3[x, y]);
                            gdouble += (pxl.G * PoziomeFilter3x3[x, y]);
                            bdouble += (pxl.B * PoziomeFilter3x3[x, y]);
                        }
                    }
                    int r = Math.Max(0, Math.Min(255, (int)rdouble));
                    int g = Math.Max(0, Math.Min(255, (int)gdouble));
                    int b = Math.Max(0, Math.Min(255, (int)bdouble));
                    pxl = Color.FromArgb(r, g, b);
                    obrazekCopy.SetPixel(j, i, pxl);

                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void pionoweToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    double rdouble = 0;
                    double gdouble = 0;
                    double bdouble = 0;

                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            int i2 = i + x - 1;
                            int j2 = j + y - 1;

                            if (i2 < 0) i2 = 0;
                            if (i2 >= wysokosc) i2 = wysokosc - 1;
                            if (j2 < 0) j2 = 0;
                            if (j2 >= szerokosc) j2 = szerokosc - 1;

                            pxl = obrazekOrginal.GetPixel(j2, i2);
                            rdouble += (pxl.R * PionoweFilter3x3[x, y]);
                            gdouble += (pxl.G * PionoweFilter3x3[x, y]);
                            bdouble += (pxl.B * PionoweFilter3x3[x, y]);
                        }
                    }
                    int r = Math.Max(0, Math.Min(255, (int)rdouble));
                    int g = Math.Max(0, Math.Min(255, (int)gdouble));
                    int b = Math.Max(0, Math.Min(255, (int)bdouble));
                    pxl = Color.FromArgb(r, g, b);
                    obrazekCopy.SetPixel(j, i, pxl);

                }
            }
            pictureBoxResult.Image = obrazekCopy;
        }

        private void ukośneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pxl;
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    double rdouble = 0;
                    double gdouble = 0;
                    double bdouble = 0;

                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            int i2 = i + x - 1;
                            int j2 = j + y - 1;

                            if (i2 < 0) i2 = 0;
                            if (i2 >= wysokosc) i2 = wysokosc - 1;
                            if (j2 < 0) j2 = 0;
                            if (j2 >= szerokosc) j2 = szerokosc - 1;

                            pxl = obrazekOrginal.GetPixel(j2, i2);
                            rdouble += (pxl.R * UkosneFilter3x3[x, y]);
                            gdouble += (pxl.G * UkosneFilter3x3[x, y]);
                            bdouble += (pxl.B * UkosneFilter3x3[x, y]);
                        }
                    }
                    int r = Math.Max(0, Math.Min(255, (int)rdouble));
                    int g = Math.Max(0, Math.Min(255, (int)gdouble));
                    int b = Math.Max(0, Math.Min(255, (int)bdouble));
                    pxl = Color.FromArgb(r, g, b);
                    obrazekCopy.SetPixel(j, i, pxl);

                }
            }
            pictureBoxResult.Image = obrazekCopy;
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
