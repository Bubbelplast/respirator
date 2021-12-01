using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string mode = "";
        double lastNumber = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Button buttonCliked = (Button)sender;

            textBox1.Text += buttonCliked.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button buttonCliked = (Button)sender;

            mode = buttonCliked.Text;
            double.TryParse(textBox1.Text, out lastNumber);
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double temporaryNumber = 0;
            double.TryParse(textBox1.Text, out temporaryNumber);

            if (mode == "+")
            {
                textBox1.Text = (lastNumber + temporaryNumber).ToString();
            }
            else if(mode == "-")
            {
                textBox1.Text = (lastNumber - temporaryNumber).ToString();
            }
            else if (mode == "/")
            {
                textBox1.Text = (lastNumber / temporaryNumber).ToString();
            }
            else if (mode == "*")
            {
                textBox1.Text = (lastNumber * temporaryNumber).ToString();
            }
            else if (mode == "x^x")
            {
                textBox1.Text = Math.Pow(lastNumber, temporaryNumber).ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mode = "";
            lastNumber = 0;
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double temporaryNumber = 0;
            double.TryParse(textBox1.Text, out temporaryNumber);

            textBox1.Text = Math.Sqrt(temporaryNumber).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double temporaryNumber = 0;
            double.TryParse(textBox1.Text, out temporaryNumber);

            textBox1.Text = (temporaryNumber * temporaryNumber).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 2);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 2), 10);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 16);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 16), 10);
        }
    }
}
