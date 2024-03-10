using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double num1;
        string dem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

            textBox1.Text += ((Button)sender).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dem = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dem = "-";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dem = "*";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text + "*";
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dem = "/";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double num2, kq;

            num2 = Convert.ToDouble(textBox1.Text);

            if (dem == "+")
            {
                kq = (num1 + num2);
                textBox1.Text = Convert.ToString(kq);
                textBox2.Text = "";
            }
            if (dem == "-")
            {
                kq = (num1 - num2);
                textBox1.Text = Convert.ToString(kq);
                textBox2.Text = "";
            }
            if (dem == "*")
            {
                kq = (num1 * num2);
                textBox1.Text = Convert.ToString(kq);
                textBox2.Text = "";
            }
            if (dem == "/")
            {
                if (num2 == 0)
                {
                    textBox1.Text = "Can't divide by 0";
                    textBox2.Text = "";

                }
                else
                {
                    kq = (num1 / num2);
                    textBox1.Text = Convert.ToString(kq);
                    textBox2.Text = "";
                }
            }
        }
        private void ariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            button9.BackColor = Color.Red;
            button10.BackColor = Color.Red;
            button11.BackColor = Color.Red;
            button12.BackColor = Color.Red;
            button13.BackColor = Color.Red;
            button14.BackColor = Color.Red;
            button15.BackColor = Color.Red;
            button16.BackColor = Color.Red;
        }

        private void xanhLáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Green;
            button9.BackColor = Color.Green;
            button10.BackColor = Color.Green;
            button11.BackColor = Color.Green;
            button12.BackColor = Color.Green;
            button13.BackColor = Color.Green;
            button14.BackColor = Color.Green;
            button15.BackColor = Color.Green;
            button16.BackColor = Color.Green;
        }

        private void xanhDươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button7.BackColor = Color.Transparent;
            button8.BackColor = Color.Transparent;
            button9.BackColor = Color.Transparent;
            button10.BackColor = Color.Transparent;
            button11.BackColor = Color.Transparent;
            button12.BackColor = Color.Transparent;
            button13.BackColor = Color.Transparent;
            button14.BackColor = Color.Transparent;
            button15.BackColor = Color.Transparent;
            button16.BackColor = Color.Transparent;
        }

        private void tahomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button2.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button3.Font = new Font("Tahoma", 12, FontStyle.Regular);
            //button2.Font = new Font("Tahoma", 12, FontStyle.Bold);
            //button3.Font = new Font("Tahoma", 12, FontStyle.Italic);
            button4.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button5.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button6.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button7.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button8.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button9.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button10.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button11.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button12.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button13.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button14.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button15.Font = new Font("Tahoma", 12, FontStyle.Regular);
            button16.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }

        private void timesNewRomansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button2.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button3.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button4.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button5.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button6.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button7.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button8.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button9.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button10.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button11.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button12.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button13.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button14.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button15.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button16.Font = new Font("Times New Roman", 12, FontStyle.Regular);
        }

        private void mặcĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button3.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button4.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button5.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button6.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button7.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button8.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button9.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button10.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button11.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button12.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button13.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button14.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button15.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            button16.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
        }
    }
}
