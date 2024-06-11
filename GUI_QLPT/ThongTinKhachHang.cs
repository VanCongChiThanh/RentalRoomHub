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
    public partial class ThongTinKhachHang : Form
    {
        private int IDKhach = KhachTroMain.IDKhach;
        private string Password=KhachTroMain.pass;
        private string UserName = KhachTroMain.user;
        public ThongTinKhachHang()
        {
            InitializeComponent();
            SetInfo();
        }
        public void SetInfo()
        {
            DataTable dtKhachHang = BUS_KhachHang.Instance.GetKhachHangByID(IDKhach);

            // Kiểm tra xem DataTable có dữ liệu không
            if (dtKhachHang != null && dtKhachHang.Rows.Count > 0)
            {
                // Lấy dòng đầu tiên của kết quả trả về
                DataRow row = dtKhachHang.Rows[0];

                // Gán giá trị cho các trường TextBox
                txtTen.Text = row["TenKhachHang"].ToString();
                txtSDT.Text = row["SoDienThoai"].ToString();
                txtCCCD.Text = row["CCCD"].ToString();
                txtDiaChi.Text = row["DiaChi"].ToString();
                KhachTroMain.IDPhong = row["MaPhong"].ToString();
            }
            else
            {
                // Xử lý trường hợp không có dữ liệu
                MessageBox.Show("Không tìm thấy thông tin khách hàng.");
                txtTen.Text = "";
                txtSDT.Text = "";
                txtCCCD.Text = "";
                txtDiaChi.Text = "";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            string cccd = txtCCCD.Text;
            string diachi = txtDiaChi.Text;
            int idKhach = IDKhach; // Giả sử IDKhach là biến đã được khai báo và lưu ID khách hàng

            // Kiểm tra xem các trường dữ liệu có trống không
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Gọi hàm cập nhật thông tin khách hàng
            bool result = BUS_KhachHang.Instance.UpdateThongTin(ten, cccd, sdt, diachi, idKhach);

            // Kiểm tra kết quả của việc cập nhật
            if (result)
            {
                MessageBox.Show("Cập nhật thông tin thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại.");
            }
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            string oldpass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string againPass = txtNewPassAgain.Text;

            // Kiểm tra mật khẩu cũ có khớp với mật khẩu hiện tại không
            if (!oldpass.Equals(Password))
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
                txtOldPass.Clear();
                txtNewPass.Clear();
                txtNewPassAgain.Clear();
                return;  // Dừng việc xử lý tiếp theo
            }

            DataTable dt = BUS_TaiKhoan.Instance.GetLogin(UserName, Password);
            string id = dt.Rows[0]["ID_TaiKhoan"].ToString();
            string pass = dt.Rows[0]["Password"].ToString();
            string ten = dt.Rows[0]["TenTaiKhoan"].ToString();
            string quyen = dt.Rows[0]["Quyen"].ToString();
            int Flg = 6666;
            bool insetFlag = false;

            if (newPass.Equals(pass))
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!");
            }
            else if (newPass == "" || againPass == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ mật khẩu mới và nhập lại mật khẩu mới!");
            }
            else if (!newPass.Equals(againPass))
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
            }
            else if (MessageBox.Show("Bạn chắc chắn sẽ đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Cập nhật mật khẩu trong cơ sở dữ liệu
                BUS_KhachHang.Instance.ThayDoiUserNamePassWord(newPass, ten, Password);
                DTO_TaiKhoan tk = new DTO_TaiKhoan(newPass, ten, quyen, Flg, insetFlag);
                BUS_TaiKhoan.Instance.Update(tk, id);
                Password = newPass;
                MessageBox.Show("Đổi mật khẩu thành công");
            }
        }

    }
}
