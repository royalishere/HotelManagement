using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DB_Access_Layer;

namespace HotelManagement.Bussiness_Layer
{
    internal class PhieuDatPhong
    {
        public int MaPhong;
        public string CMND;
        public DateTime NgayDen;
        public int SoDemLuuTru;
        public string YeuCauDacBiet;
        public int Gia;

        public static DataTable LoadPhieuDatPhong()
        {
            return PhieuDatPhong_DB.LoadPhieuDatPhong();
        }
    }
}
