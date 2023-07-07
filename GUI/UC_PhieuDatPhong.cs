using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Business_Layer;
using HotelManagement.Bussiness_Layer;
using HotelManagement.GUI;

namespace HotelManagement
{
    public partial class UC_PhieuDatPhong : UserControl
    {
        private static UC_PhieuDatPhong instance;
        public static string ycdb;
        public UC_PhieuDatPhong()
        {
            InitializeComponent();
        }

        public static UC_PhieuDatPhong getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new UC_PhieuDatPhong();
            }
            return instance;
        }

        private void UC_PhieuDatPhong_Load(object sender, EventArgs e)
        {
            ngayden_dpk.Value = DateTime.Now;
            maphong_cb.DataSource = Phong.XemDSPhongTrong();
            maphong_cb.DisplayMember = "MaPhong";
            phieudatphong_dg.DataSource = PhieuDatPhong.LoadPhieuDatPhong();

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string cmnd = cmnd_tb.Text;
            string tenkh = tenkh_tb.Text;
            string sdt = sdt_tb.Text;
            string email = email_tb.Text;
            int maphong = int.Parse(maphong_cb.Text);
            string ngayden = ngayden_dpk.Text;
            int sodem = int.Parse(sodem_tb.Text);
            KhachHang k = new KhachHang(cmnd, tenkh, sdt, email);
            PhieuDatPhong p = new PhieuDatPhong(cmnd, maphong , ngayden, sodem, ycdb, int.Parse(gia_tb.Text)); 
            if(KhachHang.Them(k) && PhieuDatPhong.ThemPD(p))
            {
                Phong.CapNhatTinhTrang("da dat", maphong);
                MessageBox.Show("Thêm thông tin đặt phòng thành công");
                UC_PhieuDatPhong_Load(null, null);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra thông tin");
            }
                ycdb = null;
        }

        private void sodem_tb_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int gia_phong = Phong.LayGia(int.Parse(maphong_cb.Text));
                int songay = int.Parse(sodem_tb.Text);
                gia_tb.Text = (gia_phong * songay).ToString();
            }
            catch
            {
                gia_tb.Text = null;
            }
        }

        private void sp_order_btn_Click(object sender, EventArgs e)
        {
            YCDacBiet ycdb = new YCDacBiet();
            ycdb.YCDacBiet_getInfo(cmnd_tb.Text, tenkh_tb.Text, maphong_cb.Text);
            ycdb.ShowDialog();
        }
    }
}
