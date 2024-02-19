using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2soAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            lbTong.Visible = true;
            lbHieu.Visible = true;
            lbTich.Visible = true;
            lbThuong.Visible = true;

            int soA, soB, tong, hieu, tich, thuong;
            string a, b, c, d;

            soA = Convert.ToInt32(tbSoa.Text);
            soB = Convert.ToInt32(tbSob.Text);

            tong = soA + soB;
            hieu = soA - soB;
            tich = soA * soB;
            thuong = soA / soB;

            a = Convert.ToString(tong);
            b = Convert.ToString(hieu);
            c = Convert.ToString(tich);
            d = Convert.ToString(thuong);



            lbTong.Text = a;
            lbHieu.Text = b;
            lbTich.Text = c;
            lbThuong.Text = d;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }
    }
}
