using HotelManagement.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Ke_toan : Form
    {
        Thread t;
        public Ke_toan()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(() => Application.Run(new Login()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void Ke_toan_Load(object sender, EventArgs e)
        {
            lienphieu_dg.DataSource = LienPhieuSuDungDichVu.LoadPhieuSuDungDichVu();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                lienphieu_dg.DataSource = LienPhieuSuDungDichVu.Phieu_CMND(cmnd_tb.Text, int.Parse(ma_phg.Text));
            }
            catch
            {
                Ke_toan_Load(null, null);
            }
        }
    }
}
