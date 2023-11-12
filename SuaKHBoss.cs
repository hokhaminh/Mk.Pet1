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
    public partial class SuaKHBoss : Form
    {
        public SuaKHBoss()
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
            sql = @"Select * FROM khachhang  ";
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
        private void btnreturn_Click(object sender, EventArgs e)
        {
           QLKHBoss qLKHBoss = new QLKHBoss();
                qLKHBoss.Show();
            this.Close();
        }

        private void SuaKHBoss_Load(object sender, EventArgs e)
        {

            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txttksdt.Text = listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void btnSuasdt_Click(object sender, EventArgs e)
        {
            if (txttksdt.Text == "")
            {
                MessageBox.Show("Hãy chọn khách hàng cần chỉnh sửa");
            }
            else
            {
                if (txtsdt.Text == "")
                {
                    MessageBox.Show("Hãy nhập số điện thoại mới");
                }

                else
                {

                    ketnoi.Close();
                    ketnoi.Open();
                    sql = @"Select * FROM khachhang where (sdt = N'" + txttksdt.Text + @"' )";
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    i = 0;
                    if (docdulieu.Read() == true)
                    {
                        ketnoi.Close();
                        listView1.Items.Clear();
                        ketnoi.Open();
                        sql = @"Select * FROM khachhang where (sdt = N'" + txtsdt.Text + @"')";
                        thuchien = new SqlCommand(sql, ketnoi);
                        docdulieu = thuchien.ExecuteReader();
                        i = 0;
                        if (docdulieu.Read() == true)
                        {
                            ketnoi.Close();
                            MessageBox.Show("Số điện thoại đã tồn tại");
                            hienthi();

                        }
                        else
                        {
                            listView1.Items.Clear();
                            ketnoi.Close();
                            ketnoi.Open();
                            sql = @"UPDATE khachhang SET sdt= N'" + txtsdt.Text + @"' where (sdt = N'" + txttksdt.Text + @"')";
                            thuchien = new SqlCommand(sql, ketnoi);
                            thuchien.ExecuteNonQuery();
                            ketnoi.Close();
                            hienthi();
                            MessageBox.Show("Chỉnh sửa thành công");
                            txtsdt.ResetText();

                            txttksdt.ResetText();
                            ketnoi.Close();
                        }

                    }
                    else
                    {

                        ketnoi.Close();
                        MessageBox.Show("khách hàng không tồn tại");
                        hienthi();


                    }
                }

            }
        }

        private void btnsuaten_Click(object sender, EventArgs e)
        {
            if (txttksdt.Text == "")
            {
                MessageBox.Show("Hãy chọn khách hàng cần chỉnh sửa");
            }
            else
            {
                if (txttenkh.Text == "")
                {
                    MessageBox.Show("Hãy nhập tên khách hàng mới");
                }

                else
                {
                    ketnoi.Close();
                    ketnoi.Open();
                    sql = @"Select * FROM khachhang where (sdt = N'" + txttksdt.Text + @"' )";
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    i = 0;
                    if (docdulieu.Read() == true)
                    {

                        listView1.Items.Clear();
                        ketnoi.Close();
                        ketnoi.Open();
                        sql = @"UPDATE khachhang SET  tenkh = N'" + txttenkh.Text + @"' where (sdt = N'" + txttksdt.Text + @"')";
                        thuchien = new SqlCommand(sql, ketnoi);
                        thuchien.ExecuteNonQuery();
                        ketnoi.Close();
                        hienthi();
                        MessageBox.Show("Chỉnh sửa thành công");
                        txttenkh.ResetText();

                        txttksdt.ResetText();
                        ketnoi.Close();
                    }
                    else
                    {

                        ketnoi.Close();
                        MessageBox.Show("khách hàng không tồn tại");
                        hienthi();


                    }

                }

            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
