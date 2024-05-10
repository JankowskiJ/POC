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
    public partial class ProgowaniePopUp : Form
    {
        public ProgowaniePopUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Licznik = LicznikProg.Value.ToString();
            Form1.prog = Int32.Parse(Licznik);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.isAtuomatic = true;
            this.Close();
        }
    }
}
