using DAL;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Phong
    {
        private static BUS_Phong _instance;
        public static BUS_Phong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_Phong();
                return _instance;
            }
            private set { _instance = value; }
        }
        public BUS_Phong() { }
        #region Get danh sách phòng

        /// <summary>
        /// Get danh sách phòng
        /// </summary>
        /// <returns></returns>
        public DataTable GetPhongByidTro(string idtro)
        {
            return DAL_Phong.Instance.GetPhongByidTro(idtro);
        }

        #endregion

        #region Get danh sách phong theo ma phong

        /// <summary>
        /// Get danh sách phong theo ma phong
        /// </summary>
        /// <returns></returns>
        public DataTable GetPhongByID(string Id)
        {
            return DAL_Phong.Instance.GetPhongByID(Id);
        }

        #endregion

        #region Update trạng thái

        /// <summary>
        /// Update trạng thái
        /// </summary>
        /// <returns></returns>
        public bool UpdateTrangThai(string Id, int tt)
        {
            return DAL_Phong.Instance.UpdateTrangThai(Id, tt);
        }

        #endregion

        //public string GetMaxIDPhong()
        //{
        //	return PhongDao.GetMaxIDPhong();
        //}

        public bool InsertDefault(string Id)
        {
            return DAL_Phong.Instance.InsertDefault(Id);
        }
        public bool Insert(DTO_Phong phong)
        {
            return DAL_Phong.Instance.Insert(phong);
        }

        public void Update(string IDPhong,string Ten, string LoaiPhong)
        {
            DAL_Phong.Instance.Update(IDPhong, Ten, LoaiPhong);
        }

        public void Delete(string Id)
        {
            DAL_Phong.Instance.Delete(Id);
        }
        public void DeleteByLoaiPhong(string Id)
        {
            DAL_Phong.Instance.DeleteByLoaiPhong(Id);
        }
        public DataTable GetPhongMaPhong(string idTro)
        {
            return DAL_Phong.Instance.GetPhongMaPhong(idTro);
        }
        public DataTable GetPhongMaPhongByTinhTrang(string tt, string idTro)
        {
            return DAL_Phong.Instance.GetPhongMaPhongByTinhTrang(tt,idTro);
        }
        public DataTable GetPhongMaPhongByTinhTrangAndID(string tt, string id,string idTro)
        {
            return DAL_Phong.Instance.GetPhongMaPhongByTinhTrangAndID(tt,id,idTro);
         }
        public DataTable GetPhongMaPhongByID(string id, string idTro)
        {
            return DAL_Phong.Instance.GetPhongMaPhongByID(id,idTro);
        }
        public DataTable GetThongTinKhachHang(string idTro)
        {
            return DAL_Phong.Instance.GetThongTinKhachHang(idTro);
        }
        public DataTable GetThongTinKhachHangByID(string id, string idTro)
        {
            return DAL_Phong.Instance.GetThongTinKhachHangByID((string)id,idTro);
        }

        public DataTable GetPhongByTinhTrangAndLoaiPhong(string trangThaiPhong, string loaiPhong, string idTro)
        {
            return DAL_Phong.Instance.GetPhongByTinhTrangAndLoaiPhong(trangThaiPhong,loaiPhong,idTro);
        }
        public DataTable GetPhongByLoaiPhong(string loaiPhong,string IDTRO)
        {
            return DAL_Phong.Instance.GetPhongByLoaiPhong((string)loaiPhong,IDTRO);
        }
        public string GetTen(string id)
        {
            return DAL_Phong.Instance.GetTen(id);
        }
        public string GetMaxIDPhong(string idtro)
        {
            return DAL_Phong.Instance.GetMaxIDPhong((string)idtro);
        }
        //public DataTable GetPhongByIDTro(string idtro)
        //{
        //    return DAL_Phong.Instance.GetPhongByIDTro(string idtro);

        //}



    }
}
