using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Business_Layer;
using HotelManagement.Bussiness_Layer;

namespace HotelManagement
{
    public partial class uc_ThongTinPhong : UserControl
    {
        public uc_ThongTinPhong()
        {
            InitializeComponent();
        }

        private void uc_ThongTinPhong_Load(object sender, EventArgs e)
        {
            ttphong_dg.DataSource = Phong.LoadPhong();
        }

        private void ttphong_dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                maphg_tb.Text = ttphong_dg.Rows[e.RowIndex].Cells[0].Value.ToString();
                mota_tb.Text = ttphong_dg.Rows[e.RowIndex].Cells[1].Value.ToString();
                tinhtrang_cb.Text = ttphong_dg.Rows[e.RowIndex].Cells[2].Value.ToString();
                giaphg_tb.Text = ttphong_dg.Rows[e.RowIndex].Cells[3].Value.ToString();
                loaiphg_tb.Text = ttphong_dg.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tinhtrang = tinhtrang_cb.Text;
            int gia = int.Parse(giaphg_tb.Text);
            int maphg = int.Parse(maphg_tb.Text);
            if (Phong.CapNhatTinhTrang(tinhtrang, maphg) && Phong.CapNhatGia(gia, maphg))
            {
                MessageBox.Show("Cập nhật thành công");
                ttphong_dg.DataSource = Phong.LoadPhong();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
