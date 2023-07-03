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
    public partial class UC_PhieuDatPhong : UserControl
    {
        private static UC_PhieuDatPhong instance;
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
            phieudatphong_dg.DataSource = PhieuDatPhong.LoadPhieuDatPhong();
        }
    }
}
