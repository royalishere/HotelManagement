using HotelManagement.Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.DB_Access_Layer
{
    internal class LienPhieuSuDungDichVu_DB
    {
        public static DataTable LoadPhieuSuDungDichVu()
        {
            string sql = "select * from LienPhieuSuDungDichVu";
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            DataTable table = new DataTable();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
                return table;
            }
            catch
            {
                return null;
            }
        }

        public static bool Them(SqlConnection conn, string CMND, int MaPhong, int MaDV, int SoLuong, int Gia)
        {
            string sql = "insert into LienPhieuSuDungDichVu (CMND, MaPhong, MaDichVu, SoLuong, Gia) values ('" + CMND + "', " + MaPhong + ", " + MaDV + ", " + SoLuong + ", " + Gia + ")";
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable Phieu_CMND(SqlConnection conn, string cmnd, int maphg)
        {

            string sql = "select * from LienPhieuSuDungDichVu where cmnd ='" + cmnd + "' and maphong = " + maphg;
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            DataTable table = new DataTable();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
                return table;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int LayGia(SqlConnection conn, int MaPhieu)
        {
            //query truy vấn
            string sql = "select Gia from LienPhieuSuDungDichVu where MaPhieu=" + MaPhieu;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                return (int)cmd.ExecuteScalar();
            }
            catch
            {
                return 0;
            }
        }
    }
}
