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
    public partial class SuaTKBoss : Form
    {
        public SuaTKBoss()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=LDTHIEN-SM\THIENDTRAI;Initial Catalog=MKPet;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlDataReader docdulieu;
        SqlCommand thuchien;
        int i = 0;
        public void hienthi()
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"Select tentk, matkhau, chucvu FROM taikhoan  ";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                i++;
            }
            ketnoi.Close();
        }
      
      

        private void SuaTKBoss_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }

        private void listView1_Click(object sender, EventArgs e)
        {

            txttkid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            //txttkid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            //txtmk.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (txttkid.Text=="")
            {
                MessageBox.Show("Hãy chọn tài khoản cần chỉnh sửa");
            }
            else
            {
                if (txtid.Text=="")
                {
                    MessageBox.Show("Hãy nhập tài khoản mới");
                }
                
                else
                {

                    ketnoi.Close();
                    ketnoi.Open();
                    sql = @"Select tentk, matkhau, chucvu FROM taikhoan where (tentk = N'" + txttkid.Text + @"' )";
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    i = 0;
                    if (docdulieu.Read() == true)
                    { 
                        ketnoi.Close();
                        listView1.Items.Clear();
                        ketnoi.Open();
                    sql = @"Select tentk, matkhau, chucvu FROM taikhoan where (tentk = N'" + txtid.Text + @"')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    i = 0;
                        if (docdulieu.Read() == true)
                        {
                            ketnoi.Close();
                            MessageBox.Show("Tên tài khoản đã tồn tại");
                            

                        }
                        else
                        {


                            listView1.Items.Clear();
                            ketnoi.Close();
                            ketnoi.Open();
                            sql = @"UPDATE taikhoan SET tentk= N'" + txtid.Text + @"' where (tentk = N'" + txttkid.Text + @"')";
                            thuchien = new SqlCommand(sql, ketnoi);
                            thuchien.ExecuteNonQuery();
                            ketnoi.Close();
                            hienthi();
                            MessageBox.Show("Chỉnh sửa thành công");
                            txtid.ResetText();

                            txttkid.ResetText();
                            ketnoi.Close();
                        }
                       
                    }
                    else
                    {

                        ketnoi.Close();
                        MessageBox.Show("Tài khoản không tồn tại");
                            hienthi();
                       
                        
                    }
                }

            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttkid.Text == "")
            {
                MessageBox.Show("Hãy chọn tài khoản cần chỉnh sửa");
            }
            else
            {
                if (txtmk.Text == "")
                {
                    MessageBox.Show("Hãy nhập mật khẩu mới");
                }

                else
                {
                    ketnoi.Close();
                    ketnoi.Open();
                    sql = @"Select tentk, matkhau, chucvu FROM taikhoan where (tentk = N'" + txttkid.Text + @"' )";
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    i = 0;
                    if (docdulieu.Read() == true)
                    {

                        listView1.Items.Clear();
                        ketnoi.Close();
                        ketnoi.Open();
                        sql = @"UPDATE taikhoan SET  matkhau = N'" + txtmk.Text + @"' where (tentk = N'" + txttkid.Text + @"')";
                        thuchien = new SqlCommand(sql, ketnoi);
                        thuchien.ExecuteNonQuery();
                        ketnoi.Close();
                        hienthi();
                        MessageBox.Show("Chỉnh sửa thành công");
                        txtmk.ResetText();

                        txttkid.ResetText();
                        ketnoi.Close();
                    }
                    else
                    {

                        ketnoi.Close();
                        MessageBox.Show("Tài khoản không tồn tại");
                        hienthi();


                    }

                }

            }

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

            if (txttkid.Text == "")
            {
                MessageBox.Show("Hãy nhập tên tài khoản cần tìm");
            }
            else
            {

                ketnoi.Close();
                ketnoi.Open();
                sql = @"Select tentk, matkhau, chucvu FROM taikhoan where (tentk = N'" + txttkid.Text + @"' )";
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();
                i = 0;
                if (docdulieu.Read() == true)
                {
                    listView1.Items.Clear();
                    ketnoi.Close();
                    ketnoi.Open();
                    sql = @"Select tentk, matkhau, chucvu FROM taikhoan where (tentk = N'" + txttkid.Text + @"' )";
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    i = 0;


                    while (docdulieu.Read())
                    {
                        listView1.Items.Add(docdulieu[0].ToString());
                        listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                        listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                        i++;
                    }
                    ketnoi.Close();
                }



                else
                {
                    ketnoi.Close();
                    MessageBox.Show("Tài khoản không tồn tại");
                    hienthi();


                }



            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            QLTKBoss qLTKBoss = new QLTKBoss();
            qLTKBoss.Show();
            this.Close();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (txttkid.Text == "")
            {
                MessageBox.Show("Hãy nhập tên tài khoản cần Xóa");
            }
            else
            {

                ketnoi.Close();
                ketnoi.Open();
                sql = @"Select tentk, matkhau, chucvu FROM taikhoan where (tentk = N'" + txttkid.Text + @"' )";
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();
                i = 0;
                if (docdulieu.Read() == true)
                {

                    ketnoi.Close();
                    DialogResult f = MessageBox.Show("Bạn có muốn xóa tài khoản không ?", "Thông báo",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (f == DialogResult.Yes)
                    {
                        listView1.Items.Clear();
                        ketnoi.Close();
                        ketnoi.Open();
                        sql = @"DELETE FROM taikhoan where (tentk = N'" + txttkid.Text + @"')";
                        thuchien = new SqlCommand(sql, ketnoi);
                        thuchien.ExecuteNonQuery();
                        ketnoi.Close();
                        hienthi();
                        txttkid.ResetText();

                    }
                }
                else
                {
                    ketnoi.Close();
                    MessageBox.Show("Tai khoan khong ton tai");
                    hienthi();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txttkid.ResetText();
            txtid.ResetText();
            txtmk.ResetText();

        }
    }
}
