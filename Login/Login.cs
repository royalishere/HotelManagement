using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HotelManagement
{
    public partial class Login : Form
    {
        System.Threading.Thread th;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new System.Threading.Thread(open_starterform);
            th.SetApartmentState(System.Threading.ApartmentState.STA);
            th.Start();

        }

        private void open_starterform()
        {
            Application.Run(new PhieuDatPhong());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Quen_MK f = new Quen_MK();
            f.ShowDialog();
        }
    }
}
