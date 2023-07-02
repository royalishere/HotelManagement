using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DB_Access_Layer
{
    internal class KhachHang_tour_DB
    {
        public static bool Them(SqlConnection conn, string CMND, int MaTour)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "insert into KhachHangTheoTour (MaTour, CMND) values (" + MaTour + ",'" + CMND + "')";

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
