﻿namespace HotelManagement
{
    partial class UC_DangKyDichVu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_DSdichvu = new System.Windows.Forms.DataGridView();
            this.tb_CMND = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_DKdichvu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_DV = new System.Windows.Forms.ComboBox();
            this.tb_Phong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSdichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_DSdichvu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 427);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 223);
            this.panel1.TabIndex = 0;
            // 
            // dgv_DSdichvu
            // 
            this.dgv_DSdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSdichvu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSdichvu.Location = new System.Drawing.Point(0, 0);
            this.dgv_DSdichvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DSdichvu.Name = "dgv_DSdichvu";
            this.dgv_DSdichvu.RowHeadersWidth = 51;
            this.dgv_DSdichvu.RowTemplate.Height = 24;
            this.dgv_DSdichvu.Size = new System.Drawing.Size(1166, 223);
            this.dgv_DSdichvu.TabIndex = 0;
            // 
            // tb_CMND
            // 
            this.tb_CMND.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CMND.Location = new System.Drawing.Point(297, 123);
            this.tb_CMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CMND.Name = "tb_CMND";
            this.tb_CMND.Size = new System.Drawing.Size(308, 28);
            this.tb_CMND.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã dịch vụ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(750, 126);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(377, 88);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(883, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mô tả dịch vụ";
            // 
            // bt_DKdichvu
            // 
            this.bt_DKdichvu.BackColor = System.Drawing.Color.Lime;
            this.bt_DKdichvu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DKdichvu.Location = new System.Drawing.Point(387, 366);
            this.bt_DKdichvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_DKdichvu.Name = "bt_DKdichvu";
            this.bt_DKdichvu.Size = new System.Drawing.Size(143, 38);
            this.bt_DKdichvu.TabIndex = 11;
            this.bt_DKdichvu.Text = "Đăng ký";
            this.bt_DKdichvu.UseVisualStyleBackColor = false;
            this.bt_DKdichvu.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(447, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 45);
            this.label4.TabIndex = 35;
            this.label4.Text = "ĐĂNG KÝ DỊCH VỤ";
            // 
            // tb_soluong
            // 
            this.tb_soluong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soluong.Location = new System.Drawing.Point(297, 309);
            this.tb_soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(311, 28);
            this.tb_soluong.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Mã phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Số lượng (sản phẩm)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbb_DV
            // 
            this.cbb_DV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_DV.FormattingEnabled = true;
            this.cbb_DV.Location = new System.Drawing.Point(297, 247);
            this.cbb_DV.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_DV.Name = "cbb_DV";
            this.cbb_DV.Size = new System.Drawing.Size(308, 29);
            this.cbb_DV.TabIndex = 40;
            // 
            // tb_Phong
            // 
            this.tb_Phong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_Phong.FormattingEnabled = true;
            this.tb_Phong.Location = new System.Drawing.Point(297, 183);
            this.tb_Phong.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Phong.Name = "tb_Phong";
            this.tb_Phong.Size = new System.Drawing.Size(308, 29);
            this.tb_Phong.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(704, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Giá";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(750, 239);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(311, 28);
            this.textBox3.TabIndex = 43;
            // 
            // UC_DangKyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tb_Phong);
            this.Controls.Add(this.cbb_DV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_soluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_DKdichvu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_CMND);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_DangKyDichVu";
            this.Size = new System.Drawing.Size(1166, 650);
            this.Load += new System.EventHandler(this.UC_DangKyDichVu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSdichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DSdichvu;
        private System.Windows.Forms.TextBox tb_CMND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_DKdichvu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_DV;
        private System.Windows.Forms.ComboBox tb_Phong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
    }
}
