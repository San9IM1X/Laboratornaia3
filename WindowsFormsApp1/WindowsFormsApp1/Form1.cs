using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox2.Text);
            textBox4.Text = "Результат работы программы" + Environment.NewLine;
            textBox4.Text += " При X = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += " При Y = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += " При Z = " + textBox3.Text + Environment.NewLine;
            double p;
            p = (Math.Abs(Math.Min(x * x, y) - Math.Max(y, z))) / 2;
            textBox4.Text += " p = " + p.ToString() + Environment.NewLine;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
