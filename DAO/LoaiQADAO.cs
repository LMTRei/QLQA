using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiQADAO
    {
        private LoaiQADAO() { }
        private static LoaiQADAO _instance;
        public static LoaiQADAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoaiQADAO();
                }
                return _instance;
            }
        }

        public DataTable Load_LQA()
        {
            string query = "EXEC sp_select_LoaiQuanAo_All";
            var LQA = DataProvider.Instance.ExecuteQuery(query);

            return LQA;
        }
    }
}
