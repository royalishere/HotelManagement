using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DB_Access_Layer;

namespace HotelManagement.Bussiness_Layer
{
    internal class HoaDon
    {
        public int MaHoaDon = 0;
        public int MaPhong = 0;
        public string CMND = "";
        public int MaPhieu = 0;
        public int TongGia = 0;

        public HoaDon(int maHoaDon, int maPhong, string cmnd, int maPhieu, int tongGia)
        {
            MaHoaDon = maHoaDon;
            MaPhong = maPhong;
            CMND = cmnd;
            MaPhieu = maPhieu;
            TongGia = tongGia;
        }

        public static bool Them(SqlConnection conn, HoaDon hd)
        {
            return HoaDon_DB.ThemHoaDon(conn, hd);
        }
    }

}
