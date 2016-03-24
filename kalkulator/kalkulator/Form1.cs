using System;
using System.Windows.Forms;
using kalkulator.OneArgument;
using kalkulator.TwoArgument;

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
