using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DB_Access_Layer
{
    internal class Phong_DB
    {
        public static DataTable XemDSPhongTrong(SqlConnection conn)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "select * from Phong where TinhTrang = 'trong'";

            //Kết nối cơ sở dữ liệu
            dap.SelectCommand.Connection = conn;
            dap.SelectCommand.CommandText = sql;

            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
        public static bool CapNhatTinhTrang(SqlConnection conn, string TinhTrang, int MaPhong)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "update Phong set TinhTrang='" + TinhTrang + "' where MaPhong = " + MaPhong;

            //Kết nối cơ sở dữ liệu
            dap.SelectCommand.Connection = conn;
            dap.SelectCommand.CommandText = sql;

            int i = dap.SelectCommand.ExecuteNonQuery();

            if (i > 0)
            {
                return true;
            }

            return false;
        }
    }
}
