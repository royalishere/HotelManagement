using HotelManagement.UseCase_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DB_Access_Layer
{
    internal class HoaDon_DB
    {
        public static bool ThemHoaDon(SqlConnection conn, HoaDon hd)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "insert into HoaDon values(" + hd.MaHoaDon + ", " + hd.MaPhong + ", '" + hd.CMND + "', " + hd.MaPhieu + ", " + hd.TongGia + ")";

            //Kết nối cơ sở dữ liệu
            dap.SelectCommand.Connection = conn;
            dap.SelectCommand.CommandText = sql;

            int i = dap.SelectCommand.ExecuteNonQuery();

            if ( i > 0 )
            {
                return true;
            }

            return false;
        }

        public static int LayGia(SqlConnection conn, int MaPhieu, int PDP)
        {
            return 0; // tam thoi
        }
    }
}
