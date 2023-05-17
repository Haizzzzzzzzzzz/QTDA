namespace ThiCuoiKyCNPM.UserCotrol
{
    partial class TaoTK
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
            this.label3 = new System.Windows.Forms.Label();
            this.txbNhapLaiMk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMKmoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTK = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txbNhapLaiMk
            // 
            this.txbNhapLaiMk.Location = new System.Drawing.Point(435, 274);
            this.txbNhapLaiMk.Name = "txbNhapLaiMk";
            this.txbNhapLaiMk.PasswordChar = '*';
            this.txbNhapLaiMk.Size = new System.Drawing.Size(170, 22);
            this.txbNhapLaiMk.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu ";
            // 
            // txbMKmoi
            // 
            this.txbMKmoi.Location = new System.Drawing.Point(435, 221);
            this.txbMKmoi.Name = "txbMKmoi";
            this.txbMKmoi.PasswordChar = '*';
            this.txbMKmoi.Size = new System.Drawing.Size(170, 22);
            this.txbMKmoi.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tài khoản";
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(435, 167);
            this.txbTK.Name = "txbTK";
            this.txbTK.Size = new System.Drawing.Size(170, 22);
            this.txbTK.TabIndex = 8;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(468, 339);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(83, 34);
            this.btnDoiMK.TabIndex = 7;
            this.btnDoiMK.Text = "Đồng ý";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // TaoTK
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
            this.Name = "TaoTK";
            this.Size = new System.Drawing.Size(1023, 619);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNhapLaiMk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMKmoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTK;
        private System.Windows.Forms.Button btnDoiMK;
    }
}
