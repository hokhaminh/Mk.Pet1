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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=LDTHIEN-SM\THIENDTRAI;Initial Catalog=MKPet;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlDataReader docdulieu;
        SqlCommand thuchien;
        int i = 0;
        private void login_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (Id.Text == "")
            {
                MessageBox.Show("Hãy nhập tên tài khoản");
                Id.Focus();
                return;
            }

            if (Pass.Text == "")
            {
                MessageBox.Show("Hãy nhập mật khảu");
                Pass.Focus();
                return;
            }
            ketnoi.Open();
            sql = @"Select * FROM taikhoan where (tentk = N'" + Id.Text + @"' and matkhau = N'" + Pass.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;

            if (docdulieu.Read() == true)
            {
                ketnoi.Close();
                ketnoi.Open();
                sql = @"Select * FROM taikhoan where (tentk = N'" + Id.Text + @"' and matkhau = N'" + Pass.Text + @"' and chucvu = 'boss')";
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();

                if (docdulieu.Read() == true)
                {
                    MainBoss mainBoss = new MainBoss();
                    mainBoss.Show();
                    this.Hide();

                }
                ketnoi.Close();
                ketnoi.Open();
                sql = @"Select * FROM taikhoan where (tentk = N'" + Id.Text + @"' and matkhau = N'" + Pass.Text + @"' and chucvu = 'staff')";
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();

                if (docdulieu.Read() == true)
                {
                    MessageBox.Show("chao mung nhan vien");
                }

                

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
            ketnoi.Close();

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

        private void btnreset_Click(object sender, EventArgs e)
        {
            Id.ResetText();
            Pass.ResetText();
        }
    }
}
