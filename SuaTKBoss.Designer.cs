namespace Mk.Pet1
{
    partial class SuaTKBoss
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.listView1 = new System.Windows.Forms.ListView();
            this.colid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmatkhau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colchucvu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttkid = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.btnSuaTK = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Image = global::Mk.Pet1.Properties.Resources.bf06950fa9ab546640966dd338dfb6f5;
            label2.Location = new System.Drawing.Point(471, 127);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(220, 25);
            label2.TabIndex = 15;
            label2.Text = "Nhập Tên Tài Khoản:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label1.ForeColor = System.Drawing.Color.Chocolate;
            label1.Image = global::Mk.Pet1.Properties.Resources.bf06950fa9ab546640966dd338dfb6f5;
            label1.Location = new System.Drawing.Point(157, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(808, 91);
            label1.TabIndex = 13;
            label1.Text = "Chỉnh Sửa Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Image = global::Mk.Pet1.Properties.Resources.bf06950fa9ab546640966dd338dfb6f5;
            label3.Location = new System.Drawing.Point(20, 213);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(204, 25);
            label3.TabIndex = 19;
            label3.Text = "Tên Tài Khoản Mới:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.BlanchedAlmond;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Image = global::Mk.Pet1.Properties.Resources.bf06950fa9ab546640966dd338dfb6f5;
            label4.Location = new System.Drawing.Point(71, 292);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(153, 25);
            label4.TabIndex = 20;
            label4.Text = "Mật Khẩu Mới:";
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
            this.listView1.Location = new System.Drawing.Point(2, 392);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1101, 295);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
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
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.NavajoWhite;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntimkiem.ForeColor = System.Drawing.Color.Black;
            this.btntimkiem.Location = new System.Drawing.Point(948, 179);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(144, 37);
            this.btntimkiem.TabIndex = 14;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttkid
            // 
            this.txttkid.BackColor = System.Drawing.SystemColors.Info;
            this.txttkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttkid.Location = new System.Drawing.Point(733, 127);
            this.txttkid.Multiline = true;
            this.txttkid.Name = "txttkid";
            this.txttkid.Size = new System.Drawing.Size(326, 36);
            this.txttkid.TabIndex = 12;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Info;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtid.Location = new System.Drawing.Point(253, 207);
            this.txtid.MaxLength = 20;
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(458, 44);
            this.txtid.TabIndex = 17;
            // 
            // txtmk
            // 
            this.txtmk.BackColor = System.Drawing.SystemColors.Info;
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmk.Location = new System.Drawing.Point(253, 286);
            this.txtmk.MaxLength = 20;
            this.txtmk.Multiline = true;
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(458, 44);
            this.txtmk.TabIndex = 18;
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSuaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaTK.ForeColor = System.Drawing.Color.Black;
            this.btnSuaTK.Location = new System.Drawing.Point(733, 193);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(161, 58);
            this.btnSuaTK.TabIndex = 21;
            this.btnSuaTK.Text = "Sửa Tên Tài Khoản";
            this.btnSuaTK.UseVisualStyleBackColor = false;
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.Red;
            this.btnXoaTK.Location = new System.Drawing.Point(915, 311);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(166, 59);
            this.btnXoaTK.TabIndex = 22;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.UseVisualStyleBackColor = false;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(733, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 60);
            this.button1.TabIndex = 23;
            this.button1.Text = "Sửa Mật Khẩu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnreturn.ForeColor = System.Drawing.Color.Black;
            this.btnreturn.Location = new System.Drawing.Point(12, 9);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(139, 39);
            this.btnreturn.TabIndex = 24;
            this.btnreturn.Text = "Trở Lại";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(25, 348);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 38);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SuaTKBoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mk.Pet1.Properties.Resources.bf06950fa9ab546640966dd338dfb6f5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 699);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoaTK);
            this.Controls.Add(this.btnSuaTK);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.listView1);
            this.Controls.Add(label2);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(label1);
            this.Controls.Add(this.txttkid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuaTKBoss";
            this.Text = "SuaTKBoss";
            this.Load += new System.EventHandler(this.SuaTKBoss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colid;
        private System.Windows.Forms.ColumnHeader colmatkhau;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttkid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Button btnSuaTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader colchucvu;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnReset;
    }
}