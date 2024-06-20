namespace JJLab04
{
    partial class MultiProgowaniePopUp
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LicznikProgDolny = new System.Windows.Forms.NumericUpDown();
            this.LicznikProgGorny = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LicznikProgDolny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicznikProgGorny)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prześlij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Podaj próg dolny i górny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dolny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Górny";
            // 
            // LicznikProgDolny
            // 
            this.LicznikProgDolny.Location = new System.Drawing.Point(51, 77);
            this.LicznikProgDolny.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LicznikProgDolny.Name = "LicznikProgDolny";
            this.LicznikProgDolny.Size = new System.Drawing.Size(120, 20);
            this.LicznikProgDolny.TabIndex = 8;
            // 
            // LicznikProgGorny
            // 
            this.LicznikProgGorny.Location = new System.Drawing.Point(214, 77);
            this.LicznikProgGorny.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LicznikProgGorny.Name = "LicznikProgGorny";
            this.LicznikProgGorny.Size = new System.Drawing.Size(120, 20);
            this.LicznikProgGorny.TabIndex = 9;
            this.LicznikProgGorny.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // MultiProgowaniePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 166);
            this.Controls.Add(this.LicznikProgGorny);
            this.Controls.Add(this.LicznikProgDolny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "MultiProgowaniePopUp";
            this.Text = "Class1";
            ((System.ComponentModel.ISupportInitialize)(this.LicznikProgDolny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicznikProgGorny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown LicznikProgDolny;
        private System.Windows.Forms.NumericUpDown LicznikProgGorny;
    }
}