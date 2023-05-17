namespace ThiCuoiKyCNPM
{
    partial class TheTu
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
            this.dgvTheTu = new System.Windows.Forms.DataGridView();
            this.btnThemTT = new System.Windows.Forms.Button();
            this.btnXoaTT = new System.Windows.Forms.Button();
            this.btnSuaTT = new System.Windows.Forms.Button();
            this.txbMaTheTu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLoaiXe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheTu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTheTu
            // 
            this.dgvTheTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheTu.Location = new System.Drawing.Point(69, 117);
            this.dgvTheTu.Name = "dgvTheTu";
            this.dgvTheTu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTheTu.RowHeadersWidth = 100;
            this.dgvTheTu.RowTemplate.Height = 24;
            this.dgvTheTu.Size = new System.Drawing.Size(661, 369);
            this.dgvTheTu.TabIndex = 0;
            this.dgvTheTu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheTu_CellContentClick);
            // 
            // btnThemTT
            // 
            this.btnThemTT.Location = new System.Drawing.Point(807, 117);
            this.btnThemTT.Name = "btnThemTT";
            this.btnThemTT.Size = new System.Drawing.Size(138, 49);
            this.btnThemTT.TabIndex = 1;
            this.btnThemTT.Text = "Thêm thẻ từ";
            this.btnThemTT.UseVisualStyleBackColor = true;
            this.btnThemTT.Click += new System.EventHandler(this.btnThemTT_Click);
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.Location = new System.Drawing.Point(807, 198);
            this.btnXoaTT.Name = "btnXoaTT";
            this.btnXoaTT.Size = new System.Drawing.Size(138, 49);
            this.btnXoaTT.TabIndex = 2;
            this.btnXoaTT.Text = "Xóa";
            this.btnXoaTT.UseVisualStyleBackColor = true;
            this.btnXoaTT.Click += new System.EventHandler(this.btnXoaTT_Click);
            // 
            // btnSuaTT
            // 
            this.btnSuaTT.Location = new System.Drawing.Point(807, 283);
            this.btnSuaTT.Name = "btnSuaTT";
            this.btnSuaTT.Size = new System.Drawing.Size(138, 49);
            this.btnSuaTT.TabIndex = 3;
            this.btnSuaTT.Text = "Sửa";
            this.btnSuaTT.UseVisualStyleBackColor = true;
            this.btnSuaTT.Click += new System.EventHandler(this.btnSuaTT_Click);
            // 
            // txbMaTheTu
            // 
            this.txbMaTheTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaTheTu.Location = new System.Drawing.Point(162, 62);
            this.txbMaTheTu.Name = "txbMaTheTu";
            this.txbMaTheTu.Size = new System.Drawing.Size(166, 30);
            this.txbMaTheTu.TabIndex = 4;
            this.txbMaTheTu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã thẻ từ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại xe";
            // 
            // txbLoaiXe
            // 
            this.txbLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoaiXe.Location = new System.Drawing.Point(479, 62);
            this.txbLoaiXe.Name = "txbLoaiXe";
            this.txbLoaiXe.Size = new System.Drawing.Size(166, 30);
            this.txbLoaiXe.TabIndex = 6;
            // 
            // TheTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLoaiXe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMaTheTu);
            this.Controls.Add(this.btnSuaTT);
            this.Controls.Add(this.btnXoaTT);
            this.Controls.Add(this.btnThemTT);
            this.Controls.Add(this.dgvTheTu);
            this.Name = "TheTu";
            this.Size = new System.Drawing.Size(1023, 619);
            this.Load += new System.EventHandler(this.TheTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTheTu;
        private System.Windows.Forms.Button btnThemTT;
        private System.Windows.Forms.Button btnXoaTT;
        private System.Windows.Forms.Button btnSuaTT;
        private System.Windows.Forms.TextBox txbMaTheTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLoaiXe;
    }
}
