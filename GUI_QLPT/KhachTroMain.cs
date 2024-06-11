using BUS;
using Org.BouncyCastle.Asn1.Mozilla;
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
    public partial class KhachTroMain : Form
    {
        public static string user = string.Empty;
        public static string pass = string.Empty;
        public static int IDKhach = 0;
        public static string IDPhong = string.Empty;
        private LoginForm loginForm;
        public KhachTroMain()
        {
            InitializeComponent();
        }
        public KhachTroMain(string username, string password, LoginForm loginForm) 
        {
            InitializeComponent();
            user = username;
            pass = password;
            this.loginForm = loginForm;
            this.Load += new EventHandler(KhachTroMain_Load);
            IDKhach = BUS_KhachHang.Instance.GetIDKhachHangByUserNameAndPassWord(user,pass);

        }
        #region Design 
        private Form activeForm = null;
        private Button currentButton;
        private Random random = new Random();
        private int tempIndex;



        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#0F031F"); // Màu xanh dương cố định
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }



        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        #endregion


        private void btnThongTin_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            OpenChildForm(new ThongTinKhachHang(), sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Hoá đơn của tôi";
            OpenChildForm(new HoaDonCuaToi(), sender);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Phòng của tôi";
            OpenChildForm(new PhongCuaToi(), sender);
        }

        private void KhachTroMain_Load(object sender, EventArgs e)
        {
            btnThongTin.PerformClick();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
            loginForm.Show(); // Show the LoginForm
        }
    }
}
