using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DB_Access_Layer;
using HotelManagement.Bussiness_Layer;
using HotelManagement.Business_Layer;

namespace HotelManagement.Bussiness_Layer
{
    internal class PhieuDatPhong
    {
        public string CMND;
        public int MaPhong;
        public string NgayDen;
        public int SoDemLuuTru;
        public string YeuCauDacBiet;
        public int Gia;

        public PhieuDatPhong(string cmnd, int maPhong, string ngayDen, int soDemLuuTru, string yeuCauDacBiet, int gia)
        {
            CMND = cmnd;
            MaPhong = maPhong;
            NgayDen = ngayDen;
            SoDemLuuTru = soDemLuuTru;
            YeuCauDacBiet = yeuCauDacBiet;
            Gia = gia;
        }

        public static DataTable LoadPhieuDatPhong()
        {
            return PhieuDatPhong_DB.LoadPhieuDatPhong();
        }

        public static bool ThemPD(PhieuDatPhong pdp)
        {
            return PhieuDatPhong_DB.ThemPD(pdp);
        }

        public static DataTable LoadYCDB()
        {
            return PhieuDatPhong_DB.LoadYCDB();
        }
    }
}
