using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DB_Access_Layer
{
    internal class KhachHang_DB
    {
        public static DataTable Lay_CMND(SqlConnection conn) 
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "select * from KhachHang";

            //Kết nối cơ sở dữ liệu
            dap.SelectCommand.Connection = conn;
            dap.SelectCommand.CommandText = sql;

            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
    }
}
