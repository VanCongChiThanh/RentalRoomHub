using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThongKe
    {
        private static BUS_ThongKe _instance;
        public static BUS_ThongKe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_ThongKe();
                return _instance;
            }
            private set { _instance = value; }
        }
        public DataTable GetThongKebyID(string id) { 
            return DAL_ThongKe.Instance.GetThongKebyID(id);
        }
        public DataTable GetThongKebyIDTro(string idTro)
        {
            return DAL_ThongKe.Instance.GetThongKebyIDTro(idTro);
        }
        public string InsertDienNuoc( string time, int sodien, int sonuoc, int tienphong, int tongtien,string id)
        {
            return DAL_ThongKe.Instance.InsertDienNuoc(time, sodien, sonuoc, tienphong, tongtien, id);
        }
        public void Delete(string id)
        {
            DAL_ThongKe.Instance.Delete(id);
        }
        public DataSet GetFinancialSummaryByTro(string idTro)
        {
            return DAL_ThongKe.Instance.GetFinancialSummaryByTro(idTro);
        }
    }
}
