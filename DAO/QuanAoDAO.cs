using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanAoDAO
    {
        private QuanAoDAO() { }

        private static QuanAoDAO _instance;
        public static QuanAoDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new QuanAoDAO();
                }
                return _instance;
            }
        }
        public DataTable Load_QA()
        {
           
            string query = "EXEC sp_select_QuanAo_All";

            var table = DataProvider.Instance.ExecuteQuery(query);

            return table;
        }
        public DataTable tiemkiem(string tiemkiemqa)
        {

            string query = "EXEC sp_select_QuanAo_By_Keyword @TieuChuanTim";
            object[] param = new object[] { tiemkiemqa };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);



            return table;
        }

    }
}
