using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.Business_Layer;
using HotelManagement.Bussiness_Layer;

namespace HotelManagement.DB_Access_Layer
{
    internal class Phong_DB
    {
        public static DataTable XemDSPhongTrong()
        {
            string sql = "select * from Phong where TinhTrang = 'trong'";
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            DataTable table = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            return table;
        }
        public static bool CapNhatTinhTrang(string tinhtrang,  int maphg)
        {
            string sql = "update Phong set TinhTrang='" + tinhtrang + "' where MaPhong = " + maphg;
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool CapNhatGia(int gia, int maphg)
        {
            string sql = "update Phong set GiaPhong  ='" + gia + "' where MaPhong = " + maphg;
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static int LayGia(int maphg)
        {
            string sql = "select GiaPhong from Phong where MaPhong = " + maphg.ToString();
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            try
            {
                return (int)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static DataTable LoadPhong()
        {
            string sql = "select * from Phong";
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
