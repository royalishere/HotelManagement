using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Le_tan_main_form : Form
    {
        public Le_tan_main_form()
        {
            InitializeComponent();
        }
        private void Le_tan_main_form_Load(object sender, EventArgs e)
        {
            
        }

        private void addUserControl(UserControl UC)
        {
            UC.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC);
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
            uc_ThongTinDatPhong uc = new uc_ThongTinDatPhong();
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
    }
}
