using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            lbXinchao.Visible = true;
            //lbXinchao.Text = ( "Xin chào bạn " + tbHoten.Text + " lớp " + tbLop.Text + " :)");
            
            //
            //lấy dữ liệu từ textbox
            string hoten, lop, loichao;
            hoten = tbHoten.Text;
            lop = tbLop.Text;
            //xuất ra lời chào
            loichao = "Xin chào bạn " + hoten + " " + lop;
            lbXinchao.Text = loichao;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
