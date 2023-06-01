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
    public partial class PhieuDatPhong : Form
    {
        public PhieuDatPhong()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pn_intour.Visible = !pn_intour.Visible;
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTinPhong f = new ThongTinPhong();
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
        }
    }
}
