using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DB_Access_Layer;

namespace HotelManagement.Bussiness_Layer
{
    internal class NhanVien
    {
        string MaNV = "";
        string TenNV = "";
        string LoaiNV = "";
        DateTime NgaySinh;

        public static string LayLoaiNV()
        {
            return NhanVien_DB.LayLoaiNV();
        }
    }
}
