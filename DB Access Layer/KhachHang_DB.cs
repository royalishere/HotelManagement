using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Business_Layer;
using HotelManagement.Bussiness_Layer;

namespace HotelManagement.DB_Access_Layer
{
    internal class KhachHang_DB
    {
        public static string[] Lay_CMND() 
        {
            //query truy vấn
            string sql = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            string[] CMND = new string[200];
            int i = 0;
            while (reader.Read())
            {
                CMND[i] = reader.GetString(0);
                i++;
            }
            reader.Close();
            return CMND;
        }

        public static bool Them(KhachHang k)
        {
            string sql = "insert into KhachHang values ('" + k.CMND + "', '" + k.TenKH + "', '" + k.SDT + "', '" + k.Email + "')";
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                MessageBox.Show("Không thành công. Kiểm tra chứng minh nhân dân");
                return false;
            }
        }
    }
}
