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
            this.hSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yUVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodaSredniejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zModeluYUVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(545, 70);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(308, 307);
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
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(903, 25);
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "R";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "G";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "B";
            this.toolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hSVToolStripMenuItem,
            this.yUVToolStripMenuItem,
            this.metodaSredniejToolStripMenuItem,
            this.zModeluYUVToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton1.Text = "Lab02";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // hSVToolStripMenuItem
            // 
            this.hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
            this.hSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hSVToolStripMenuItem.Text = "HSV";
            this.hSVToolStripMenuItem.Click += new System.EventHandler(this.hSVToolStripMenuItem_Click);
            // 
            // yUVToolStripMenuItem
            // 
            this.yUVToolStripMenuItem.Name = "yUVToolStripMenuItem";
            this.yUVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yUVToolStripMenuItem.Text = "YUV";
            this.yUVToolStripMenuItem.Click += new System.EventHandler(this.yUVToolStripMenuItem_Click);
            // 
            // metodaSredniejToolStripMenuItem
            // 
            this.metodaSredniejToolStripMenuItem.Name = "metodaSredniejToolStripMenuItem";
            this.metodaSredniejToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.metodaSredniejToolStripMenuItem.Text = "Metoda sredniej";
            this.metodaSredniejToolStripMenuItem.Click += new System.EventHandler(this.metodaSredniejToolStripMenuItem_Click);
            // 
            // zModeluYUVToolStripMenuItem
            // 
            this.zModeluYUVToolStripMenuItem.Name = "zModeluYUVToolStripMenuItem";
            this.zModeluYUVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zModeluYUVToolStripMenuItem.Text = "Z modelu YUV";
            this.zModeluYUVToolStripMenuItem.Click += new System.EventHandler(this.zModeluYUVToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 572);
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
        private System.Windows.Forms.ToolStripMenuItem hSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yUVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodaSredniejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zModeluYUVToolStripMenuItem;
    }
}

