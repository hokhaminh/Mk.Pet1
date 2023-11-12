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
    public partial class QLKHBoss : Form
    {
        public QLKHBoss()
        {
            InitializeComponent();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            ThemKHBoss themKHBoss = new ThemKHBoss();
            themKHBoss.Show();
            this.Close();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            SuaKHBoss suaKHBoss = new SuaKHBoss();  
            suaKHBoss.Show();
            this.Close();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            MainBoss mainboss = new MainBoss(); 
            mainboss.Show();
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
    }
}
