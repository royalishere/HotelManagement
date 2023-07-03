using HotelManagement.UseCase_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DB_Access_Layer
{
    internal class PhieuDatPhong_DB
    {
        public static bool ThemPD(SqlConnection conn ,PhieuDatPhong pdp)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "insert into PhieuDatPhong values ("+pdp.MaPhong+", "+pdp.CMND+", "+pdp.NgayDen+", "+pdp.SoDemLuuTru+", null, "+pdp.Gia+")";

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
        public static bool ThemYCDB(SqlConnection conn, string ycdb, string CMND, int MaPhong)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "update PhieuDatPhong set YeuCauDacBiet=" + ycdb + " where MaPhong = " + MaPhong + " and CMND = '" + CMND + "'";

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
        public static bool KTton_tai(SqlConnection conn, string CMND, int MaPhong)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "select * from PhieuDatPhong where MaPhong=" + MaPhong + " and CMND='" + CMND + "'";

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

        public static DateTime LayNgay(SqlConnection conn, string CMND, int MaPhong)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //query truy vấn
            string sql = "select * from PhieuDatPhong where MaPhong=" + MaPhong + " and CMND='" + CMND + "'";

            //Kết nối cơ sở dữ liệu
            dap.SelectCommand.Connection = conn;
            dap.SelectCommand.CommandText = sql;

            DataTable table = new DataTable();
            dap.Fill(table);

            return table.Rows[0].Field<DateTime>(0);
        }
    }
}
