using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        private static BUS_TaiKhoan _instance;
        public static BUS_TaiKhoan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_TaiKhoan();
                return _instance;
            }
            private set { _instance = value; }
        }
        public BUS_TaiKhoan() { }
        public DataTable getTaiKhoan()
        {
            return DAL_TaiKhoan.Instance.GetTaiKhoan();
        }
        public DataTable getTaiKhoanbyName(string key)
        {
            return DAL_TaiKhoan.Instance.GetTaiKhoanbyName(key);
        }
        public DataTable GetTaiKhoanByID(string Id)
        {
            return DAL_TaiKhoan.Instance.GetTaiKhoanByID(Id);
        }
        public DataTable GetLogin(string Ten, string Pass)
        {
            return DAL_TaiKhoan.Instance.GetLogin(Ten, Pass);
        }
        public void Update(DTO_TaiKhoan tk,string id)
        {
            DAL_TaiKhoan.Instance.Update(tk,id);
        }
        public bool DeleteByID(string id)
        {
            return DAL_TaiKhoan.Instance.DeleteByID(id);
        }
        public void DeleteByUserNameAndPassword(string userName, string password)
        {
            DAL_TaiKhoan.Instance.DeleteByUserNameAndPassword(userName, password);
        }
        public bool CheckConflict(string username)
        {

            return DAL_TaiKhoan.Instance.CheckConflict(username);
        }

    }
}

