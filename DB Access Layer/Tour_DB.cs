using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DB_Access_Layer
{
    internal class Tour_DB
    {

        public static DataTable LayDSTour(SqlConnection conn)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "select * from TourDuLich";

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
            string sql = "select Gia from TourDuLich where MaTour = " + MaDV;

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

        public static int LayMaDonVi(int MaDV)
        {
            string sql = "select MaDonVi from TourDuLich where MaTour = " + MaDV;
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            return (int)cmd.ExecuteScalar();
        }

        public static DataTable Tour_DiaDiem(string DiaDiem)
        {
            string sql = "select matour from TourDuLich where DiaDiem like '%" + DiaDiem + "%'";
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
