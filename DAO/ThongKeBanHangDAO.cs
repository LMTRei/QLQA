using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ThongKeBanHangDAO
    {
        private ThongKeBanHangDAO() { }

        private static ThongKeBanHangDAO _instance;
        public static ThongKeBanHangDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThongKeBanHangDAO();
                }
                return _instance;
            }
        }

        public DataTable GetListThongKeBanHang()
        {

            string query = "EXEC sp_select_BanHang_All";

            var table = DataProvider.Instance.ExecuteQuery(query);

            return table;
        }

        public DataTable GetListThongKeBanHangInTime(DateTime fromDate, DateTime toDate)
        {
            string query = "EXEC sp_select_banHang_FromDateToDate @fromDate , @toDate";
            object[] param = new object[] { fromDate, toDate };

            var table = DataProvider.Instance.ExecuteQuery(query, param);

            return table;
        }
    }
}
