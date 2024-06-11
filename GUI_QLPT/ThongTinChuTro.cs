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
    public partial class ThongTinChuTro : Form
    {
        private int IDCHUTRO = ChuTroMain.IDCHUTRO;
        public ThongTinChuTro()
        {
            InitializeComponent();
            SetInfo();
        }
        private void SetInfo()
        {
            DataTable dtChuTro = BUS_ChuTro.Instance.GetChuTroByID(IDCHUTRO.ToString());

            // Kiểm tra xem DataTable có dữ liệu không
            if (dtChuTro != null && dtChuTro.Rows.Count > 0)
            {
                // Lấy dòng đầu tiên của kết quả trả về
                DataRow row = dtChuTro.Rows[0];

                // Gán giá trị cho các trường TextBox
                txtTen.Text = row["TenChuTro"].ToString();
                txtSDT.Text = row["SoDienThoai"].ToString();
                txtEmail.Text = row["Email"].ToString();
            }
            else
            {
                // Xử lý trường hợp không có dữ liệu
                MessageBox.Show("Không tìm thấy thông tin chủ trọ.");
                txtTen.Text = "";
                txtSDT.Text = "";
                txtEmail.Text = "";
            }
        }
        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string againPass = txtNewPassAgain.Text;
            string user = string.Empty;
            string pass = string.Empty;
            DataTable dt = new DataTable();

            dt = BUS_ChuTro.Instance.GetUserNameAndPassWordByID(IDCHUTRO.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                user = dr["TenTaiKhoan"].ToString();
                pass = dr["Password"].ToString();
            }
            bool insetFlag = false;
            if (!oldPass.Equals(pass))
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
            }
            else if (newPass.Equals(pass))
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!");
            }
            else if (newPass == "" || againPass == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ mật khẩu!");
            }
            else if (!newPass.Equals(againPass))
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
            }
            else if (MessageBox.Show("Bạn chắc chắn sẽ đổi mật khẩu ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pass = newPass;
                BUS_ChuTro.Instance.ThayDoiMatKhau(IDCHUTRO.ToString(), pass);
                DTO_TaiKhoan tk = new DTO_TaiKhoan(newPass, user, "9999", 0, insetFlag);
                BUS_TaiKhoan.Instance.Update(tk, IDCHUTRO.ToString());
                MessageBox.Show("Đổi mật khẩu thành công");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            string mail=txtEmail.Text;
            // Kiểm tra xem các trường dữ liệu có trống không
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt)||string.IsNullOrEmpty( mail))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Gọi hàm cập nhật thông tin khách hàng
             BUS_ChuTro.Instance.ThayDoiThongTin(ten, mail, sdt, IDCHUTRO.ToString());
             MessageBox.Show("Cập nhật thông tin thành công.");
        }
    }
}
