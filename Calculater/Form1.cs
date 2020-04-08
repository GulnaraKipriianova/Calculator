using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculater.Calc;

namespace Calculater
{
    public partial class Form1 : Form
    {
        double tmp1, tmp2;
        bool znak = true;
        int coint;
        ICalc Calc;
        public Form1()
        {
            InitializeComponent();
        }
        private void AddToText(string a)
        {
            textBox1.Text += a;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            AddToText("0");
        }
        private void number1_Click(object sender, EventArgs e)
        {   AddToText("1"); }
        private void number2_Click(object sender, EventArgs e)
        {   AddToText("2");  }
        private void number3_Click(object sender, EventArgs e)
        {   AddToText("3");  }
        private void number4_Click(object sender, EventArgs e)
        {   AddToText("4");   }
        private void number5_Click(object sender, EventArgs e)
        {   AddToText("5");  }
        private void number6_Click(object sender, EventArgs e)
        {  AddToText("6"); }
        private void number7_Click(object sender, EventArgs e)
        {  AddToText("7");}
        private void number8_Click(object sender, EventArgs e)
        {  AddToText("8"); }
        private void number9_Click(object sender, EventArgs e)
        { AddToText("9"); }
        private void Form1_Load(object sender, EventArgs e)
        {
            tmp1 = 0;
            tmp2 = 0;
            Calc = null;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));
                }
                else
                { 
                    tmp1 = Convert.ToDouble(textBox1.Text); 
                }
                coint = 0;
                znak = true;
                textBox2.Text = tmp1 + "+";
                textBox1.Text = "";
                Calc = new Adder();
            }
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));
                }
                else
                { 
                    tmp1 = Convert.ToDouble(textBox1.Text); 
                }
                textBox2.Text = tmp1 + "-";
                textBox1.Text = "";
                coint = 0;
                znak = true;
                Calc = new Substr();
            }
        }
        private void multipic_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));
                }
                else
                { 
                    tmp1 = Convert.ToDouble(textBox1.Text);
                }
                textBox1.Text = "";
                textBox2.Text = tmp1 + "*";
                coint = 0;
                znak = true;
                Calc = new Multipl();
            }
        }
        private void division_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));
                }
                else
                {
                    tmp1 = Convert.ToDouble(textBox1.Text);
                }
                textBox1.Text = "";
                textBox2.Text = tmp1 + "/";
                coint = 1;
                znak = true;
                Calc = new Divis();
            }
        }

        private void chaingeSign_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0,";
            }
            if (textBox1.Text.IndexOf(",") == -1)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void eqally_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && Calc!=null)
            {
                tmp2 = Convert.ToDouble(textBox1.Text);
                if (coint == 1)
                {
                    if (tmp2 == 0.0)
                    { textBox1.Text = "Деление на 0! "; }
                    else
                    {
                        textBox1.Text = Calc.DoMath(tmp1, tmp2) + "";
                        tmp1 = Convert.ToDouble(textBox1.Text);
                        Calc = null;
                    }
                }
                else
                {
                    textBox1.Text = Calc.DoMath(tmp1, tmp2) + "";
                    tmp1 = Convert.ToDouble(textBox1.Text);
                    Calc = null;
                }    
                    
            }
        }
    }
}
