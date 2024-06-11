using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPT
{
    public partial class ChuTroMain : Form
    {
        private ContextMenuStrip accountContextMenu;

        #region Biến toàn cục
        private LoginForm loginForm;
        public static int IDCHUTRO = 0;
        public static string IDTRO = string.Empty;
        public static string DIACHI = string.Empty;
        #endregion

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
                    Color color = ColorTranslator.FromHtml("#4682B4");
                    // Màu xanh dương cố định
                    currentButton = (Button)btnSender;
                        currentButton.BackColor = color;
                        currentButton.ForeColor = Color.White;
                        currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                    }
                }
            }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (btnSender is Button button) // Chỉ ép kiểu nếu đối tượng là Button
            {
                ActivateButton(button);
            }

            // Tiếp tục mã để hiển thị childForm
            if (activeForm != null)
            {
                activeForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildFormContainer.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }



        private void DisableButton()
            {
                foreach (Control previousBtn in panelMenu.Controls)
                {
                    if (previousBtn.GetType() == typeof(Button))
                    {
                        previousBtn.BackColor = previousBtn.BackColor = Color.FromArgb(51,51, 76); 
                        previousBtn.ForeColor = Color.Gainsboro;
                        previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    }
                }
            }

            #endregion
            public ChuTroMain()
        {
            InitializeComponent();
            InitializeContextMenu();
        }
        public ChuTroMain(string user, string pass, LoginForm loginForm)
        {
            IDCHUTRO = BUS_ChuTro.Instance.GetIDChuTroByUserNameAndPassWord(user, pass);
            InitializeComponent();
            InitializeContextMenu();
            this.Load += new EventHandler(ChuTroMain_Load);
            this.loginForm = loginForm;
        }

        private void InitializeContextMenu()
        {
            accountContextMenu = new ContextMenuStrip();
            accountContextMenu.Items.Add("Thông tin cá nhân", null, this.Profile_Click);
            accountContextMenu.Items.Add("Đăng xuất", null, this.LogOut_Click);

            btnTaiKhoan.ContextMenuStrip = accountContextMenu;

        }



        private void Profile_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Thông tin cá nhân";
            OpenChildForm(new ThongTinChuTro(), null); // Không truyền sender vì nó không phải Button
        }


        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
            loginForm.Show(); // Show the LoginForm
        }


        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            accountContextMenu.Show(Cursor.Position); // Hiển thị menu tại vị trí con trỏ chuột
        }

        private void btnQLT_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Quản lí phòng trọ";
            OpenChildForm(new QuanLyPhong(), sender);
        }
        
        private void btnQLKH_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Quản lí khách trọ";
            OpenChildForm(new QuanLyKhachTro(), sender);
        }

        private void btnQLDV_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Quản lí dịch vụ";
            OpenChildForm(new DVDienNuoc(), sender);
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Quản lí thanh toán/hợp đồng";
            OpenChildForm(new TinhTien(), sender);
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Thống kê";
            OpenChildForm(new BaoCao(),sender);
        }

        private void ChuTroMain_Load(object sender, EventArgs e)
        {
            btnQLT.PerformClick();
        }
    }

}
