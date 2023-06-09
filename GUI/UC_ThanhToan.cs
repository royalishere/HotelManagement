﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Business_Layer;
using HotelManagement.Bussiness_Layer;

namespace HotelManagement
{
    public partial class UC_ThanhToan : UserControl
    {
        public UC_ThanhToan()
        {
            InitializeComponent();
        }

        private void cmnd_tb_Leave(object sender, EventArgs e)
        {
            maphg_cb.DataSource = PhieuDatPhong.Phong_CMND(cmnd_tb.Text);
            maphg_cb.DisplayMember = "MaPhong";
            maphg_cb.Text = "";
        }

        private void maphg_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gia_tb.Text = PhieuDatPhong.LayGia(cmnd_tb.Text, int.Parse(maphg_cb.Text)).ToString();
                maphieu_cb.DataSource = LienPhieuSuDungDichVu.Phieu_CMND(cmnd_tb.Text, int.Parse(maphg_cb.Text));
                maphieu_cb.DisplayMember = "MaPhieu";
                maphieu_cb.Text = "";

            }
            catch
            {
                maphg_cb.DataSource = null;
            }
        }

        private void maphieu_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gia_datphg;
            int gia_dv;
            try
            {
                gia_datphg = PhieuDatPhong.LayGia(cmnd_tb.Text, int.Parse(maphg_cb.Text));
                gia_dv = LienPhieuSuDungDichVu.LayGia(Login.conn, int.Parse(maphieu_cb.Text));
            }
            catch
            {
                gia_datphg = 0;
                gia_dv = 0;
            }
            gia_tb.Text = (gia_datphg + gia_dv).ToString();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            HoaDon hd;
            if(maphieu_cb.Text != "")
            {
                hd = new HoaDon(0, int.Parse(maphg_cb.Text), cmnd_tb.Text, int.Parse(maphieu_cb.Text), int.Parse(gia_tb.Text));
            }
            else
            {
                hd = new HoaDon(0, int.Parse(maphg_cb.Text), cmnd_tb.Text, 0, int.Parse(gia_tb.Text));
            }
            if (HoaDon.Them(Login.conn, hd))
            {
                MessageBox.Show("Thanh toan thanh cong");
                maphg_cb.Text = "";
                maphieu_cb.Text = "";
                cmnd_tb.Text = "";
                gia_tb.Text = "";
                hinhthuc_cb.Text = "";
                stk_tb.Text = "";
            }
            else
            {
                MessageBox.Show("Thanh toan that bai");
            }
        }
    }
}
