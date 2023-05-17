namespace ThiCuoiKyCNPM
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ofdOpenfile = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.txbMaTheTu = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.rdXeMay = new System.Windows.Forms.RadioButton();
            this.rdXeDap = new System.Windows.Forms.RadioButton();
            this.dtpThoiGianVaoTT = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbidXe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBienSo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(380, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hình ảnh camera 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofdOpenfile
            // 
            this.ofdOpenfile.FileName = "openFileDialog1";
            this.ofdOpenfile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdOpenfile_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(865, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xe vào";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbMaTheTu
            // 
            this.txbMaTheTu.Location = new System.Drawing.Point(136, 29);
            this.txbMaTheTu.Name = "txbMaTheTu";
            this.txbMaTheTu.Size = new System.Drawing.Size(170, 22);
            this.txbMaTheTu.TabIndex = 4;
            this.txbMaTheTu.TextChanged += new System.EventHandler(this.txbIDxevao_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(467, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Hình ảnh camera 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelIcon);
            this.groupBox1.Controls.Add(this.rdXeMay);
            this.groupBox1.Controls.Add(this.rdXeDap);
            this.groupBox1.Controls.Add(this.dtpThoiGianVaoTT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbMaTheTu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbidXe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbBienSo);
            this.groupBox1.Location = new System.Drawing.Point(43, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 152);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe vào";
            // 
            // panelIcon
            // 
            this.panelIcon.BackgroundImage = global::ThiCuoiKyCNPM.Properties.Resources.True;
            this.panelIcon.Location = new System.Drawing.Point(711, 37);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(55, 50);
            this.panelIcon.TabIndex = 15;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "id xe: ";
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
            // lbidXe
            // 
            this.lbidXe.AutoSize = true;
            this.lbidXe.Location = new System.Drawing.Point(507, 78);
            this.lbidXe.Name = "lbidXe";
            this.lbidXe.Size = new System.Drawing.Size(19, 16);
            this.lbidXe.TabIndex = 10;
            this.lbidXe.Text = "....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Loại xe";
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
            // txbBienSo
            // 
            this.txbBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBienSo.Location = new System.Drawing.Point(510, 26);
            this.txbBienSo.Name = "txbBienSo";
            this.txbBienSo.Size = new System.Drawing.Size(174, 30);
            this.txbBienSo.TabIndex = 2;
            // 
            // XeVaoTheTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "XeVaoTheTu";
            this.Text = "LuuAnhCSDL";
            this.Load += new System.EventHandler(this.XeVaoTheTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofdOpenfile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.RadioButton rdXeMay;
        private System.Windows.Forms.RadioButton rdXeDap;
        private System.Windows.Forms.DateTimePicker dtpThoiGianVaoTT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbidXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaTheTu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbBienSo;
    }
}