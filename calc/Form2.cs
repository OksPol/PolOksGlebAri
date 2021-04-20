using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double a, b;
        int count;
        bool znak = true;
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = Math.Sqrt(Convert.ToDouble(a));
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = Math.Pow(Convert.ToDouble(a),2);
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    b = Math.Sin(Convert.ToDouble(a));
                    textBox1.Text = b.ToString();
                    break;
                case 8:
                    b = Math.Cos(Convert.ToDouble(a));
                    textBox1.Text = b.ToString();
                    break;
                case 9:
                    b = Math.Tan(Convert.ToDouble(a));
                    textBox1.Text = b.ToString();
                    break;
                case 10:
                    b = Math.Log(Convert.ToDouble(a));
                    textBox1.Text = b.ToString();
                    break;
                case 11:
                    b = Math.Log(Convert.ToDouble(a),Math.E);
                    textBox1.Text = b.ToString();
                    break;
                case 12:
                    b = Math.Abs(Convert.ToDouble(a));
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = "√" + a.ToString() ;
            znak = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6;
            label1.Text = a.ToString() + "^2";
            znak = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 7;
            label1.Text = "sin (" + a.ToString() + ")" ;
            znak = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 8;
            label1.Text = "cos (" + a.ToString() + ")";
            znak = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 9;
            label1.Text = "tg (" + a.ToString() + ")";
            znak = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 10;
            label1.Text = "log (" + a.ToString() + ")";
            znak = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 11;
            label1.Text = "ln (" + a.ToString() + ")";
            znak = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 12;
            label1.Text = " |" + a.ToString() + "|";
            znak = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form f3 = new Form1();

            f3.Show();
            button17.Enabled = false;
            this.Visible = false;
        }
    }
}
