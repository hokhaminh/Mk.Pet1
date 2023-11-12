using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mk.Pet1
{
    public partial class MainBoss : Form
    {
        public MainBoss()
        {
            InitializeComponent();
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

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn đăng xuất không ?", "Thông báo",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                
             login login = new login();
                login.Show();
                    this.Close();
            }
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            QLTKBoss QlTKBoss = new QLTKBoss();
            QlTKBoss.Show();
            this.Close();
        }

        private void MainBoss_Load(object sender, EventArgs e)
        {

        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            QLKHBoss QlQLBoss = new QLKHBoss(); 
            QlQLBoss.Show();
            this.Close();
        }
    }
}
