using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DB_Access_Layer
{
    internal class DichVu_DB
    {
        public static DataTable LaDSDichVu(SqlConnection conn)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "select * from SanPhamDichVu";

            //Kết nối cơ sở dữ liệu
            dap.SelectCommand.Connection = conn;
            dap.SelectCommand.CommandText = sql;

            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }

        public static int LayGia(SqlConnection conn, int MaDV)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "select Gia from SanPhamDichVu where MaSPDV = " + MaDV;

            //Kết nối cơ sở dữ liệu
            dap.SelectCommand.Connection = conn;
            dap.SelectCommand.CommandText = sql;

            DataTable table = new DataTable();
            dap.Fill(table);

            if (table.Rows.Count == 0)
            {
                return -1;
            }

            return table.Rows[0].Field<int>(0);
        }
    }
}
