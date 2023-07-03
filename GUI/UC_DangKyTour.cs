using HotelManagement.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement
{
    public partial class UC_DangKyTour : UserControl
    {
        public UC_DangKyTour()
        {
            InitializeComponent();
        }

        private void UC_DangKyTour_Load(object sender, EventArgs e)
        {
            DataTable dt= Tour.LayDSTour();
            dgv_dsTour.DataSource = dt;

            cbb_tour.DataSource = dt;
            cbb_tour.DisplayMember = "MaTour";
        }

        private void cbb_tour_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_dkTour_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_cmnd.Text))
            {
                MessageBox.Show("Vui long nhap CMND");
                return;
            }

            int MaTour = Int32.Parse(cbb_tour.Text);

            if (KhachHang_Tour.Them(tb_cmnd.Text, MaTour))
            {
                MessageBox.Show("Dang ky thanh cong");
            }
            else MessageBox.Show("Khong dang ky duoc");

        }
    }
}
