using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Threading;
using HotelManagement.DB_Access_Layer;

namespace HotelManagement
{
    public partial class Login : Form
    {
        public static SqlConnection conn;
        public string s_name = "HOANGGIA";// change this to your host name
        public string ins_name = "SQLEXPRESS"; 
        public string db_name = "QLKS";
        public static string u_role = "";
        Thread t;
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string ID = username_tb.Text;
            string pass = pass_tb.Text;
            if (connect(ID, pass))
            {
                u_role = NhanVien_DB.LayLoaiNV();
                if(u_role == "Le tan")
                {
                    t = new Thread(() => Application.Run(new Le_tan()));
                }
                else if(u_role == "Ke toan")
                {

                    t = new Thread(() => Application.Run(new Ke_toan()));
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập");
                    conn.Close();
                    return;
                }
                this.Close();
                t.SetApartmentState(System.Threading.ApartmentState.STA);
                t.Start();
            }
        }

        private bool connect(string ID, string pass)
        {
            string connString = @"Data Source=" + s_name + "\\" + ins_name + ";Initial Catalog=" + db_name + "; User ID=" + ID + "; Password=" + pass+";Pooling=false";
            conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string sql = "use QLKS";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
