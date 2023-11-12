namespace Mk.Pet1
{
    partial class ThemKHBoss
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.btnreset = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.SandyBrown;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnreset.ForeColor = System.Drawing.Color.Black;
            this.btnreset.Location = new System.Drawing.Point(968, 453);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(124, 35);
            this.btnreset.TabIndex = 22;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnreturn.ForeColor = System.Drawing.Color.Black;
            this.btnreturn.Location = new System.Drawing.Point(12, 12);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(139, 39);
            this.btnreturn.TabIndex = 21;
            this.btnreturn.Text = "Trở Lại";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTao.ForeColor = System.Drawing.Color.Black;
            this.btnTao.Location = new System.Drawing.Point(240, 480);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(619, 67);
            this.btnTao.TabIndex = 16;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // txttenkh
            // 
            this.txttenkh.BackColor = System.Drawing.SystemColors.Info;
            this.txttenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttenkh.Location = new System.Drawing.Point(455, 382);
            this.txttenkh.MaxLength = 30;
            this.txttenkh.Multiline = true;
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(594, 54);
            this.txttenkh.TabIndex = 14;
            this.txttenkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenkh_KeyPress);
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.SystemColors.Info;
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsdt.Location = new System.Drawing.Point(455, 246);
            this.txtsdt.MaxLength = 10;
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(594, 54);
            this.txtsdt.TabIndex = 13;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Image = global::Mk.Pet1.Properties.Resources.bf06950fa9ab546640966dd338dfb6f5;
            label3.Location = new System.Drawing.Point(124, 382);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(286, 38);
            label3.TabIndex = 19;
            label3.Text = "Tên Khách Hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Image = global::Mk.Pet1.Properties.Resources.bf06950fa9ab546640966dd338dfb6f5;
            label2.Location = new System.Drawing.Point(164, 249);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(246, 38);
            label2.TabIndex = 18;
            label2.Text = "Số Điện Thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label1.ForeColor = System.Drawing.Color.Chocolate;
            label1.Image = global::Mk.Pet1.Properties.Resources.bf06950fa9ab546640966dd338dfb6f5;
            label1.Location = new System.Drawing.Point(186, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(800, 91);
            label1.TabIndex = 17;
            label1.Text = "Tạo Khách Hàng Mới";
            // 
            // ThemKHBoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mk.Pet1.Properties.Resources.bf06950fa9ab546640966dd338dfb6f5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 699);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.txtsdt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemKHBoss";
            this.Text = "ThemKHBoss";
            this.Load += new System.EventHandler(this.ThemKHBoss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtsdt;
    }
}