﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        private static BUS_KhachHang _instance;
        public static BUS_KhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_KhachHang();
                return _instance;
            }
            private set { _instance = value; }
        }
        public BUS_KhachHang() { }

        public DataTable GetKhachHangByUserNameAndPassWord(string UserName, string PassWord)
        {
            return DAL_KhachHang.Instance.GetKhachHangByUserNameAndPassWord(UserName, PassWord);
        }
        public DataTable GetKhachHangByID(int id)
        {
            return DAL_KhachHang.Instance.GetKhachHangByID(id);
        }
        public DataTable GetThongTinKhachHangByTen(string tenKhachHang)
        {
            string query = string.Format("SELECT DISTINCT ID_KhachHang, TenKhachHang, TenTaiKhoan, Password, CCCD, SoDienThoai, DiaChi, MaPhong, TenLoaiPhong, Gia, TrangThai FROM Phong JOIN LoaiPhong ON Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong JOIN KhachHang ON KhachHang.MaPhong = Phong.ID_Phong WHERE LOWER(KhachHang.TenKhachHang) LIKE '%{0}%'", tenKhachHang.ToLower());
            DataTable dtPhong = new DataTable();
            dtPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhong;
        }
        public DataTable GetKhachHangByIdPhong(string Id)
        {
            return DAL_KhachHang.Instance.GetKhachHangByIdPhong(Id);
        }
        public void Update(DTO_KhachHang tk,string id)
        {
           DAL_KhachHang.Instance.Update(tk, id);
        }
        public void Delete(string id)
        {
           DAL_KhachHang.Instance.Delete(id);
        }
        public DataTable GetPhongByUserNamePassWord(string UserName, string PassWord)
        {
            return DAL_KhachHang.Instance.GetPhongByUserNamePassWord(UserName, PassWord);
        }
        public bool ThayDoiUserNamePassWord(string newPass, string userName, string pass)
        {
            return DAL_KhachHang.Instance.ThayDoiUserNamePassWord(newPass,userName,pass);
        }
        public int GetIDKhachHangByUserNameAndPassWord(string user, string pass)
        {
            return DAL_KhachHang.Instance.GetIDKhachHangByUserNameAndPassWord(user, pass);
        }
        public bool UpdateThongTin(string ten, string cccd, string sdt, string diachi, int idkhach)
        {
            return DAL_KhachHang.Instance.UpdateThongTin(ten, cccd, sdt, diachi, idkhach);
        }
    }
}

