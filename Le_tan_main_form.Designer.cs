namespace HotelManagement
{
    partial class Le_tan_main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Le_tan_main_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_ThongTinPhong = new System.Windows.Forms.Button();
            this.bt_LapPhieuDatPhong = new System.Windows.Forms.Button();
            this.bt_YeuCauDacBiet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.bt_ThongTinPhong);
            this.panel1.Controls.Add(this.bt_LapPhieuDatPhong);
            this.panel1.Controls.Add(this.bt_YeuCauDacBiet);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 653);
            this.panel1.TabIndex = 0;
            // 
            // bt_ThongTinPhong
            // 
            this.bt_ThongTinPhong.BackColor = System.Drawing.Color.Lime;
            this.bt_ThongTinPhong.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThongTinPhong.Location = new System.Drawing.Point(0, 315);
            this.bt_ThongTinPhong.Name = "bt_ThongTinPhong";
            this.bt_ThongTinPhong.Size = new System.Drawing.Size(213, 59);
            this.bt_ThongTinPhong.TabIndex = 3;
            this.bt_ThongTinPhong.Text = "Thông tin phòng";
            this.bt_ThongTinPhong.UseVisualStyleBackColor = false;
            this.bt_ThongTinPhong.Click += new System.EventHandler(this.bt_ThongTinPhong_Click);
            // 
            // bt_LapPhieuDatPhong
            // 
            this.bt_LapPhieuDatPhong.BackColor = System.Drawing.Color.Lime;
            this.bt_LapPhieuDatPhong.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LapPhieuDatPhong.Location = new System.Drawing.Point(0, 250);
            this.bt_LapPhieuDatPhong.Name = "bt_LapPhieuDatPhong";
            this.bt_LapPhieuDatPhong.Size = new System.Drawing.Size(213, 59);
            this.bt_LapPhieuDatPhong.TabIndex = 2;
            this.bt_LapPhieuDatPhong.Text = "Lập phiếu đặt phòng";
            this.bt_LapPhieuDatPhong.UseVisualStyleBackColor = false;
            this.bt_LapPhieuDatPhong.Click += new System.EventHandler(this.bt_LapPhieuDatPhong_Click);
            // 
            // bt_YeuCauDacBiet
            // 
            this.bt_YeuCauDacBiet.BackColor = System.Drawing.Color.Lime;
            this.bt_YeuCauDacBiet.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_YeuCauDacBiet.Location = new System.Drawing.Point(0, 380);
            this.bt_YeuCauDacBiet.Name = "bt_YeuCauDacBiet";
            this.bt_YeuCauDacBiet.Size = new System.Drawing.Size(213, 59);
            this.bt_YeuCauDacBiet.TabIndex = 1;
            this.bt_YeuCauDacBiet.Text = "Yêu cầu đặc biệt";
            this.bt_YeuCauDacBiet.UseVisualStyleBackColor = false;
            this.bt_YeuCauDacBiet.Click += new System.EventHandler(this.bt_YeuCauDacBiet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(46, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(219, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1413, 653);
            this.panelContainer.TabIndex = 2;
            // 
            // Le_tan_main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 653);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Le_tan_main_form";
            this.Text = "Le_tan_main_form";
            this.Load += new System.EventHandler(this.Le_tan_main_form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_YeuCauDacBiet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button bt_LapPhieuDatPhong;
        private System.Windows.Forms.Button bt_ThongTinPhong;
    }
}