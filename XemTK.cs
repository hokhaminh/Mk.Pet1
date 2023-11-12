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
    public partial class XemTK : Form
    {
        public XemTK()
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
            sql = @"Select tentk, matkhau, chucvu FROM taikhoan ";
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
            QLTKBoss qLTKBoss = new QLTKBoss();
            qLTKBoss.Show();
            this.Close();
        }

        private void XemTK_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }
    }
}
