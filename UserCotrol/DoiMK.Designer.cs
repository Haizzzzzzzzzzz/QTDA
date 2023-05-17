namespace ThiCuoiKyCNPM
{
    partial class DoiMK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.txbTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMKmoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNhapLaiMk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(467, 315);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(83, 34);
            this.btnDoiMK.TabIndex = 0;
            this.btnDoiMK.Text = "Đồng ý";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(434, 143);
            this.txbTK.Name = "txbTK";
            this.txbTK.Size = new System.Drawing.Size(170, 22);
            this.txbTK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu mới";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbMKmoi
            // 
            this.txbMKmoi.Location = new System.Drawing.Point(434, 197);
            this.txbMKmoi.Name = "txbMKmoi";
            this.txbMKmoi.PasswordChar = '*';
            this.txbMKmoi.Size = new System.Drawing.Size(170, 22);
            this.txbMKmoi.TabIndex = 3;
            this.txbMKmoi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txbNhapLaiMk
            // 
            this.txbNhapLaiMk.Location = new System.Drawing.Point(434, 250);
            this.txbNhapLaiMk.Name = "txbNhapLaiMk";
            this.txbNhapLaiMk.PasswordChar = '*';
            this.txbNhapLaiMk.Size = new System.Drawing.Size(170, 22);
            this.txbNhapLaiMk.TabIndex = 5;
            // 
            // DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNhapLaiMk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMKmoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTK);
            this.Controls.Add(this.btnDoiMK);
            this.Name = "DoiMK";
            this.Size = new System.Drawing.Size(1023, 619);
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.TextBox txbTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMKmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNhapLaiMk;
    }
}
