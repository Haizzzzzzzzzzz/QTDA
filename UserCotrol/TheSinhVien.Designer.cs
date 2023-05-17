namespace ThiCuoiKyCNPM.UserCtrol
{
    partial class TheSinhVien
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
            this.dgvTheSinhVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTheSinhVien
            // 
            this.dgvTheSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheSinhVien.Location = new System.Drawing.Point(82, 63);
            this.dgvTheSinhVien.Name = "dgvTheSinhVien";
            this.dgvTheSinhVien.RowHeadersWidth = 51;
            this.dgvTheSinhVien.RowTemplate.Height = 24;
            this.dgvTheSinhVien.Size = new System.Drawing.Size(891, 406);
            this.dgvTheSinhVien.TabIndex = 0;
            this.dgvTheSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TheSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTheSinhVien);
            this.Name = "TheSinhVien";
            this.Size = new System.Drawing.Size(1023, 619);
            this.Load += new System.EventHandler(this.TheSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTheSinhVien;
    }
}
