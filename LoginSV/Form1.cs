using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginSV
{
    public partial class Form1 : Form
    {
        string a, b, d, h, f, g;
        private List<string[]> data = new List<string[]>();
        string chuoiketnoi = "Data Source = DESKTOP-5PPE1HH; Initial Catalog = LoginSV; Integrated Security = True";
        //SqlConnection conn = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            //conn = new SqlConnection(chuoiketnoi);
            //conn.Open();
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedRow.Cells["cl1"].Value.ToString();
                textBox2.Text = selectedRow.Cells["cl2"].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells["cl3"].Value.ToString();
                if (selectedRow.Cells["cl4"].Value == radioButton1.Text)
                {
                    radioButton1.Checked = true;
                }
                if (selectedRow.Cells["cl4"].Value == radioButton2.Text)
                {
                    radioButton2.Checked = true;
                }
                comboBox2.Text = selectedRow.Cells["cl5"].Value.ToString();
                comboBox3.Text = selectedRow.Cells["cl6"].Value.ToString();
                comboBox4.Text = selectedRow.Cells["cl7"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && radioButton1.Checked || radioButton2.Checked && !string.IsNullOrWhiteSpace(comboBox2.Text) && !string.IsNullOrWhiteSpace(comboBox3.Text) && !string.IsNullOrWhiteSpace(comboBox4.Text))
            {
                a = textBox1.Text;
                b = textBox2.Text;
                //c = dateTimePicker1.Value;
                h = comboBox2.Text;
                f = comboBox3.Text;
                g = comboBox4.Text;
                if (radioButton1.Checked)
                {
                    d = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    d = radioButton2.Text;
                }
                dataGridView1.Rows.Add(a, b, dateTimePicker1.Value, d, h, f, g);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["cl1"].Value = textBox1.Text;
                selectedRow.Cells["cl2"].Value = textBox2.Text;
                selectedRow.Cells["cl3"].Value = dateTimePicker1.Text;
                if (radioButton1.Checked = true)
                {
                    selectedRow.Cells["cl4"].Value = radioButton1.Text;
                }
                if (radioButton2.Checked = true)
                {
                    selectedRow.Cells["cl4"].Value = radioButton2.Text;
                }
                //selectedRow.Cells["cl4"].Value = radioButton1.Text;
                selectedRow.Cells["cl5"].Value = comboBox2.Text;
                selectedRow.Cells["cl6"].Value = comboBox3.Text;
                selectedRow.Cells["cl7"].Value = comboBox4.Text;
            }
            else
            {
                MessageBox.Show("Chọn 1 hàng");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(selectedRow);
            }    
        }
    }
}
