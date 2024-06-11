using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private string _Password;
        private string _TenTaiKhoan;
        private string _Quyen;
        private int _DelFlg;
        private bool _FlagInsert;

        /* ======== GETTER/SETTER ======== */
        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }

        public string TenTaiKhoan
        {
            get
            {
                return _TenTaiKhoan;
            }

            set
            {
                _TenTaiKhoan = value;
            }
        }

        public string Quyen
        {
            get
            {
                return _Quyen;
            }

            set
            {
                _Quyen = value;
            }
        }

        public int DelFlg
        {
            get
            {
                return _DelFlg;
            }

            set
            {
                _DelFlg = value;
            }
        }

        public bool FlagInsert
        {
            get
            {
                return _FlagInsert;
            }

            set
            {
                _FlagInsert = value;
            }
        }

        /* === Constructor === */
        public DTO_TaiKhoan()
        {

        }

        public DTO_TaiKhoan(string pass, string ten, string quyen, int Flg, bool flagIns)
        {
            this.Password = pass;
            this.TenTaiKhoan = ten;
            this._Quyen = quyen;
            this.DelFlg = Flg;
            this.FlagInsert = flagIns;
        }
    }
}
