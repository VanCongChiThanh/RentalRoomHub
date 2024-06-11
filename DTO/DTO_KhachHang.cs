using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DTO_KhachHang
	{
		private string _TenKhachHang;
		private string _TenTaiKhoan;
        private string _MatKhau;
		private string _CMND;
		private string _SoDienThoai;
		private int _DelFlg;
		private string _DiaChi;
		private bool _FlagInsert;
		private string _MaPhong;

		/* ======== GETTER/SETTER ======== */
				public string TenKhachHang
		{
			get
			{
				return _TenKhachHang;
			}

			set
			{
				_TenKhachHang = value;
			}
		}

		public string CMND
		{
			get
			{
				return _CMND;
			}

			set
			{
				_CMND = value;
			}
		}

		public string SoDienThoai
		{
			get
			{
				return _SoDienThoai;
			}

			set
			{
				_SoDienThoai = value;
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

		public string DiaChi
		{
			get
			{
				return _DiaChi;
			}

			set
			{
				_DiaChi = value;
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

        public string MaPhong { get => _MaPhong; set => _MaPhong = value; }
        public string TenTaiKhoan { get => _TenTaiKhoan; set => _TenTaiKhoan = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }

        /* === Constructor === */
        public DTO_KhachHang()
		{

		}

		public DTO_KhachHang(string name,string Tk,string mk, string cmnd, string phone, int Flg, string diaChi, bool flagIns,string maphong)
		{
			this.TenKhachHang = name;
			this.CMND = cmnd;
			this.SoDienThoai = phone;
			this.DelFlg = Flg;
			this.DiaChi = diaChi;
			this.FlagInsert = flagIns;
			this.MaPhong = maphong;
			this.TenTaiKhoan = Tk;
			this._MatKhau = mk;
		}
	}
}
