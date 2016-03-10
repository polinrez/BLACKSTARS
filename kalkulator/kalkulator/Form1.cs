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

            double result;

            switch (((Button)sender).Name)
            {
                case "button1": 
                   result = firstArgument + secondArgument;
                    break;
                case "button2":
                    result = firstArgument * secondArgument;
                    break;
                case "button3":
                    result = firstArgument - secondArgument;
                    break;
                case "button4":
                    result = firstArgument / secondArgument;
                    break;
                default :
                    throw new Exception("Неизвестная операция");

            }
            
            label2.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
  
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

    }
}
