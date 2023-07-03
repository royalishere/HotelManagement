using HotelManagement.DB_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Business_Layer
{
    internal class LienPhieuSuDungDichVu
    {
        public int MaPhieu;
        public string CMND;
        public int MaPhong;
        public int MaDV;
        public int SoLuong;
        public int Gia;

        public LienPhieuSuDungDichVu(string cmnd, int mph, int mdv, int sl, int g)
        {
            CMND = cmnd;
            MaPhong = mph;
            MaDV = mdv;
            SoLuong = sl;
            Gia = g;
        }

        public static bool Them(string cmnd, int mph, int mdv, int sl, int g)
        {
            return LienPhieuSuDungDichVu_DB.Them(Login.conn, cmnd, mph, mdv, sl, g);
        }
    }
}
