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

        string input = "";
        string chislo1 = "";
        string chislo2 = "";
        char operaciq;
        double krainoChislo = 0.0;

        private void edno_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "1";
            textBox1.Text += input;
        }

        private void dve_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "2";
            textBox1.Text += input;
        }

        private void tri_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "3";
            textBox1.Text += input;
        }

        private void cheteri_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "4";
            textBox1.Text += input;
        }

        private void pet_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "5";
            textBox1.Text += input;
        }

        private void shest_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "6";
            textBox1.Text += input;
        }

        private void sedem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "7";
            textBox1.Text += input;
        }

        private void osem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "8";
            textBox1.Text += input;
        }

        private void devet_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "9";
            textBox1.Text += input;
        }

        private void nula_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "0";
            textBox1.Text += input;
        }

        private void ce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = "";
            chislo1 = "";
            chislo2 = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            chislo1 = input;
            operaciq = '+';
            input = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            chislo1 = input;
            operaciq = '-';
            input = "";
        }

        private void delenie_Click(object sender, EventArgs e)
        {
            chislo1 = input;
            operaciq = '/';
            input = "";
        }

        private void po_Click(object sender, EventArgs e)
        {
            chislo1 = input;
            operaciq = '*';
            input = "";
        }

        private void ravno_Click(object sender, EventArgs e)
        {
            chislo2 = input;
            double ch1, ch2;
            double.TryParse(chislo1, out ch1);
            double.TryParse(chislo2, out ch2);

            if (operaciq == '+')
            {
                krainoChislo = ch1 + ch2;
                textBox1.Text = krainoChislo.ToString();
            }
            else if (operaciq == '-')
            {
                krainoChislo = ch1 - ch2;
                textBox1.Text = krainoChislo.ToString();
            }
            else if (operaciq == '*')
            {
                krainoChislo = ch1 * ch2;
                textBox1.Text = krainoChislo.ToString();
            }
            else if (operaciq == '/')
            {
                if (ch2 == 0)
                {
                    textBox1.Text = "На 0 не се дели";
                }
                else
                {
                    krainoChislo = ch1 / ch2;
                    textBox1.Text = krainoChislo.ToString();
                }
            }
        }
        
    }
}
