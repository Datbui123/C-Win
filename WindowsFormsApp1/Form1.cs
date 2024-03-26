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
        int tuoi;
        string tuoi1;
        private Button previousButton = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Orange;
            Button cuButton = (Button)sender;
            
            if (cuButton==btThem)
            {
                btThem.BackColor = Color.Transparent;
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    dataGridView1.Rows.Add(previousButton.Text, textBox1.Text, tuoi1, textBox3.Text);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!!");
                }
                previousButton.BackColor = Color.Red;
                textBox1.Text = "";
                numericUpDown1.Text = "";
                textBox3.Text = "";
            }
            else
            {
                previousButton = cuButton;
            }
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Changed(object sender, EventArgs e)
        {
            textBox3.Text = "50.000VNĐ";
            tuoi = Convert.ToInt32(numericUpDown1.Text);
            if (tuoi >= 50)
            {
                textBox3.Text = "25.000NVĐ";
            }
            else if (tuoi < 18)
            {
                textBox3.Text = "40.000NVĐ";
            }
            tuoi1 = Convert.ToString(tuoi);
        }
    }
}
