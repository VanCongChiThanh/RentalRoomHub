using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        private static DAL_KhachHang _instance;
        public static DAL_KhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_KhachHang();
                return _instance;
            }
            private set { _instance = value; }
        }
        public DAL_KhachHang() { }
        #region Get danh sách khách hàng

        /// <summary>
        /// Get danh sách khách hàng
        /// </summary>
        /// <returns></returns>
        public DataTable GetKhachHang()
        {
            string query = "(SELECT * FROM KhachHang)";
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = DAL_DBHelper.Instance.GetRecords(query);
            return dtKhachHang;
        }

        #endregion

        #region Get danh sách khách hàng theo ID khách hang

        /// <summary>
        /// Get danh sách khách hàng theo ID khách hang
        /// </summary>
        /// <returns></returns>
        public DataTable GetKhachHangByID(int Id)
        {
            string query = string.Format("SELECT * FROM KhachHang WHERE ID_KhachHang = '{0}' AND DelFlg = 0", Id);
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = DAL_DBHelper.Instance.GetRecords(query);
            return dtKhachHang;
        }

        #endregion

        #region Get danh sách khách hàng theo ID khách hang

        /// <summary>
        /// Get danh sách khách hàng theo ID khách hang
        /// </summary>
        /// <returns></returns>
        //public string GetMaxIdKhachHang()
        //{
        //	string idKhachHang = string.Empty;
        //	DataTable dtKhachHang = new DataTable();

        //	_conn.Open();
        //	SqlCommand command = new SqlCommand("SELECT TOP 1 ID_KhachHang FROM KhachHang order by ID_KhachHang DESC", _conn);
        //	using (SqlDataReader reader = command.ExecuteReader())
        //	{
        //		if (reader.Read())
        //		{
        //			idKhachHang = reader["ID_KhachHang"].ToString();
        //		}
        //	}
        //	_conn.Close();

        //	return idKhachHang;
        //}

        #endregion
        #region Get danh sách khách hàng theo username, password
        public DataTable GetKhachHangByUserNameAndPassWord(string UserName, string PassWord)
        {

            string query = string.Format("SELECT * FROM KhachHang WHERE TenTaiKhoan = '{0}' AND Password = '{1}' AND DelFlg = 0", UserName, PassWord);
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = DAL_DBHelper.Instance.GetRecords(query);
            return dtKhachHang;
        }
        #endregion

        #region insert thông tin khách hàng

        /// <summary>
        /// insert thông tin khách hàng
        /// </summary>
        /// <returns></returns>
        public void Update(DTO_KhachHang khachHang, string id)
        {
            string query = string.Empty;
            if (khachHang.FlagInsert == true)
            {
                query = string.Format("INSERT INTO KhachHang VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", khachHang.TenKhachHang, khachHang.MatKhau, khachHang.TenTaiKhoan, khachHang.CMND, khachHang.SoDienThoai, khachHang.DelFlg, khachHang.DiaChi, khachHang.MaPhong);
            }
            else
            {
                query = string.Format("UPDATE KhachHang SET TenKhachHang = N'{0}',CCCD = N'{1}',SoDienThoai =N'{2}',DiaChi=N'{3}' WHERE ID_KhachHang =N'{4}'", khachHang.TenKhachHang, khachHang.CMND, khachHang.SoDienThoai, khachHang.DiaChi, id);
            }

           DAL_DBHelper.Instance.ExecuteDB(query);
        }
    #endregion

		public void Delete(string id)
		{
			string query = string.Format("Delete from KhachHang where ID_KhachHang = '{0}'",id);
            DataTable dtKhachHang = new DataTable();
            DAL_DBHelper.Instance.ExecuteDB(query);
		}
        public int GetIDKhachHangByUserNameAndPassWord(string user, string pass)
        {
            string query = string.Format("(SELECT * FROM KhachHang where TenTaiKhoan='{0}' and Password='{1}')", user, pass);
            int id = 0;
            DataTable tro = new DataTable();
            tro = DAL_DBHelper.Instance.GetRecords(query);
            foreach (DataRow dr in tro.Rows)
            {
                id = Convert.ToInt32(dr["ID_KhachHang"].ToString());
            }
            return id;
        }
        public DataTable GetKhachHangByIdPhong(string Id)
		{
            string query = string.Format("SELECT * FROM KhachHang WHERE MaPhong = '{0}' AND DelFlg = 0", Id);
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = DAL_DBHelper.Instance.GetRecords(query);
            return dtKhachHang;
        }
        public DataTable GetPhongByUserNamePassWord(string user,string pass)
        {
            string query = string.Format("SELECT MaPhong FROM KhachHang WHERE TenTaiKhoan = '{0}' AND Password= '{1}' AND DelFlg = 0", user,pass);
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = DAL_DBHelper.Instance.GetRecords(query);
            return dtKhachHang;
        }
        public bool ThayDoiUserNamePassWord(string newPass, string userName, string pass)
        {
            try {
                string query = string.Format("UPDATE KhachHang SET Password='{0}' where TenTaiKhoan = '{1}' AND Password = '{2}'", newPass, userName, pass);
                DataTable dtKhachHang = new DataTable();
                dtKhachHang = DAL_DBHelper.Instance.GetRecords(query);
                return true;
            }
            catch { return false; }
                       
        }
        public DataTable GetThongTinKhachHangByTen(string tenKhachHang, string idTro)
        {
            string query = string.Format("SELECT DISTINCT ID_KhachHang, TenKhachHang, TenTaiKhoan, Password, CCCD, SoDienThoai, DiaChi, MaPhong, TenLoaiPhong, Gia, TrangThai from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong join KhachHang on KhachHang.MaPhong = Phong.ID_Phong where LOWER(KhachHang.TenKhachHang) LIKE '%{0}%' and Phong.ID_Tro='{1}'", tenKhachHang.ToLower(), idTro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
        public void DeleteByID_Phong(string id)
        {
            string query = string.Format("Delete from KhachHang where MaPhong = '{0}'", id);
            DataTable dtKhachHang = new DataTable();
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
        public DataTable GetUserNameAndPassWordByMaPhong(string maphong)
        {
            string query = string.Format("SELECT TenTaiKhoan,Password FROM KhachHang WHERE MaPhong = '{0}'", maphong);
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = DAL_DBHelper.Instance.GetRecords(query);
            return dtKhachHang;
        }

        public bool UpdateThongTin(string ten, string cccd, string sdt, string diachi, int idkhach)
        {
            try
            {
                string query = string.Format("UPDATE KhachHang SET TenKhachHang = '{0}', CCCD = '{1}', SoDienThoai = '{2}', DiaChi = '{3}' WHERE ID_KhachHang = {4}",
                    ten, cccd, sdt, diachi, idkhach);
                DAL_DBHelper.Instance.ExecuteDB(query);  // Sử dụng phương thức thực thi không trả về DataTable vì UPDATE không cần trả về kết quả
                return true;
            }
            catch
            {
                return false;
            }
        }





    }
}
