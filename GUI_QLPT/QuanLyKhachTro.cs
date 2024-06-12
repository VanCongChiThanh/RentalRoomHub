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
    public partial class QuanLyKhachTro : Form
    {
        string IDTRO=ChuTroMain.IDTRO;
        public QuanLyKhachTro()
        {
            InitializeComponent();
            this.InitComboBoxTabKhachHang();
            txtTenKhachHang.KeyDown += TextBox_KeyDown;
            txtCMNN.KeyDown += TextBox_KeyDown;
            txtSdt.KeyDown += TextBox_KeyDown;
            txtDiaChi.KeyDown += TextBox_KeyDown;
            txtTenTaiKhoan.KeyDown += TextBox_KeyDown;
            txtPassWord.KeyDown += TextBox_KeyDown;
            txtTimKiemKH.KeyDown += TxtTimKiemKH_KeyDown;
        }
        private void TxtTimKiemKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn chặn dấu beep
                TimKiemKhachHang(); // Thực hiện tìm kiếm
            }
        }
        private void TimKiemKhachHang()
        {
            string searchKeyWord = txtTimKiemKH.Text;
            if (!string.IsNullOrEmpty(searchKeyWord))
            {
                dataGridViewKhachHang.DataSource = BUS_KhachHang.Instance.GetThongTinKhachHangByTen(searchKeyWord,IDTRO);
            }
            else
            {
                dataGridViewKhachHang.DataSource = BUS_Phong.Instance.GetThongTinKhachHang(IDTRO);
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;  // Ngăn chặn tiếng "beep" khi nhấn enter
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void InitComboBoxTabKhachHang()
        {
            var trangThaiPhi = new BindingList<KeyValuePair<string, string>>();
            trangThaiPhi.Add(new KeyValuePair<string, string>("", " --- Phòng --- "));
            DataTable a = BUS_Phong.Instance.GetPhongByidTro(IDTRO);
            foreach (DataRow row in a.Rows)
            {
                trangThaiPhi.Add(new KeyValuePair<string, string>(row["ID_Phong"].ToString(), row["TenPhong"].ToString()));
            }
            this.cbPhong.DataSource = trangThaiPhi.ToArray();
            this.cbPhong.ValueMember = "Key";
            this.cbPhong.DisplayMember = "Value";
            this.cbPhong.SelectedIndex = 0;

            dataGridViewKhachHang.DataSource = BUS_Phong.Instance.GetThongTinKhachHang(IDTRO);
        }
        private bool IsValidPhoneNumber(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenKhachHang.Text.Trim();
            string cccd = txtCMNN.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string phong = cbPhong.SelectedValue.ToString();
            string tk = txtTenTaiKhoan.Text.Trim();
            string pass = txtPassWord.Text.Trim();

            // Input validation
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(phong) || string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPhoneNumber(sdt))
            {
                MessageBox.Show("Số điện thoại phải là 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation dialog
            if (MessageBox.Show("Bạn muốn thêm khách hàng " + ten + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    DataTable dt = BUS_KhachHang.Instance.GetKhachHangByIdPhong(phong);
                    if (dt.Rows.Count < 1)
                    {
                        BUS_Phong.Instance.UpdateTrangThai(phong, 1);
                    }

                    DTO_TaiKhoan taikhoan = new DTO_TaiKhoan(pass, tk, "6666", 0, true);
                    DTO_KhachHang kh = new DTO_KhachHang(ten, tk, pass, cccd, sdt, 0, diachi, true, phong);
                    BUS_TaiKhoan.Instance.Update(taikhoan, "");
                    BUS_KhachHang.Instance.Update(kh, "");

                    MessageBox.Show("Thêm khách hàng thành công");
                    dataGridViewKhachHang.DataSource = BUS_Phong.Instance.GetThongTinKhachHang(IDTRO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnResert_Click(object sender, EventArgs e)
        {
            dataGridViewKhachHang.DataSource = BUS_Phong.Instance.GetThongTinKhachHang(IDTRO);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dataGridViewKhachHang.SelectedRows[0].Cells["ID"].Value.ToString();
            string tk = dataGridViewKhachHang.SelectedRows[0].Cells["Tài khoản"].Value.ToString();
            string pass = dataGridViewKhachHang.SelectedRows[0].Cells["Mật khẩu"].Value.ToString();
            string maphong = dataGridViewKhachHang.SelectedRows[0].Cells["Phòng"].Value.ToString();
            if (BUS_KhachHang.Instance.GetUserNameAndPassWordByMaPhong(maphong).Rows.Count == 1)
            {
                MessageBox.Show("Phòng này hiện chỉ có 1 người, để trả trọ vui lòng qua chức năng trả trọ");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa khách hàng " + dataGridViewKhachHang.SelectedRows[0].Cells["Tên khách hàng"].Value.ToString() + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    BUS_KhachHang.Instance.Delete(id);
                    BUS_TaiKhoan.Instance.DeleteByUserNameAndPassword(tk, pass);
                    DataTable dt = BUS_KhachHang.Instance.GetKhachHangByIdPhong(maphong);
                    if (dt.Rows.Count < 1)
                    {
                        BUS_Phong.Instance.UpdateTrangThai(maphong, 0);
                    }
                    dataGridViewKhachHang.DataSource = BUS_Phong.Instance.GetThongTinKhachHang(IDTRO);
                }
            }
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> selectedKeyValuePair = (KeyValuePair<string, string>)this.cbPhong.SelectedItem;
            int id;
            if (int.TryParse(cbPhong.SelectedValue.ToString(), out id))
            {
                DataTable a = BUS_LoaiPhong.Instance.GetThongTinPhong(id.ToString());
                foreach (DataRow dr in a.Rows)
                {
                    txtLoaiPhong.Text = dr["TenLoaiPhong"].ToString();
                    txtGia.Text = dr["Gia"].ToString();
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            TimKiemKhachHang();
        }
    }
}
