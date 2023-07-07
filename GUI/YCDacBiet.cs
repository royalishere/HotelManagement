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

namespace HotelManagement.GUI
{
    public partial class YCDacBiet : Form
    {

        public YCDacBiet()
        {
            InitializeComponent();
        }

        private void YCDacBiet_Load(object sender, EventArgs e)
        {
            ycdb_dg.DataSource = PhieuDatPhong.LoadYCDB();
        }

        public void YCDacBiet_getInfo(string cmnd, string tenkh, string maphg)
        {
            cmnd_tb.Text = cmnd;
            tenkh_tb.Text = tenkh;
            maphg_tb.Text = maphg;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            UC_PhieuDatPhong.ycdb = ycdb_tb.Text;
            this.Close();
        }
    }
}
