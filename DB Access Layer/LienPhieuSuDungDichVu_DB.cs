using HotelManagement.Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DB_Access_Layer
{
    internal class LienPhieuSuDungDichVu_DB
    {
        public static bool Them(SqlConnection conn, string CMND, int MaPhong, int MaDV, int SoLuong, int Gia)
        {
            string sql = "insert into LienPhieuSuDungDichVu (CMND, MaPhong, MaDichVu, SoLuong, Gia) values (" + CMND + ", " + MaPhong + ", " + MaDV + ", " + SoLuong + ", " + Gia + ")";
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool KTton_tai(SqlConnection conn, int MaPhieu)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "select * from LienPhieuSuDungDichVu where MaPhieu=" + MaPhieu;

            //Kết nối cơ sở dữ liệu
            dap.SelectCommand.Connection = conn;
            dap.SelectCommand.CommandText = sql;

            DataTable table = new DataTable();
            dap.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public static int LayGia(SqlConnection conn, int MaPhieu)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "select * from LienPhieuSuDungDichVu where MaPhieu=" + MaPhieu;

            //Kết nối cơ sở dữ liệu
            dap.SelectCommand.Connection = conn;
            dap.SelectCommand.CommandText = sql;

            DataTable table = new DataTable();
            dap.Fill(table);

            if(table.Rows.Count == 0)
            {
                return 0;
            }
            
            return table.Rows[0].Field<int>(0);
        }
    }
}
