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

namespace Mk.Pet1
{
    public partial class ThemTKBoss : Form
    {
        public ThemTKBoss()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=LDTHIEN-SM\THIENDTRAI;Initial Catalog=MKPet;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlDataReader docdulieu;
        SqlCommand thuchien;
        int i = 0;
        private void btnreturn_Click(object sender, EventArgs e)
        {
            QLTKBoss qLTKBoss = new QLTKBoss();
            qLTKBoss.Show();
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không ?", "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void ThemTKBoss_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Hãy nhập tên tài khoản");
                txtid.Focus();
                return;
            }

            if (txtpass1.Text == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu");
                txtpass1.Focus();
                return;
            }
            if (txtpass2.Text == "")
            {
                MessageBox.Show("Hãy nhập lại mật khẩu");
                txtpass2.Focus();
                return;
            }
           

            if (txtpass1.Text == txtpass2.Text)
            {
                ketnoi.Open();
                sql = @"Select * FROM taikhoan where (tentk = N'" + txtid.Text + @"')";
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();
               
                if (docdulieu.Read() == true)
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                    ketnoi.Close();
                }
               
                else
                {
                    ketnoi.Close();
                    ketnoi.Open();
                    sql = @"Insert into taikhoan (tentk, matkhau, chucvu) values ( N'" + txtid.Text + @"' , N'" + txtpass1.Text + @"', N'staff')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    MessageBox.Show("Thêm tài khoản thành công");
                    txtpass1.ResetText();
                    txtid.ResetText();
                    txtpass2.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu và mật khẩu nhập lại không trùng khớp");
                txtpass1.Focus();
                return;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtid.ResetText();
            txtpass1.ResetText();
            txtpass2.ResetText();
        }
    }
}
