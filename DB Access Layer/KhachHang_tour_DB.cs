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
            string sql = "insert into KhachHangTheoTour (MaTour, CMND) values (" + MaTour + ",'" + CMND + "')";
            dap.SelectCommand = new SqlCommand(sql, Login.conn);

            int i = dap.SelectCommand.ExecuteNonQuery();

            if (i > 0)
            {
                return true;
            }
            return false;
        }
    }
}
