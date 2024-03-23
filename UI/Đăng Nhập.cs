using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !cbShowPass.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String tenDangNhap = txtUserName.Text;
            String matKhau = txtPass.Text;

            QuanTriVienDTO loginAccount = QuanTriVienBUS.Instance.AccountByUserName(tenDangNhap);

            if (QuanTriVienBUS.Instance.checklogin(tenDangNhap, matKhau) == true)
            {
                frmtrangchu f = new frmtrangchu(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
                txtUserName.Clear();
                txtPass.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
