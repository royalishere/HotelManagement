using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using HotelManagement.Bussiness_Layer;

namespace HotelManagement.DB_Access_Layer
{
    internal class NhanVien_DB
    {
        public static string LayLoaiNV()
        {
            string sql = "select LoaiNV from NhanVien where manv = SUSER_NAME()";
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            return cmd.ExecuteScalar().ToString();
        }
    }
}
