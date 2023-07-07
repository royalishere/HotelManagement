using HotelManagement.DB_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Business_Layer
{
    internal class Tour
    {
        int MaTour;
        string TenTour;
        string DiaDiem;
        int Gia;
        DateTime ThoiDiemBatDau;
        DateTime ThoiDiemKetThuc;
        int MaDonVi;

        public static DataTable LayDSTour()
        {
            return Tour_DB.LayDSTour(Login.conn);
        }

        public static int LayGia(SqlConnection conn, int maDV) 
        {
           return Tour_DB.LayGia(conn, maDV);
        }

        public static int LayMaDonVi(int maDV)
        {
            return Tour_DB.LayMaDonVi(maDV);
        }

        public static DataTable Tour_DiaDiem(string diadiem)
        {
            return Tour_DB.Tour_DiaDiem(diadiem);
        }
    }


}
