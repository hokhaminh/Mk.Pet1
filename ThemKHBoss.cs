using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mk.Pet1
{
    public partial class ThemKHBoss : Form
    {
        public ThemKHBoss()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=LDTHIEN-SM\THIENDTRAI;Initial Catalog=MKPet;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlDataReader docdulieu;
        SqlCommand thuchien;
        int i = 0;
        private void btnTao_Click(object sender, EventArgs e)
        {
            if (txtsdt.Text == "")
            {
                MessageBox.Show("Hãy nhập tên tài khoản");
                txtsdt.Focus();
                return;
            }

            if (txttenkh.Text == "")
            {
                MessageBox.Show("Hãy nhập tên khách hàng");
                txttenkh.Focus();
                return;
            }
          
            ketnoi.Open();
            sql = @"Select * FROM khachhang where (sdt = N'" + txtsdt.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();

            if (docdulieu.Read() == true)
            {
                MessageBox.Show("Khách hàng đã tồn tại");
                ketnoi.Close();
            }

            else
            {
                ketnoi.Close();
                ketnoi.Open();
                sql = @"Insert into khachhang (sdt, tenkh, trangthai, diemtl) values ( N'" + txtsdt.Text + @"' , N'" + txttenkh.Text + @"', N'created', N'0')";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Thêm Khách hàng thành công");
               txtsdt.ResetText();
                txttenkh.ResetText();
             
            }
        }

        private void ThemKHBoss_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
        }

        private void txttenkh_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("chi duoc nhap so");
                txtsdt.ResetText();
                return;
               
            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            QLKHBoss qLKHBoss = new QLKHBoss();
            qLKHBoss.Show();
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtsdt.ResetText();
            txttenkh.ResetText();
        }
    }
}
