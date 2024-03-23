using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietBanHangDAO
    {
        private ChiTietBanHangDAO() { }

        private static ChiTietBanHangDAO _instance;
        public static ChiTietBanHangDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChiTietBanHangDAO();
                }
                return _instance;
            }
        }
        public DataTable Load_CTBH(int id_BH)
        {
            
            string query = "EXEC sp_select_ChiTietBanHang @ID_BH";
            object[] param = new object[] { id_BH };

            var table = DataProvider.Instance.ExecuteQuery(query, param);

            return table;
        }
        public int InsertChiTietBanHang(int id_QA, int id_BH, int soluongsanpham)
        {
            string query = "EXEC sp_insert_ChiTietBanHang @ID_QA , @ID_BH , @SoLuongSanPham";
            object[] param = new object[] { id_QA, id_BH, soluongsanpham };
            int result = DataProvider.Instance.ExecuteNonQuery(query, param);
            return result;
        }
    }
}
