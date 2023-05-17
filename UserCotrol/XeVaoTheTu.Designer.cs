namespace ThiCuoiKyCNPM.UserCotrol
{
    partial class XeVaoTheTu
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
            this.txbBienSo = new System.Windows.Forms.TextBox();
            this.txbMaTheTu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdXeMay = new System.Windows.Forms.RadioButton();
            this.rdXeDap = new System.Windows.Forms.RadioButton();
            this.dtpThoiGianVaoTT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ofdOpenfile = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbidXe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbBienSo
            // 
            this.txbBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBienSo.Location = new System.Drawing.Point(510, 26);
            this.txbBienSo.Name = "txbBienSo";
            this.txbBienSo.Size = new System.Drawing.Size(174, 30);
            this.txbBienSo.TabIndex = 2;
            this.txbBienSo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbMaTheTu
            // 
            this.txbMaTheTu.Location = new System.Drawing.Point(136, 26);
            this.txbMaTheTu.Name = "txbMaTheTu";
            this.txbMaTheTu.Size = new System.Drawing.Size(136, 22);
            this.txbMaTheTu.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelIcon);
            this.groupBox1.Controls.Add(this.rdXeMay);
            this.groupBox1.Controls.Add(this.rdXeDap);
            this.groupBox1.Controls.Add(this.dtpThoiGianVaoTT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbidXe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbMaTheTu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbBienSo);
            this.groupBox1.Location = new System.Drawing.Point(51, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 152);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe vào";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdXeMay
            // 
            this.rdXeMay.AutoSize = true;
            this.rdXeMay.Location = new System.Drawing.Point(233, 74);
            this.rdXeMay.Name = "rdXeMay";
            this.rdXeMay.Size = new System.Drawing.Size(73, 20);
            this.rdXeMay.TabIndex = 12;
            this.rdXeMay.Text = "Xe máy";
            this.rdXeMay.UseVisualStyleBackColor = true;
            // 
            // rdXeDap
            // 
            this.rdXeDap.AutoSize = true;
            this.rdXeDap.Location = new System.Drawing.Point(136, 74);
            this.rdXeDap.Name = "rdXeDap";
            this.rdXeDap.Size = new System.Drawing.Size(71, 20);
            this.rdXeDap.TabIndex = 11;
            this.rdXeDap.Text = "Xe đạp";
            this.rdXeDap.UseVisualStyleBackColor = true;
            // 
            // dtpThoiGianVaoTT
            // 
            this.dtpThoiGianVaoTT.CustomFormat = "MMMMdd, yyyy | hh:mm";
            this.dtpThoiGianVaoTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianVaoTT.Location = new System.Drawing.Point(136, 117);
            this.dtpThoiGianVaoTT.Name = "dtpThoiGianVaoTT";
            this.dtpThoiGianVaoTT.Size = new System.Drawing.Size(234, 22);
            this.dtpThoiGianVaoTT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thời gian vào";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Loại xe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã thẻ từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Biển số";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hình ảnh camera 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofdOpenfile
            // 
            this.ofdOpenfile.FileName = "ofdOpenfile";
            this.ofdOpenfile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hình ảnh camera 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(881, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Lưu thông tin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbidXe
            // 
            this.lbidXe.AutoSize = true;
            this.lbidXe.Location = new System.Drawing.Point(507, 78);
            this.lbidXe.Name = "lbidXe";
            this.lbidXe.Size = new System.Drawing.Size(19, 16);
            this.lbidXe.TabIndex = 10;
            this.lbidXe.Text = "....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "id xe: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(51, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 218);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(412, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 218);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera 2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelIcon
            // 
            this.panelIcon.BackgroundImage = global::ThiCuoiKyCNPM.Properties.Resources.True;
            this.panelIcon.Location = new System.Drawing.Point(711, 37);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(54, 50);
            this.panelIcon.TabIndex = 15;
            // 
            // XeVaoTheTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "XeVaoTheTu";
            this.Size = new System.Drawing.Size(1023, 619);
            this.Load += new System.EventHandler(this.XeVaoTheTu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbBienSo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbMaTheTu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThoiGianVaoTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofdOpenfile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbidXe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdXeDap;
        private System.Windows.Forms.RadioButton rdXeMay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelIcon;
    }
}
