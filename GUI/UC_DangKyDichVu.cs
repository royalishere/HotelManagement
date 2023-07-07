using HotelManagement.Business_Layer;
using HotelManagement.DB_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Bussiness_Layer;

namespace HotelManagement
{
    public partial class UC_DangKyDichVu : UserControl
    {
        public UC_DangKyDichVu()
        {
            InitializeComponent();
        }

        private void UC_DangKyDichVu_Load(object sender, EventArgs e)
        {
            DataTable dt = DichVu.LayDSDichVu();
            dgv_DSdichvu.DataSource = dt;
            cbb_DV.DataSource = dt;
            cbb_DV.DisplayMember = "MaSPDV";
        }

        private void bt_DKdichvu_Click(object sender, EventArgs e)
        {
            int sl = -1;

            if (string.IsNullOrEmpty(tb_CMND.Text))
            {
                MessageBox.Show("Vui long nhap CMND");
                return;

            } 
            else if (string.IsNullOrEmpty(phg_cb.Text))
            {
                MessageBox.Show("Vui long nhap MaPhong");
                return;

            }
            else if (string.IsNullOrEmpty(tb_soluong.Text))
            {
                MessageBox.Show("Vui long nhap dung so luong");
                return;
            }

            int MaDV = Int32.Parse(cbb_DV.Text);
            int MaPhong = Int32.Parse(phg_cb.Text);
            int gia = DichVu.LayGia(MaDV);
            sl = Int32.Parse(tb_soluong.Text);
            gia = gia * sl;

            if (LienPhieuSuDungDichVu.Them(tb_CMND.Text, MaPhong, MaDV, sl, gia))
            {
                MessageBox.Show("Dang ky thanh cong");
            }
            else
            {
                MessageBox.Show("Dang ky that bai");
            }

        }

        private void tb_CMND_Leave(object sender, EventArgs e)
        {
            phg_cb.DataSource = PhieuDatPhong.Phong_CMND(tb_CMND.Text);
            phg_cb.DisplayMember = "MaPhong";
            phg_cb.Text = "";
        }

        private void tb_soluong_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int gia = DichVu.LayGia(Int32.Parse(cbb_DV.Text)) * Int32.Parse(tb_soluong.Text);
                gia_tb.Text = gia.ToString();
            }
            catch
            {
                gia_tb.Text = "0";
            }
        }
    }
}
