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

namespace HotelManagement
{
    public partial class UC_DangKyDichVu : UserControl
    {
        public UC_DangKyDichVu()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UC_DangKyDichVu_Load(object sender, EventArgs e)
        {
            DataTable dt = DichVu.LayDSDichVu();
            dgv_DSdichvu.DataSource = dt;

            cbb_DV.DataSource = dt;
            cbb_DV.DisplayMember = "MaSPDV";
        }


    }
}
