using HotelManagement.Bussiness_Layer;
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
            string sql;
            if(hd.MaPhieu != 0)
            {
                sql = "insert into HoaDon values(" + hd.MaPhong + ", '" + hd.CMND + "', " + hd.MaPhieu + ", " + hd.TongGia + ")";
            }
            else
            {
                sql = "insert into HoaDon values(" + hd.MaPhong + ", '" + hd.CMND + "', null, " + hd.TongGia + ")";
            }
            //query truy vấn

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
    }
}
