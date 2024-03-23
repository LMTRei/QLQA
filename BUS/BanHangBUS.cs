using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BanHangBUS
    {
        private BanHangBUS() { }

        public static BanHangBUS _instance;

        public static BanHangBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BanHangBUS();
                }
                return _instance;
            }
        }
        public int InsertBanHang(string id_GD, float discount, string hoten, string diaChi, string sdt)
        {
            DataTable table = BanHangDAO.Instance.InsertBanHang(id_GD, discount, hoten, diaChi, sdt);

            int result = -1;
            foreach (DataRow row in table.Rows)
            {
                result = (int)row["ID_BH"];
            }

            return result;
        }
        public decimal TinhTongTienChuaGiamGia(DateTime fromdate, DateTime todate)
        {
            
            decimal result = BanHangDAO.Instance.TinhTongTienChuaGiamGia(fromdate,todate);

            return result;
        }

        public decimal TinhTongTienGiamGia(DateTime fromdate, DateTime todate)
        {
            decimal result = BanHangDAO.Instance.TinhTongTienGiamGia(fromdate, todate);

            return result;
        }
    }
}
