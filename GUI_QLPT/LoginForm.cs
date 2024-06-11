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
    public partial class LoginForm : Form
    {
        private DangKiForm dangKiForm;

        public LoginForm()
        {
            InitializeComponent();
            InitializePlaceholderText();
        }

        #region Xử lí nhập liệu và giao diện
        private void InitializePlaceholderText()
        {
            txtUserName.Tag = "Tên tài khoản";
            txtUserName.Text = "Tên tài khoản";
            txtUserName.ForeColor = Color.Gray;

            txtPassWord.Tag = "Mật khẩu";
            txtPassWord.Text = "Mật khẩu";
            txtPassWord.ForeColor = Color.Gray;
            txtPassWord.UseSystemPasswordChar = true;

        }


        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            if (textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = Color.FromArgb(15, 94, 148);

            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.Gray;
                txtPassWord.UseSystemPasswordChar = true;
            }
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtUserName.Enter += TextBox_Enter;
            txtUserName.Leave += TextBox_Leave;
            txtUserName.KeyDown += TextBox_KeyDown;

            txtPassWord.Enter += TextBox_Enter;
            txtPassWord.Leave += TextBox_Leave;
            txtPassWord.KeyDown += TextBox_KeyDown;

        }

        #endregion
        private void lbDangKi_Click(object sender, EventArgs e)
        {
            if (dangKiForm == null || dangKiForm.IsDisposed)
            {
                dangKiForm = new DangKiForm(this);
            }
            this.Hide();
            dangKiForm.Show();
        }
        DataTable lgoin(string username, string pasworrd)
        {
            BUS_TaiKhoan tk = new BUS_TaiKhoan();
            DataTable dtTk = tk.GetLogin(username, pasworrd);
            return dtTk;
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string userName = this.txtUserName.Text;
            string passWord = this.txtPassWord.Text;

            DataTable user = lgoin(userName, passWord);
            if (user.Rows.Count > 0)
            {
                if (user.Rows[0]["Quyen"].ToString().Equals("9999"))
                {
                    ChuTroMain f = new ChuTroMain(userName, passWord, this);
                    this.Hide();
                    f.ShowDialog();
                    this.Show(); // This ensures that LoginForm is shown again after ChuTroMain is closed
                }
                if (user.Rows[0]["Quyen"].ToString().Equals("6666"))
                {
                    KhachTroMain f = new KhachTroMain(userName, passWord, this);
                    this.Hide();
                    f.ShowDialog();
                    this.Show(); // This ensures that LoginForm is shown again after KhachTroMain is closed
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.YesNo);
            }
        }


        public void ShowLoginForm()
        {
            this.Show();
        }



        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            textBox.UseSystemPasswordChar = textBox.Text == "" && textBox.Text == textBox.Tag.ToString();
        }
    }
}
