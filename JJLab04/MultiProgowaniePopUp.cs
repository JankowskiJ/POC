using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJLab04
{
    public partial class MultiProgowaniePopUp : Form
    {
        public MultiProgowaniePopUp()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String LicznikDolny = LicznikProgDolny.Value.ToString();
            String LicznikGorny = LicznikProgGorny.Value.ToString();
            Form1.progD = Int32.Parse(LicznikDolny);
            Form1.progG = Int32.Parse(LicznikGorny);
            this.Close();
        }
    }
}
