namespace HotelManagement.GUI
{
    partial class YCDacBiet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ycdb_dg = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmnd_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ycdb_tb = new System.Windows.Forms.RichTextBox();
            this.maphg_tb = new System.Windows.Forms.TextBox();
            this.tenkh_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ycdb_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // ycdb_dg
            // 
            this.ycdb_dg.AllowUserToAddRows = false;
            this.ycdb_dg.AllowUserToDeleteRows = false;
            this.ycdb_dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ycdb_dg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ycdb_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ycdb_dg.Location = new System.Drawing.Point(16, 296);
            this.ycdb_dg.Name = "ycdb_dg";
            this.ycdb_dg.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ycdb_dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ycdb_dg.Size = new System.Drawing.Size(831, 207);
            this.ycdb_dg.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(147, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "CMND";
            // 
            // cmnd_tb
            // 
            this.cmnd_tb.Enabled = false;
            this.cmnd_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmnd_tb.Location = new System.Drawing.Point(201, 100);
            this.cmnd_tb.Name = "cmnd_tb";
            this.cmnd_tb.Size = new System.Drawing.Size(146, 22);
            this.cmnd_tb.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(271, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 36);
            this.label4.TabIndex = 46;
            this.label4.Text = "YÊU CẦU ĐẶC BIỆT";
            // 
            // submit_btn
            // 
            this.submit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.submit_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.submit_btn.Location = new System.Drawing.Point(229, 236);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(88, 28);
            this.submit_btn.TabIndex = 45;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(559, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Yêu cầu đặc biệt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(133, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Số phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(99, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tên khách hàng";
            // 
            // ycdb_tb
            // 
            this.ycdb_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ycdb_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ycdb_tb.Location = new System.Drawing.Point(424, 103);
            this.ycdb_tb.Margin = new System.Windows.Forms.Padding(2);
            this.ycdb_tb.Name = "ycdb_tb";
            this.ycdb_tb.Size = new System.Drawing.Size(358, 161);
            this.ycdb_tb.TabIndex = 41;
            this.ycdb_tb.Text = "";
            // 
            // maphg_tb
            // 
            this.maphg_tb.Enabled = false;
            this.maphg_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maphg_tb.Location = new System.Drawing.Point(201, 192);
            this.maphg_tb.Margin = new System.Windows.Forms.Padding(2);
            this.maphg_tb.Name = "maphg_tb";
            this.maphg_tb.Size = new System.Drawing.Size(146, 22);
            this.maphg_tb.TabIndex = 39;
            // 
            // tenkh_tb
            // 
            this.tenkh_tb.Enabled = false;
            this.tenkh_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenkh_tb.Location = new System.Drawing.Point(201, 146);
            this.tenkh_tb.Name = "tenkh_tb";
            this.tenkh_tb.Size = new System.Drawing.Size(146, 22);
            this.tenkh_tb.TabIndex = 50;
            // 
            // YCDacBiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 520);
            this.Controls.Add(this.tenkh_tb);
            this.Controls.Add(this.ycdb_dg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmnd_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ycdb_tb);
            this.Controls.Add(this.maphg_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YCDacBiet";
            this.Text = "YCDacBiet";
            this.Load += new System.EventHandler(this.YCDacBiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ycdb_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ycdb_dg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cmnd_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ycdb_tb;
        private System.Windows.Forms.TextBox maphg_tb;
        private System.Windows.Forms.TextBox tenkh_tb;
    }
}