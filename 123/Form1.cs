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
        double a, b, c, delta, x1, x2;

        private void đổiMàuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void đổiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).Font = fontDialog1.Font;
            }
        }

        private void đổiFontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).Font = fontDialog1.Font;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((TextBox)sender).Text);
            ((TextBox)sender).Text = "";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = Clipboard.GetText();
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);

                if (a == 0)
                {
                    if (b == 0)
                    {
                        label4.Visible = true;
                        label5.Visible = false;
                        label6.Visible = false;
                        label4.Text = "Phương trình vô nghiệm!!";
                    }
                    else
                    {
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = false;
                        label4.Text = "Phương trình có 1 nghiệm duy nhất:";
                        label5.Text = "x = " + (-c) / b;
                    }
                }
                else
                {
                    delta = b * b - 4 * a * c;
                    if (delta > 0)
                    {
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                        x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                        label4.Text = "Phương trình có 2 nghiệm:";
                        label5.Text = "x1 = " + x1;
                        label6.Text = "x2 = " + x2;
                    }
                    else if (delta == 0)
                    {
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = false;
                        label4.Text = "Phương trình có nghiệm kép:";
                        label5.Text = "x = " + (-b) / 2 * a;
                    }
                    else if (delta < 0)
                    {
                        label4.Visible = true;
                        label5.Visible = false;
                        label6.Visible = false;
                        label4.Text = "Phương trình vô nghiệm";
                    }
                }
            }

            catch (FormatException)
            {
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                label4.Text = "Nhập sai số!!";
                //MessageBox.Show("Nhập sai số!!");
            }

        }
    }
}
