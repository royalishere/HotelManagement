using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DB_Access_Layer;

namespace HotelManagement.Business_Layer
{
    internal class Phong
    {
        public int MaPhong;
        public string MoTa;
        public string TinhTrang;
        public int Gia;
        public string LoaiPhong;
        public Phong(int maPhong, string moTa, string loaiPhong, int gia, string tinhTrang)
        {
            MaPhong = maPhong;
            MoTa = moTa;
            LoaiPhong = loaiPhong;
            Gia = gia;
            TinhTrang = tinhTrang;
        }

        public static DataTable XemDSPhongTrong()
        {
            return Phong_DB.XemDSPhongTrong();
        }

        public static int LayGia(int maphg)
        {
            return Phong_DB.LayGia(maphg);
        }

        public static bool CapNhatTinhTrang(string tinhtrang, int maphg)
        {
            return Phong_DB.CapNhatTinhTrang(tinhtrang, maphg);
        }

        public static bool CapNhatGia(int gia, int maphg)
        {
            return Phong_DB.CapNhatGia(gia, maphg);
        }

        public static DataTable LoadPhong()
        {
            return Phong_DB.LoadPhong();
        }
    }
}
