using HotelManagement.DB_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Business_Layer
{
    internal class DichVu
    {
        public int MaDV;
        public string TenDichVu;
        public string MoTa;
        public int Gia;

        public static DataTable LayDSDichVu()
        {
            return DichVu_DB.LaDSDichVu(Login.conn);

        }

        public static int LayGia(int MaDV)
        {
            return DichVu_DB.LayGia(Login.conn, MaDV);
        }
    }
}
