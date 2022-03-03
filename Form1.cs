using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody4_8_GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            double mocnina = CeleCisla.mocnina(a, b);
            MessageBox.Show("mocnina dvou cisel je: " + mocnina);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int faktorial = CeleCisla.faktorial(8);
            MessageBox.Show("faktorial je: " + faktorial);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int soucetLich = CeleCisla.CifLichSoucet(7584);
            MessageBox.Show("soucet lich cifer je: " + soucetLich);
        }


    }
}
