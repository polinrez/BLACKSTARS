using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private double firstArgument, secondArgument;

        private void button3_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            double resultSumm = firstArgument - secondArgument;
            label2.Text = resultSumm.ToString();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            double resultSumm = firstArgument+secondArgument;
            label2.Text = resultSumm.ToString();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            double resultSumm = firstArgument * secondArgument;
            label2.Text = resultSumm.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            double resultSumm = firstArgument / secondArgument;
            label2.Text = resultSumm.ToString();
        }

    }
}
