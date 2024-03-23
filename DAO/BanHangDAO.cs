using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BanHangDAO
    {
        private BanHangDAO() { }

        private static BanHangDAO _instance;
        public static BanHangDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BanHangDAO();
                }
                return _instance;
            }
        }
        public DataTable InsertBanHang(string id_GD, float discount, string hoten, string diaChi, string sdt)
        {
            string query = "EXEC sp_insert_BanHang @ID_GD , @Discount , @HoTen  , @DiaChi, @SDT";
            object[] param = new object[] { id_GD, discount, hoten, sdt, diaChi };
            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

            return table;
        }


        public decimal TinhTongTienChuaGiamGia(DateTime fromdate, DateTime todate)
        {
            string query = "EXEC sp_TinhTongTienChuaGiamGia @fromdate , @todate";
            object[] param = new object[] { fromdate, todate };
            decimal result = Convert.ToDecimal(DataProvider.Instance.ExecuteScalar(query, param));

            return result;
        }

        public decimal TinhTongTienGiamGia(DateTime fromdate, DateTime todate)
        {
            string query = "EXEC sp_TinhTongTienGiamGia @fromdate , @todate";
            object[] param = new object[] { fromdate, todate };
            decimal result = Convert.ToDecimal(DataProvider.Instance.ExecuteScalar(query, param));
            return result;
        }

    }
}
