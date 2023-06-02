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
            panelContainer.Controls.Clear();
        }

        private void addUserControl(UserControl UC)
        {
            UC.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC);
            UC.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            uc_special_orders uc = new uc_special_orders();
            addUserControl(uc);
        }
    }
}
