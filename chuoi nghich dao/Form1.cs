using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuoi_nghich_dao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reverse = new string(nameArray);
            label2.Text = reverse;

            string name1 = textBox2.Text;
            char[] nameArray1 = name1.ToCharArray();
            Array.Reverse(nameArray1);
            string reverse1 = new string(nameArray1);
            label4.Text = reverse1;

            int s = 0;
            int dem = 0;
            while (s <= textBox2.Text.Length - 1)
            {
                if (textBox2.Text[s] == textBox1.Text[0])
                {
                    dem++;
                }
                s++;
            }
            label5.Text = dem.ToString();
        }

        private void đổiMàuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void đổiFontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).Font = fontDialog1.Font;
            }
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
