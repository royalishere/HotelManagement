﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Le_tan : Form
    {
        Thread t;
        public Le_tan()
        {
            InitializeComponent();
        }
        private void Le_tan_main_form_Load(object sender, EventArgs e)
        {
            
        }

        private void addUserControl(UserControl UC)
        {
            UC.Dock = DockStyle.Fill;
            UC.BringToFront();
        }

        private void bt_YeuCauDacBiet_Click(object sender, EventArgs e)
        {
            uc_special_orders uc = new uc_special_orders();
            addUserControl(uc);
        }

        private void bt_LapPhieuDatPhong_Click(object sender, EventArgs e)
        {
            UC_PhieuDatPhong uc = new UC_PhieuDatPhong();
            addUserControl(uc);
        }

        private void bt_ThongTinPhong_Click(object sender, EventArgs e)
        {
            uc_ThongTinPhong uc = new uc_ThongTinPhong();
            addUserControl((uc));
        }

        private void bt_dangkydv_Click(object sender, EventArgs e)
        {
            UC_DangKyDichVu uc = new UC_DangKyDichVu();
            addUserControl((uc));
        }

        private void bt_dangkytour_Click(object sender, EventArgs e)
        {
            UC_DangKyTour uc = new UC_DangKyTour();
            addUserControl((uc));
        }

        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            UC_ThanhToan uc = new UC_ThanhToan();
            addUserControl((uc));
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(() => Application.Run(new Login()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
