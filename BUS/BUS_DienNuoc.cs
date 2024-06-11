using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DienNuoc
    {
        private static BUS_DienNuoc _instance;
        public static BUS_DienNuoc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_DienNuoc();
                return _instance;
            }
            private set { _instance = value; }
        }
        #region Get danh sách loại phòng

        /// <summary>
        /// Get danh sách loại phòng
        /// </summary>
        /// <returns></returns>
        public DataTable GetLoaiPhong()
        {
            return DAL_DienNuoc.Instance.GetDienNuoc();
        }

        #endregion

        #region Get danh sách loại phong theo ma phong

        /// <summary>
        /// Get danh sách loại phong theo ma phong
        /// </summary>
        /// <returns></returns>
        public DataTable GetDienNuocByIDPhong(string Id)
        {
            return DAL_DienNuoc.Instance.GetDienNuocByIDPhong(Id);
        }
        public bool Update(string id, int sodien, int sonuoc, int dongiadien, int dongianuoc, int tongtien)
        {
            return DAL_DienNuoc.Instance.Update(id, sodien, sonuoc, dongiadien, dongianuoc, tongtien); 
        }
        public bool Delete(string id)
        {
            return DAL_DienNuoc.Instance.Delete(id);
        }
        public DataTable GetDienNuocAll(string id)
        {
            return DAL_DienNuoc.Instance.GetDienNuocAll(id);
        }
        public void UpdateDienNuoc(int sodien, int sonuoc, string id)
        {
            DAL_DienNuoc.Instance.UpdateDienNuoc(sodien, sonuoc, id);
        }
        public DataTable GetDienNuocAllById(string id,string IDTro)
        {
            return DAL_DienNuoc.Instance.GetDienNuocAllById(id,IDTro);
        }
        public DataTable GetDienNuocAllByTrangThai(int tt,string idtro)
        {
            return DAL_DienNuoc.Instance.GetDienNuocAllByTrangThai(tt,idtro);
        }
        public DataTable GetDienNuocAllByIdAndTinhTrang(string id, int tt,string IDTro)
        {
            return DAL_DienNuoc.Instance.GetDienNuocAllByIdAndTinhTrang(id,tt,IDTro);
        }
        public void InsertDienNuoc(int sodien, int sonuoc, int dongiadien, int dongianuoc)
        {
            DAL_DienNuoc.Instance.InsertDienNuoc(sodien, sonuoc, dongiadien, dongianuoc);
        }
        #endregion
    }
}
