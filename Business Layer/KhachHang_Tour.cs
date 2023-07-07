using HotelManagement.DB_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Business_Layer
{
    internal class KhachHang_Tour
    {
        public string CMND = "";
        public int MaTour = 0;

        public static bool Them(string CMND, int MaTour)
        {
            if (KhachHang_tour_DB.Them(Login.conn, CMND, MaTour)) 
            {
                return true;
            }
            return false;
        }
    }
}
