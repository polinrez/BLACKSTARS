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

        private void Operating(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);

            ICalculator calculator = Factory.CreateCalculator(((Button) sender).Name);
            double result = calculator.Calculate(firstArgument, secondArgument);
            label2.Text = result.ToString();
        }

        private void OneClick(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
       
            IOneCalculator calculator = OneFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstArgument);
            label2.Text = result.ToString();
        }
    }
}
