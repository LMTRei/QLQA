using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class QuanTriVienDAO
    {
        private QuanTriVienDAO() { }

        private static QuanTriVienDAO _instance;

        public static QuanTriVienDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new QuanTriVienDAO();
                }
                return _instance;
            }
        }
        public bool Login(string tenDangNhap, string matKhau)
        {
            string query = "EXEC sp_select_DangNhap @TenDangNhap , @MatKhau";
            object[] param = new object[] { tenDangNhap, matKhau };
            DataTable result = DataProvider.Instance.ExecuteQuery(query, param);
            return result.Rows.Count > 0;
        }

        public DataTable GetAccountByUserName(string username)
        {
            string query = "EXEC sp_select_Account_By_UserName @username";
            object[] param = new object[] { username };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, param);

            return data;
        }
        public List<QuanTriVienDTO> GetListAccount()
        {
            string query = "EXEC sp_select_GetAccount";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<QuanTriVienDTO> dsQuanTriVien = new List<QuanTriVienDTO>();
            foreach (DataTable row in data.Rows)
            {
                QuanTriVienDTO quantrivien = new QuanTriVienDTO(row);

                dsQuanTriVien.Add(quantrivien);
            }

            return dsQuanTriVien;
        }
    }
}
