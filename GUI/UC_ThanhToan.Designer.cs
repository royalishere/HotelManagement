namespace HotelManagement
{
    partial class UC_ThanhToan
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
            this.label6 = new System.Windows.Forms.Label();
            this.gia_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmnd_tb = new System.Windows.Forms.TextBox();
            this.hinhthuc_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stk_tb = new System.Windows.Forms.TextBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.maphg_cb = new System.Windows.Forms.ComboBox();
            this.maphieu_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(628, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Tổng thanh toán";
            // 
            // gia_tb
            // 
            this.gia_tb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gia_tb.Location = new System.Drawing.Point(750, 184);
            this.gia_tb.Margin = new System.Windows.Forms.Padding(2);
            this.gia_tb.Name = "gia_tb";
            this.gia_tb.Size = new System.Drawing.Size(150, 24);
            this.gia_tb.TabIndex = 50;
            this.gia_tb.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Mã phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(478, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 36);
            this.label4.TabIndex = 47;
            this.label4.Text = "THANH TOÁN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "CMND";
            // 
            // cmnd_tb
            // 
            this.cmnd_tb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnd_tb.Location = new System.Drawing.Point(298, 184);
            this.cmnd_tb.Margin = new System.Windows.Forms.Padding(2);
            this.cmnd_tb.Name = "cmnd_tb";
            this.cmnd_tb.Size = new System.Drawing.Size(234, 24);
            this.cmnd_tb.TabIndex = 40;
            this.cmnd_tb.Leave += new System.EventHandler(this.cmnd_tb_Leave);
            // 
            // hinhthuc_cb
            // 
            this.hinhthuc_cb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinhthuc_cb.FormattingEnabled = true;
            this.hinhthuc_cb.Items.AddRange(new object[] {
            "Trực tiếp",
            "Thẻ tín dụng",
            "Ví điện tử"});
            this.hinhthuc_cb.Location = new System.Drawing.Point(750, 236);
            this.hinhthuc_cb.Margin = new System.Windows.Forms.Padding(2);
            this.hinhthuc_cb.Name = "hinhthuc_cb";
            this.hinhthuc_cb.Size = new System.Drawing.Size(150, 24);
            this.hinhthuc_cb.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Hình thức thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Số ngân hàng/ví điện tử";
            // 
            // stk_tb
            // 
            this.stk_tb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stk_tb.Location = new System.Drawing.Point(750, 294);
            this.stk_tb.Margin = new System.Windows.Forms.Padding(2);
            this.stk_tb.Name = "stk_tb";
            this.stk_tb.Size = new System.Drawing.Size(150, 24);
            this.stk_tb.TabIndex = 56;
            // 
            // insert_btn
            // 
            this.insert_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.insert_btn.Location = new System.Drawing.Point(515, 371);
            this.insert_btn.Margin = new System.Windows.Forms.Padding(2);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(107, 31);
            this.insert_btn.TabIndex = 57;
            this.insert_btn.Text = "Thanh toán";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Mã liên phiếu SDDV";
            // 
            // maphg_cb
            // 
            this.maphg_cb.FormattingEnabled = true;
            this.maphg_cb.Location = new System.Drawing.Point(298, 240);
            this.maphg_cb.Name = "maphg_cb";
            this.maphg_cb.Size = new System.Drawing.Size(234, 21);
            this.maphg_cb.TabIndex = 60;
            this.maphg_cb.SelectedIndexChanged += new System.EventHandler(this.maphg_cb_SelectedIndexChanged);
            // 
            // maphieu_cb
            // 
            this.maphieu_cb.FormattingEnabled = true;
            this.maphieu_cb.Location = new System.Drawing.Point(298, 300);
            this.maphieu_cb.Name = "maphieu_cb";
            this.maphieu_cb.Size = new System.Drawing.Size(234, 21);
            this.maphieu_cb.TabIndex = 61;
            this.maphieu_cb.SelectedIndexChanged += new System.EventHandler(this.maphieu_cb_SelectedIndexChanged);
            // 
            // UC_ThanhToan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.maphieu_cb);
            this.Controls.Add(this.maphg_cb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.stk_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hinhthuc_cb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gia_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmnd_tb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_ThanhToan";
            this.Size = new System.Drawing.Size(1088, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gia_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cmnd_tb;
        private System.Windows.Forms.ComboBox hinhthuc_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stk_tb;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox maphg_cb;
        private System.Windows.Forms.ComboBox maphieu_cb;
    }
}
