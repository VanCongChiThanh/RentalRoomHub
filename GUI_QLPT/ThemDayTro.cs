using BUS;
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
    public partial class ThemDayTro : Form
    {
        string IDCHUTRO = string.Empty;
        public ThemDayTro()
        {
            InitializeComponent();
        }
        public ThemDayTro(string IDChuTro)
        {
            InitializeComponent();
            IDCHUTRO = IDChuTro;

            // Đăng ký sự kiện KeyDown
            txtDiaChi.KeyDown += TextBox_KeyDown;
            txtGiaNuoc.KeyDown += TextBox_KeyDown;
            txtGiaDien.KeyDown += TextBox_KeyDown;
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Chuyển focus đến control tiếp theo
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;  // Ngăn không cho phát ra tiếng bíp khi nhấn Enter
            }
        }


        private void btnThemTro_Click(object sender, EventArgs e)
        {
            string diachi = txtDiaChi.Text.Trim();
            string giaDien = txtGiaNuoc.Text.Trim();  // Đảo ngược nhầm tên biến?
            string giaNuoc = txtGiaDien.Text.Trim();  // Đảo ngược nhầm tên biến?

            // Kiểm tra xem các trường bắt buộc có trống không
            if (string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(giaDien) || string.IsNullOrEmpty(giaNuoc))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Xác thực định dạng số (giả sử giá điện và giá nước phải là số)
            if (!decimal.TryParse(giaDien, out decimal parsedGiaDien) || !decimal.TryParse(giaNuoc, out decimal parsedGiaNuoc))
            {
                MessageBox.Show("Giá điện và giá nước phải là số.");
                return;
            }

            // Thêm dữ liệu vào database
            try
            {
                BUS_Tro.Instance.ThemDayTroMoi(IDCHUTRO, diachi, parsedGiaDien.ToString(), parsedGiaNuoc.ToString());
                MessageBox.Show("Thêm dãy trọ mới thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dãy trọ: " + ex.Message);
            }
        }

    }
}
