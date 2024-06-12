using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Phong
    {
        private SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-KKVDHC9\SQLEXPRESS;Initial Catalog=t5;Integrated Security=True;");
        private static DAL_Phong _instance;
        public static DAL_Phong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_Phong();
                return _instance;
            }
            private set { _instance = value; }
        }
        public DAL_Phong() { }
        #region Get danh sách phòng

        /// <summary>
        /// Get danh sách phòng
        /// </summary>
        /// <returns></returns>
        public DataTable GetPhongByidTro(string idtro)
		{
            string query = string.Format("SELECT * FROM Phong WHERE DelFlag = 0 and ID_Tro='{0}'",idtro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
        #endregion

        #region Get danh sách phong theo ma phong

        /// <summary>
        /// Get danh sách phong theo ma phong
        /// </summary>
        /// <returns></returns>
        public DataTable GetPhongByID(string Id)
		{
            string query = string.Format("Select * from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong Where ID_Phong='{0}'", Id);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
        public DataTable GetPhongByIDTro(string idtro)
        {
            string query = string.Format("Select * from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong Where ID_Tro='{0}'", idtro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }

        #endregion

        #region Update trạng thái

        /// <summary>
        /// Update trạng thái
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool UpdateTrangThai(string Id, int tt)
		{
			string query = string.Format("UPDATE Phong SET TrangThai ='{0}' WHERE ID_Phong = '{1}'", tt, Id);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return true;
		}

		#endregion

		#region

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		public bool InsertDefault(string id)
		{
			string query = "INSERT INTO Phong (ID_Phong,ID_LoaiPhong,Gia,TrangThai,DelFlag) VALUES( '" + id + "','00','1000000','0',0);";
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return true;
		}
        public bool Insert(DTO_Phong phong)
        {
            string query = string.Format("INSERT INTO Phong (ID_LoaiPhong,TenPhong,TrangThai,DelFlag,ID_Tro) VALUES('{0}','{1}','{2}','{3}','{4}')",phong.LoaiPhong,phong.Ten,phong.TrangThai,phong.DelFlag,phong.IDTro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return true;
        }
        public string GetTen(string id)
        {
            string query = string.Format("select TenPhong from Phong where ID_Phong='{0}'",id);
            string ten = "";
            _conn.Open();
            SqlCommand cmd = new SqlCommand(query, _conn);
            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                if(reader.Read())
                {
                    ten= reader["TenPhong"].ToString();
                }
            }
            _conn.Close();
            return ten;              
        }
        #endregion

        public string GetMaxIDPhong(string idtro)
        {
        	string idPhong = string.Empty;
            string query = string.Format("SELECT COUNT(*) AS SoHang\r\nFROM Phong\r\nWHERE ID_Tro = '{0}'", idtro);
        	_conn.Open();
        	SqlCommand command = new SqlCommand(query, _conn);
        	using (SqlDataReader reader = command.ExecuteReader())
        	{
        		if (reader.Read())
        		{
        			idPhong = reader["SoHang"].ToString();
        		}
        	}
        	_conn.Close();

        	return idPhong;
        }

        public void Update(string Id, string Ten, string LoaiPhong)
		{
            string query = string.Format("Update Phong set ID_LoaiPhong='{0}',TenPhong='{1}' where ID_Phong='{2}'", LoaiPhong, Ten, Id);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
        }
        //1000000280000
		public void Delete(string Id)
		{
			string query = "Delete from Phong WHERE ID_Phong = '" + Id + "';";
            DAL_DBHelper.Instance.ExecuteDB(query); 
		}
        public void DeleteByLoaiPhong(string Id)
        {
            string query = "Delete from Phong WHERE ID_LoaiPhong = '" + Id + "';";
            DAL_DBHelper.Instance.ExecuteDB(query);
        }

        public DataTable GetPhongMaPhong(string idTro) {
            string query = string.Format("SELECT TenPhong , ID_Phong,LoaiPhong.ID_LoaiPhong,TenLoaiPhong,Gia,TrangThai from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong where Phong.ID_Tro='{0}'",idTro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
        public DataTable GetPhongMaPhongByID(string id, string idTro)
        {
            string query = string.Format("Select * from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong Where ID_Phong='{0}' AND ID_Tro='{1}'", id, idTro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
        public DataTable GetPhongMaPhongByTinhTrang(string tt,string idTro)
        {
            string query = string.Format("Select * from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong where TrangThai='{0}' AND Phong.ID_Tro='{1}'",tt,idTro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
        public DataTable GetPhongMaPhongByTinhTrangAndID(string tt,string id,string idTro)
        {
            string query = string.Format("Select * from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong where TrangThai='{0}' AND ID_Phong='{1}' AND Phong.ID_Tro='{2}' ", tt,id,idTro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
        public DataTable GetPhongByTinhTrangAndLoaiPhong(string trangThaiPhong, string loaiPhong,string idTro)
        {
            string query = string.Format("Select * from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong where TrangThai='{0}' AND LoaiPhong.ID_LoaiPhong='{1}' AND Phong.ID_Tro='{2}' ", trangThaiPhong,loaiPhong,idTro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
        public DataTable GetPhongByLoaiPhong(string loaiPhong,string idTro)
        {
            string query = string.Format("Select * from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong where Phong.ID_LoaiPhong='{0}' and Phong.ID_Tro='{1}' ", loaiPhong,idTro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
        public DataTable GetThongTinKhachHang(string idTro)
        {
            string query = string.Format("SELECT DISTINCT  ID_KhachHang as ID,TenKhachHang as [Tên khách hàng],TenTaiKhoan as [Tài khoản],Password as [Mật khẩu],CCCD,SoDienThoai as [Số điện thoại],DiaChi as [Địa chỉ],TenPhong as [Phòng],Gia as [Giá] from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong join KhachHang on KhachHang.[MaPhong] = Phong.ID_Phong where Phong.ID_Tro='{0}'",idTro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
        public DataTable GetThongTinKhachHangByID(string id,string idtro)
        {
            string query = string.Format("SELECT DISTINCT  ID_KhachHang,TenKhachHang,TenTaiKhoan,Password,CCCD,SoDienThoai,DiaChi,MaPhong,TenLoaiPhong,Gia,TrangThai from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong join KhachHang on KhachHang.[MaPhong] = Phong.ID_Phong where KhachHang.ID_KhachHang='{0}' and Phong.ID_Tro='{1}'",id,idtro);
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
  
    }
}
