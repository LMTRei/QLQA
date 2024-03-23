using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;


namespace BUS
{
    public class QuanTriVienBUS
    {

        private QuanTriVienBUS() { }

        public static QuanTriVienBUS _instance;

        public static QuanTriVienBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new QuanTriVienBUS();
                }
                return _instance;
            }
        }
        public QuanTriVienDTO AccountByUserName(string usename)
        {

            var table = QuanTriVienDAO.Instance.GetAccountByUserName(usename);


            foreach (DataRow row in table.Rows)
            {
                return new QuanTriVienDTO(row);
            }

            return null;
        }
        bool Login(string userName, string password)
        {
            return QuanTriVienDAO.Instance.Login(userName, password);
        }
        public bool checklogin(String ten, String mk)
        {
            check checking = new check();

            checking.SetTieuDe("Tên đăng nhập").SetInputString(ten).SanLocInPut().Require().MustBeValidString();

            checking.SetTieuDe("Mật khẩu").SetInputString(mk).SanLocInPut().Require();

            if (checking.HasError)
            {
                MessageBox.Show(checking.GetErrorMessage(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Login(ten, mk))
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông tin không hợp lệ");
                return false;
            }
            QuanTriVienDTO dangnhap = QuanTriVienBUS.Instance.AccountByUserName(ten);
            return true;
        }


    }
}
