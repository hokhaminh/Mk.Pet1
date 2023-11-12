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
    public partial class QLTKBoss : Form
    {
        public QLTKBoss()
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

        private void btnreturn_Click(object sender, EventArgs e)
        {
            MainBoss MainBoss = new MainBoss(); 
            MainBoss.Show();    
            this.Close();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            ThemTKBoss ThemTKBoss = new ThemTKBoss();   
            ThemTKBoss.Show();
            this.Close();
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            SuaTKBoss suaTKBoss = new SuaTKBoss();
            suaTKBoss.Show();
            this.Close();
        }

        private void btnTimKiemTK_Click(object sender, EventArgs e)
        {
            TimKiemTKBoss timKiemTK = new TimKiemTKBoss();
            timKiemTK.Show();
            this.Close();
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            XemTK xemTK = new XemTK();  
            xemTK.Show();
            this.Close();
        }
    }
}
