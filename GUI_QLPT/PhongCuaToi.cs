using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPT
{
    public partial class PhongCuaToi : Form
    {
        private string IDTro = string.Empty;
        public PhongCuaToi()
        {
            InitializeComponent();
        }

        private void PhongCuaToi_Load(object sender, EventArgs e)
        {
            string IDChuTro = string.Empty;
            DataTable dtPhong = new DataTable();
            dtPhong = BUS_Phong.Instance.GetPhongByID(KhachTroMain.IDPhong);
            if (dtPhong != null && dtPhong.Rows.Count > 0)
            {
                // Lấy dòng đầu tiên của kết quả trả về
                DataRow rowPhong = dtPhong.Rows[0];
                string IDTro = rowPhong["ID_Tro"].ToString();

                DataTable dtTro = new DataTable();
                dtTro = BUS_Tro.Instance.GetTroByID(IDTro);
                if (dtTro != null && dtTro.Rows.Count > 0)
                {
                    // Lấy dòng đầu tiên của kết quả trả về từ dtTro
                    DataRow rowTro = dtTro.Rows[0];

                    // Cập nhật các thông tin về trọ vào các TextBox
                    txtTro.Text = rowTro["DiaChi"].ToString();  // Hiển thị địa chỉ trọ
                    txtGiaDien.Text = rowTro["DonGiaDien"].ToString();  // Hiển thị đơn giá điện
                    txtGiaNuoc.Text = rowTro["DonGiaNuoc"].ToString();  // Hiển thị đơn giá nước
                    IDChuTro = rowTro["ID_ChuTro"].ToString();  // Lấy ID của chủ trọ
                    txtDiaChi.Text = "Phòng "+rowPhong["TenPhong"].ToString() + "-" + rowTro["DiaChi"].ToString();
                    txtTienPhong.Text = rowPhong["Gia"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin trọ.");
                }

                DataTable dtChuTro = new DataTable();
                dtChuTro = BUS_ChuTro.Instance.GetChuTroByID(IDChuTro);
                if (dtChuTro != null && dtChuTro.Rows.Count > 0)
                {
                    // Lấy dòng đầu tiên của kết quả trả về từ dtChuTro
                    DataRow rowChuTro = dtChuTro.Rows[0];
                    txtSDT.Text = rowChuTro["SoDienThoai"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin chủ trọ.");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin phòng.");
            }
        }

    }
}
