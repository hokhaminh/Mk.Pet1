namespace Mk.Pet1
{
    partial class XemTK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            this.listView1 = new System.Windows.Forms.ListView();
            this.colid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmatkhau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colchucvu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnreturn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colid,
            this.colmatkhau,
            this.colchucvu});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1096, 536);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colid
            // 
            this.colid.Text = "Tên Tài Khoản";
            this.colid.Width = 350;
            // 
            // colmatkhau
            // 
            this.colmatkhau.Text = "Mật Khẩu";
            this.colmatkhau.Width = 350;
            // 
            // colchucvu
            // 
            this.colchucvu.Text = "Chức Vụ";
            this.colchucvu.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label1.ForeColor = System.Drawing.Color.Chocolate;
            label1.Image = global::Mk.Pet1.Properties.Resources.bf06950fa9ab546640966dd338dfb6f5;
            label1.Location = new System.Drawing.Point(177, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(773, 69);
            label1.TabIndex = 14;
            label1.Text = "Xem Danh Sách Tài Khoản";
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnreturn.ForeColor = System.Drawing.Color.Black;
            this.btnreturn.Location = new System.Drawing.Point(4, 3);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(139, 39);
            this.btnreturn.TabIndex = 18;
            this.btnreturn.Text = "Trở Lại";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // XemTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mk.Pet1.Properties.Resources.bf06950fa9ab546640966dd338dfb6f5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 699);
            this.Controls.Add(this.listView1);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnreturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XemTK";
            this.Text = "XemTK";
            this.Load += new System.EventHandler(this.XemTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colid;
        private System.Windows.Forms.ColumnHeader colmatkhau;
        private System.Windows.Forms.ColumnHeader colchucvu;
        private System.Windows.Forms.Button btnreturn;
    }
}