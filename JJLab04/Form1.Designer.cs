﻿namespace JJLab04
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Wgraj = new System.Windows.Forms.Button();
            this.Zeruj = new System.Windows.Forms.Button();
            this.Zapisz = new System.Windows.Forms.Button();
            this.ResetT = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuLab01 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.metodaSredniejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zModeluYUVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yUVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.progowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiProgowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.odejmowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krawedzieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pionoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukosneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab05 = new System.Windows.Forms.ToolStripDropDownButton();
            this.filtracjaLiniowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.górnoprzepustowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolnoprzepustowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poziomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pionoweToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ukośneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureButton3 = new System.Windows.Forms.Button();
            this.pictureBoxOdejm = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HSVLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.filtracjaNieliniowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdejm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(426, 70);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(427, 307);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 0;
            this.pictureBoxResult.TabStop = false;
            this.pictureBoxResult.Click += new System.EventHandler(this.pictureBoxResult_Click);
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(77, 70);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(308, 307);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 1;
            this.pictureBoxOriginal.TabStop = false;
            this.pictureBoxOriginal.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Obraz bazowy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Obraz wynikowy";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Wgraj
            // 
            this.Wgraj.Location = new System.Drawing.Point(77, 383);
            this.Wgraj.Name = "Wgraj";
            this.Wgraj.Size = new System.Drawing.Size(75, 23);
            this.Wgraj.TabIndex = 5;
            this.Wgraj.Text = "wgraj";
            this.Wgraj.UseVisualStyleBackColor = true;
            this.Wgraj.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Zeruj
            // 
            this.Zeruj.Location = new System.Drawing.Point(169, 383);
            this.Zeruj.Name = "Zeruj";
            this.Zeruj.Size = new System.Drawing.Size(75, 23);
            this.Zeruj.TabIndex = 6;
            this.Zeruj.Text = "Zeruj";
            this.Zeruj.UseVisualStyleBackColor = true;
            this.Zeruj.Click += new System.EventHandler(this.Zeruj_Click);
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(77, 425);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(75, 23);
            this.Zapisz.TabIndex = 7;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // ResetT
            // 
            this.ResetT.Location = new System.Drawing.Point(169, 425);
            this.ResetT.Name = "ResetT";
            this.ResetT.Size = new System.Drawing.Size(75, 23);
            this.ResetT.TabIndex = 8;
            this.ResetT.Text = "Reset";
            this.ResetT.UseVisualStyleBackColor = true;
            this.ResetT.Click += new System.EventHandler(this.Reset_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLab01,
            this.toolStripButton1,
            this.toolStripSplitButton1,
            this.toolStripDropDownButton1,
            this.lab05,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1302, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MenuLab01
            // 
            this.MenuLab01.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuLab01.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.MenuLab01.Image = ((System.Drawing.Image)(resources.GetObject("MenuLab01.Image")));
            this.MenuLab01.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuLab01.Name = "MenuLab01";
            this.MenuLab01.Size = new System.Drawing.Size(51, 22);
            this.MenuLab01.Text = "Lab01";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItem1.Text = "R";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItem2.Text = "G";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItem3.Text = "B";
            this.toolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodaSredniejToolStripMenuItem,
            this.zModeluYUVToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.yUVToolStripMenuItem,
            this.hSVToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton1.Text = "Lab02";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // metodaSredniejToolStripMenuItem
            // 
            this.metodaSredniejToolStripMenuItem.Name = "metodaSredniejToolStripMenuItem";
            this.metodaSredniejToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.metodaSredniejToolStripMenuItem.Text = "Metoda sredniej";
            this.metodaSredniejToolStripMenuItem.Click += new System.EventHandler(this.metodaSredniejToolStripMenuItem_Click);
            // 
            // zModeluYUVToolStripMenuItem
            // 
            this.zModeluYUVToolStripMenuItem.Name = "zModeluYUVToolStripMenuItem";
            this.zModeluYUVToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.zModeluYUVToolStripMenuItem.Text = "Z modelu YUV";
            this.zModeluYUVToolStripMenuItem.Click += new System.EventHandler(this.zModeluYUVToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // yUVToolStripMenuItem
            // 
            this.yUVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yToolStripMenuItem,
            this.uToolStripMenuItem,
            this.vToolStripMenuItem});
            this.yUVToolStripMenuItem.Name = "yUVToolStripMenuItem";
            this.yUVToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.yUVToolStripMenuItem.Text = "YUV";
            // 
            // yToolStripMenuItem
            // 
            this.yToolStripMenuItem.Name = "yToolStripMenuItem";
            this.yToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.yToolStripMenuItem.Text = "Y";
            this.yToolStripMenuItem.Click += new System.EventHandler(this.yToolStripMenuItem_Click);
            // 
            // uToolStripMenuItem
            // 
            this.uToolStripMenuItem.Name = "uToolStripMenuItem";
            this.uToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.uToolStripMenuItem.Text = "U";
            this.uToolStripMenuItem.Click += new System.EventHandler(this.uToolStripMenuItem_Click);
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.vToolStripMenuItem.Text = "V";
            this.vToolStripMenuItem.Click += new System.EventHandler(this.vToolStripMenuItem_Click);
            // 
            // hSVToolStripMenuItem
            // 
            this.hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
            this.hSVToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.hSVToolStripMenuItem.Text = "HSV";
            this.hSVToolStripMenuItem.Click += new System.EventHandler(this.hSVToolStripMenuItem_Click_1);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progowanieToolStripMenuItem,
            this.multiProgowanieToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripSplitButton1.Text = "Lab03";
            // 
            // progowanieToolStripMenuItem
            // 
            this.progowanieToolStripMenuItem.Name = "progowanieToolStripMenuItem";
            this.progowanieToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.progowanieToolStripMenuItem.Text = "Progowanie";
            this.progowanieToolStripMenuItem.Click += new System.EventHandler(this.progowanieToolStripMenuItem_Click);
            // 
            // multiProgowanieToolStripMenuItem
            // 
            this.multiProgowanieToolStripMenuItem.Name = "multiProgowanieToolStripMenuItem";
            this.multiProgowanieToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.multiProgowanieToolStripMenuItem.Text = "MultiProgowanie";
            this.multiProgowanieToolStripMenuItem.Click += new System.EventHandler(this.multiProgowanieToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odejmowanieToolStripMenuItem,
            this.krawedzieToolStripMenuItem,
            this.pionoweToolStripMenuItem,
            this.ukosneToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripDropDownButton1.Text = "lab04";
            // 
            // odejmowanieToolStripMenuItem
            // 
            this.odejmowanieToolStripMenuItem.Name = "odejmowanieToolStripMenuItem";
            this.odejmowanieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.odejmowanieToolStripMenuItem.Text = "Odejmowanie";
            this.odejmowanieToolStripMenuItem.Click += new System.EventHandler(this.odejmowanieToolStripMenuItem_Click);
            // 
            // krawedzieToolStripMenuItem
            // 
            this.krawedzieToolStripMenuItem.Name = "krawedzieToolStripMenuItem";
            this.krawedzieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.krawedzieToolStripMenuItem.Text = "Poziome";
            this.krawedzieToolStripMenuItem.Click += new System.EventHandler(this.krawedzieToolStripMenuItem_Click);
            // 
            // pionoweToolStripMenuItem
            // 
            this.pionoweToolStripMenuItem.Name = "pionoweToolStripMenuItem";
            this.pionoweToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.pionoweToolStripMenuItem.Text = "Pionowe";
            this.pionoweToolStripMenuItem.Click += new System.EventHandler(this.pionoweToolStripMenuItem_Click);
            // 
            // ukosneToolStripMenuItem
            // 
            this.ukosneToolStripMenuItem.Name = "ukosneToolStripMenuItem";
            this.ukosneToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ukosneToolStripMenuItem.Text = "Ukosne";
            this.ukosneToolStripMenuItem.Click += new System.EventHandler(this.ukosneToolStripMenuItem_Click);
            // 
            // lab05
            // 
            this.lab05.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lab05.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtracjaLiniowaToolStripMenuItem});
            this.lab05.Image = ((System.Drawing.Image)(resources.GetObject("lab05.Image")));
            this.lab05.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lab05.Name = "lab05";
            this.lab05.Size = new System.Drawing.Size(48, 22);
            this.lab05.Text = "lab05";
            this.lab05.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // filtracjaLiniowaToolStripMenuItem
            // 
            this.filtracjaLiniowaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.górnoprzepustowyToolStripMenuItem,
            this.dolnoprzepustowyToolStripMenuItem,
            this.poziomeToolStripMenuItem,
            this.pionoweToolStripMenuItem1,
            this.ukośneToolStripMenuItem});
            this.filtracjaLiniowaToolStripMenuItem.Name = "filtracjaLiniowaToolStripMenuItem";
            this.filtracjaLiniowaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filtracjaLiniowaToolStripMenuItem.Text = "Filtracja Liniowa";
            this.filtracjaLiniowaToolStripMenuItem.Click += new System.EventHandler(this.filtracjaLiniowaToolStripMenuItem_Click);
            // 
            // górnoprzepustowyToolStripMenuItem
            // 
            this.górnoprzepustowyToolStripMenuItem.Name = "górnoprzepustowyToolStripMenuItem";
            this.górnoprzepustowyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.górnoprzepustowyToolStripMenuItem.Text = "górnoprzepustowy";
            this.górnoprzepustowyToolStripMenuItem.Click += new System.EventHandler(this.górnoprzepustowyToolStripMenuItem_Click);
            // 
            // dolnoprzepustowyToolStripMenuItem
            // 
            this.dolnoprzepustowyToolStripMenuItem.Name = "dolnoprzepustowyToolStripMenuItem";
            this.dolnoprzepustowyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dolnoprzepustowyToolStripMenuItem.Text = "dolnoprzepustowy";
            this.dolnoprzepustowyToolStripMenuItem.Click += new System.EventHandler(this.dolnoprzepustowyToolStripMenuItem_Click);
            // 
            // poziomeToolStripMenuItem
            // 
            this.poziomeToolStripMenuItem.Name = "poziomeToolStripMenuItem";
            this.poziomeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poziomeToolStripMenuItem.Text = "poziome";
            this.poziomeToolStripMenuItem.Click += new System.EventHandler(this.poziomeToolStripMenuItem_Click);
            // 
            // pionoweToolStripMenuItem1
            // 
            this.pionoweToolStripMenuItem1.Name = "pionoweToolStripMenuItem1";
            this.pionoweToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pionoweToolStripMenuItem1.Text = "pionowe ";
            this.pionoweToolStripMenuItem1.Click += new System.EventHandler(this.pionoweToolStripMenuItem1_Click);
            // 
            // ukośneToolStripMenuItem
            // 
            this.ukośneToolStripMenuItem.Name = "ukośneToolStripMenuItem";
            this.ukośneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ukośneToolStripMenuItem.Text = "ukośne";
            this.ukośneToolStripMenuItem.Click += new System.EventHandler(this.ukośneToolStripMenuItem_Click);
            // 
            // PictureButton3
            // 
            this.PictureButton3.BackColor = System.Drawing.SystemColors.Control;
            this.PictureButton3.Location = new System.Drawing.Point(462, 425);
            this.PictureButton3.Name = "PictureButton3";
            this.PictureButton3.Size = new System.Drawing.Size(148, 23);
            this.PictureButton3.TabIndex = 13;
            this.PictureButton3.Text = "Wgraj Dodatkowy obraz";
            this.PictureButton3.UseVisualStyleBackColor = false;
            this.PictureButton3.Click += new System.EventHandler(this.PictureButton3_Click);
            // 
            // pictureBoxOdejm
            // 
            this.pictureBoxOdejm.Location = new System.Drawing.Point(616, 383);
            this.pictureBoxOdejm.Name = "pictureBoxOdejm";
            this.pictureBoxOdejm.Size = new System.Drawing.Size(170, 128);
            this.pictureBoxOdejm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOdejm.TabIndex = 14;
            this.pictureBoxOdejm.TabStop = false;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(881, 70);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Szarosc";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(373, 307);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // HSVLabel
            // 
            this.HSVLabel.AutoSize = true;
            this.HSVLabel.Location = new System.Drawing.Point(830, 414);
            this.HSVLabel.Name = "HSVLabel";
            this.HSVLabel.Size = new System.Drawing.Size(0, 13);
            this.HSVLabel.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Dodawanie obrazków";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtracjaNieliniowaToolStripMenuItem});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton2.Text = "lab06";
            // 
            // filtracjaNieliniowaToolStripMenuItem
            // 
            this.filtracjaNieliniowaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medianaToolStripMenuItem,
            this.maxToolStripMenuItem,
            this.minToolStripMenuItem});
            this.filtracjaNieliniowaToolStripMenuItem.Name = "filtracjaNieliniowaToolStripMenuItem";
            this.filtracjaNieliniowaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filtracjaNieliniowaToolStripMenuItem.Text = "Filtracja Nieliniowa";
            // 
            // medianaToolStripMenuItem
            // 
            this.medianaToolStripMenuItem.Name = "medianaToolStripMenuItem";
            this.medianaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medianaToolStripMenuItem.Text = "Mediana";
            this.medianaToolStripMenuItem.Click += new System.EventHandler(this.medianaToolStripMenuItem_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maxToolStripMenuItem.Text = "Max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.maxToolStripMenuItem_Click);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minToolStripMenuItem.Text = "Min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.minToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1168, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Jakub Jankowski 29928\r\nINF 2 L04\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1302, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HSVLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBoxOdejm);
            this.Controls.Add(this.PictureButton3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ResetT);
            this.Controls.Add(this.Zapisz);
            this.Controls.Add(this.Zeruj);
            this.Controls.Add(this.Wgraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.pictureBoxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdejm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Wgraj;
        private System.Windows.Forms.Button Zeruj;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Button ResetT;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton MenuLab01;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem metodaSredniejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zModeluYUVToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem odejmowanieToolStripMenuItem;
        private System.Windows.Forms.Button PictureButton3;
        private System.Windows.Forms.PictureBox pictureBoxOdejm;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem progowanieToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiProgowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton lab05;
        private System.Windows.Forms.ToolStripMenuItem yUVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtracjaLiniowaToolStripMenuItem;
        private System.Windows.Forms.Label HSVLabel;
        private System.Windows.Forms.ToolStripMenuItem krawedzieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pionoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukosneToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem górnoprzepustowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolnoprzepustowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poziomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pionoweToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ukośneToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem filtracjaNieliniowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

