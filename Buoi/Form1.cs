using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi
{
    public partial class Form1 : Form
    {
        string chuoiketnoi = "Data Source = DESKTOP-5PPE1HH; Initial Catalog = MuonTraSach; Integrated Security = True";
        SqlConnection conn = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql = "Select * from SV";
            SqlDataAdapter daSV = new SqlDataAdapter(sql, conn);
            DataTable dtSV = new DataTable();
            daSV.Fill(dtSV);
            //dataGridView1.DataSource = dtSV;

            SqlDataAdapter daSach = new SqlDataAdapter("SELECT * FROM Sach", conn);
            DataTable dtSach = new DataTable();
            daSach.Fill(dtSach);
            dataGridView1.DataSource = dtSach;

            string sql1 = "Select * from MuonSach";
            SqlDataAdapter daMuonSach = new SqlDataAdapter(sql1, conn);
            DataTable dtMuonSach = new DataTable();
            daMuonSach.Fill(dtMuonSach);
            dataGridView2.DataSource = dtMuonSach;

            //SqlDataAdapter daMuonSach = new SqlDataAdapter("SELECT * FROM MuonSach", conn);
            //DataTable dtMuonSach = new DataTable();
            //daMuonSach.Fill(dtMuonSach);

            comboBox1.DataSource = dtSV;
            comboBox1.DisplayMember = "hoten";
            //comboBox1.ValueMember = "stt";

            comboBox2.DataSource = dtSach;
            comboBox2.DisplayMember = "tensach";
            //comboBox2.ValueMember = "stt";

            comboBox3.DataSource = dtMuonSach;
            comboBox3.DisplayMember = "ngaymuon";
            //comboBox3.ValueMember = "stt";

            comboBox4.DataSource = dtMuonSach;
            comboBox4.DisplayMember = "ngaytra";
            //comboBox1.ValueMember = "stt";

            //comboBox5.DataSource = dtLoaiSach;
            //comboBox5.DisplayMember = "thanhtien";
            //comboBox1.ValueMember = "stt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Sach values('" + textBox1.Text + "',N'" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into MuonSach (hoten, tensach, ngaymuon, ngaytra, thanhtien) values('" + comboBox1.Text + "',N'" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "', '0');";
            //cmd.CommandText = "insert into MuonSach (hoten, tensach, ngaymuon, ngaytra, thanhtien) values('" + comboBox1.Text + "',N'" + comboBox2.Text + "','" + comboBox3.Text + "', DATEADD(day, 40," + comboBox3.Text + "), '0');";
            //cmd.CommandText = "insert into MuonSach (ngaytra) select DATEADD(day, 40," + comboBox3.Text + ");";
            //cmd.CommandText = "insert into MuonSach (hoten) select * from SV where hoten = " + comboBox3.Text ;
            cmd.ExecuteNonQuery();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql1 = "Select * from MuonSach";
            SqlDataAdapter daMuonSach = new SqlDataAdapter(sql1, conn);
            DataTable dtMuonSach = new DataTable();
            daMuonSach.Fill(dtMuonSach);
            dataGridView2.DataSource = dtMuonSach;

            int row = e.RowIndex;
            if (row >= 0)
            {
                comboBox1.Text = dataGridView2.Rows[row].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView2.Rows[row].Cells[2].Value.ToString();
                comboBox3.Text = dataGridView2.Rows[row].Cells[3].Value.ToString();
                comboBox4.Text = dataGridView2.Rows[row].Cells[4].Value.ToString();
            }
        }
    }
}
