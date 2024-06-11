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

    public partial class DangKiForm : Form
    {
        private LoginForm loginForm;
        public DangKiForm(LoginForm login)
        {
            InitializeComponent();
            InitializePlaceholderText();
            this.loginForm = login;
        }
        #region Design
        private void InitializePlaceholderText()
        {
            txtName.Tag = "Tên";
            txtName.Text = "Tên";
            txtName.ForeColor = Color.Gray;

            txtUserName.Tag = "Tên tài khoản";
            txtUserName.Text = "Tên tài khoản";
            txtUserName.ForeColor = Color.Gray;

            txtPassWord.Tag = "Mật khẩu";
            txtPassWord.Text = "Mật khẩu";
            txtPassWord.ForeColor = Color.Gray;
            txtPassWord.UseSystemPasswordChar = true;

            txtEmail.Tag = "Địa chỉ email";
            txtEmail.Text = "Địa chỉ email";
            txtEmail.ForeColor = Color.Gray;

            txtSDT.Tag = "Số điện thoại";
            txtSDT.Text = "Số điện thoại";
            txtSDT.ForeColor = Color.Gray;


        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            if (textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = Color.FromArgb(15, 94, 148);
                textBox.UseSystemPasswordChar = false;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.Gray;
                textBox.UseSystemPasswordChar = true; 
            }
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            // Chỉ bật dấu * khi người dùng bắt đầu nhập và không phải là placeholder
            textBox.UseSystemPasswordChar = textBox.Text != "" && textBox.Text != textBox.Tag.ToString();
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;  // Prevent beep sound on Enter press
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtName.Enter += TextBox_Enter;
            txtName.Leave += TextBox_Leave;
            txtName.KeyDown += TextBox_KeyDown;

            txtUserName.Enter += TextBox_Enter;
            txtUserName.Leave += TextBox_Leave;
            txtUserName.KeyDown += TextBox_KeyDown;

            txtPassWord.Enter += TextBox_Enter;
            txtPassWord.Leave += TextBox_Leave;
            txtPassWord.KeyDown += TextBox_KeyDown;

            txtEmail.Enter += TextBox_Enter;
            txtEmail.Leave += TextBox_Leave;
            txtEmail.KeyDown += TextBox_KeyDown;

            txtSDT.Enter += TextBox_Enter;
            txtSDT.Leave += TextBox_Leave;
            txtSDT.KeyDown += TextBox_KeyDown;


        }
        #endregion
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$");
        }

        private bool IsInputValid()
        {
            // Validate Name
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text == txtName.Tag.ToString())
            {
                MessageBox.Show("Tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Username
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || txtUserName.Text == txtUserName.Tag.ToString())
            {
                MessageBox.Show("Tên tài khoản không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(txtPassWord.Text) || txtPassWord.Text == txtPassWord.Tag.ToString())
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text == txtEmail.Tag.ToString() || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Phone Number
            if (string.IsNullOrWhiteSpace(txtSDT.Text) || txtSDT.Text == txtSDT.Tag.ToString() || !IsValidPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }



        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                return;  // Stop the method if validation fails
            }

            // Kiểm tra xem tên đăng nhập đã tồn tại chưa
            if (BUS_TaiKhoan.Instance.CheckConflict(txtUserName.Text))
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                return;
            }

            // Proceed with registration if no conflict and validation is successful
            BUS_ChuTro.Instance.DangKyTro(txtName.Text, txtEmail.Text, txtSDT.Text, txtPassWord.Text, txtUserName.Text);
            DTO_TaiKhoan dt = new DTO_TaiKhoan(txtPassWord.Text, txtUserName.Text, "9999", 0, true);
            BUS_TaiKhoan.Instance.Update(dt, "");
        }



        private void DangKiForm_Load(object sender, EventArgs e)
        {

        }

        private void lbLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Chỉ ẩn form này
            loginForm.ShowLoginForm(); // Gọi phương thức của LoginForm để hiển thị nó
        }
        private bool passwordVisible = false;  // Biến này lưu trạng thái hiển thị mật khẩu

        private void unhidePass_Click(object sender, EventArgs e)
        {
            // Đảo ngược trạng thái hiển thị mật khẩu
            passwordVisible = !passwordVisible;
            txtPassWord.UseSystemPasswordChar = !passwordVisible;

            // Cập nhật chú thích hoặc biểu tượng của nút, nếu cần
            unhidePass.Text = passwordVisible ? "Hide Password" : "Show Password";
            toolTip1.SetToolTip(unhidePass, passwordVisible ? "Hiện mật khẩu" : "Ẩn mật khẩu");
        }

    }

}
