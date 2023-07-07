using HotelManagement.Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.DB_Access_Layer
{
    internal class PhieuDatPhong_DB
    {
        public static bool ThemPD(PhieuDatPhong pdp)
        {
            string sql = "insert into PhieuDatPhong values ("+pdp.MaPhong+", '"+pdp.CMND+"', '"+pdp.NgayDen+"', " + pdp.SoDemLuuTru + ", '"+pdp.YeuCauDacBiet+"', "+pdp.Gia+")";
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static DataTable LoadPhieuDatPhong()
        {
            string sql = "select k.CMND, k.TenKH, k.Email, k.SoDienThoai, p.MaPhong, p.NgayDen, p.SoDemLuuTru, p.YeuCauDacBiet, p.Gia  from KhachHang k join PhieuDatPhong p on k.CMND = p.CMND";
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                table.Load(reader);
                return table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable LoadYCDB()
        {
            string sql = "select k.CMND, k.TenKH, p.YeuCauDacBiet from KhachHang k join PhieuDatPhong p on k.CMND = p.CMND";
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                table.Load(reader);
                return table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable Phong_CMND(string cmnd)
        {
            string sql = "select maphong from PhieuDatPhong where cmnd = '" + cmnd + "'";
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                table.Load(reader);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static int LayGia(string cmnd , int maphg)
        {
            string sql = "select Gia from PhieuDatPhong where cmnd = '" + cmnd + "' and maphong = " + maphg;
            SqlCommand cmd = new SqlCommand(sql, Login.conn);
            try
            {
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
