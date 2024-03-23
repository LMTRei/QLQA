using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HinhQADAO
    {
        private HinhQADAO() { }
        private static HinhQADAO _instance;
        public static HinhQADAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HinhQADAO();
                }
                return _instance;
            }
        }

        public DataTable Load_HinhSanPham(int id_QA)
        {
            string query = "EXEC sp_select_HinhSanPham_By_ID_QA @ID_QA";
            object[] param = new object[] { id_QA };

            var table = DataProvider.Instance.ExecuteQuery(query, param);
            return table;
        }
       
    }
}
