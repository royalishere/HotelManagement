using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using HotelManagement.DB_Access_Layer;

namespace HotelManagement.Business_Layer
{
    internal class KhachHang
    {
        public string CMND;
        public string TenKH;
        public string SDT;
        public string Email;

        public KhachHang(string cmnd, string tenkh, string sdt, string email)
        {
            CMND = cmnd;
            TenKH = tenkh;
            SDT = sdt;
            Email = email;
        }

        public static bool Them(KhachHang k)
        {
            if(!KiemTraTonTai(k.CMND))
            {
                return KhachHang_DB.Them(k);
            }
            return true;
        }

        public static bool KiemTraTonTai(string CMND)
        {
            string[] cmnd_kh = KhachHang_DB.Lay_CMND();
            foreach (string cmnd in cmnd_kh)
            {
                if (cmnd == CMND)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
