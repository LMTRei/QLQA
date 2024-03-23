using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmtrangchu : Form
    {
        public String connectionstring = @"Data Source=CHI-DUC;Initial Catalog=QL_ShopQuanAo002;Integrated Security=True";
        public int ID_BH;
        QuanTriVienDTO loginAccount;
        List<ChiTietBanHangDTO> listCTBHTamThoi = new List<ChiTietBanHangDTO>();
        public double TongTienHoaDonHienTai => listCTBHTamThoi.Sum(v => v.ThanhTien);
        public double DiscountHienTai => Convert.ToDouble(nmGiamGia.Value);
        public double TongTienThanhToanCuoiCung => TongTienHoaDonHienTai - (TongTienHoaDonHienTai * DiscountHienTai / 100);
        public frmtrangchu(QuanTriVienDTO loginAccount)
        {
            InitializeComponent();
            this.loginAccount = loginAccount;

            if (loginAccount.Ten_KTK == "Quản trị viên")
            {
                tsmAdmin.Enabled = true;
            }
            else
            {
                tsmAdmin.Enabled = false;
            }
        }
        void LoadListQuanAo()
        {
            dgvQuanAo.DataSource = null;
            dgvQuanAo.DataSource = QuanAoBUS.Instance.Load_QA();
        }
        void InitState()
        {
            LoadListQuanAo();
            dgvQuanAo.HideColumns(SanPham.GhiChu, SanPham.ID_LQA);
        }

        private void frmtrangchu_Load(object sender, EventArgs e)
        {
            this.Text = "Quản lý cửa hàng quần áo KDT    ---    Tài Khoản quản lý : " + loginAccount.TenDangNhap + " !";

            lblTongTien.Text = "0";
            lblTongTienCuoiCung.Text = "0";
            lblTongTienGhiBangChu.Text = TienIch.So_chu(int.Parse(lblTongTienCuoiCung.Text.Replace(".", string.Empty)));


            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();

            String query = "SELECT * FROM QuanAo";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvQuanAo.DataSource = table;

            connection.Close();

            InitState();
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            listCTBHTamThoi.Clear();
            dgvCTBH.DataSource = null;
        }

        private void tsmAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.Show();
        }

        private void tsmThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmtrangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "Bạn có chắc chắn muốn thoát chương trình ?";
            var result = MessageBox.Show(msg, "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }

        private void btnXoaBoLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnTaiLaiDS_Click(object sender, EventArgs e)
        {
            dgvQuanAo.DataSource = null;
            dgvQuanAo.DataSource = QuanAoBUS.Instance.Load_QA();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string StringTimKiem = txtTimKiem.Text;
            if (string.IsNullOrWhiteSpace(StringTimKiem)) return;

            dgvQuanAo.DataSource = QuanAoBUS.Instance.tiemkiemqa(StringTimKiem);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvQuanAo.SelectedRows.Count == 0)
                return;

            ChiTietBanHangDTO chiTietBanHang = new ChiTietBanHangDTO();
            chiTietBanHang.ID_QA = Convert.ToInt32(dgvQuanAo.SelectedRows[0].Cells[SanPham.ID_QA].Value);
            chiTietBanHang.Ten_QA = dgvQuanAo.SelectedRows[0].Cells[SanPham.Ten_QA].Value.ToString();
            chiTietBanHang.GiaBan = (float)Convert.ToDouble(dgvQuanAo.SelectedRows[0].Cells[SanPham.GiaBan].Value);
            chiTietBanHang.SoLuongSanPham = (int)nmSoLuong.Value;

            int index = listCTBHTamThoi.FindIndex(v => v.ID_QA == chiTietBanHang.ID_QA);
            if (index == -1)
            {
                if (chiTietBanHang.SoLuongSanPham > 0)
                    listCTBHTamThoi.Add(chiTietBanHang);
            }
            else
            {
                int SLMoi = listCTBHTamThoi[index].SoLuongSanPham + chiTietBanHang.SoLuongSanPham;
                if (SLMoi > 0)
                    listCTBHTamThoi[index].SoLuongSanPham += chiTietBanHang.SoLuongSanPham;
                else
                    listCTBHTamThoi.RemoveAt(index);
            }

            int SLHienCo = Convert.ToInt32(dgvQuanAo.SelectedRows[0].Cells[SanPham.SoLuong].Value);
            dgvQuanAo.SelectedRows[0].Cells[SanPham.SoLuong].Value = SLHienCo - chiTietBanHang.SoLuongSanPham;
            nmSoLuong.Value = 1;

            nmSoLuong.Maximum = SLHienCo - chiTietBanHang.SoLuongSanPham;

            dgvCTBH.DataSource = null;
            dgvCTBH.DataSource = listCTBHTamThoi;
            dgvCTBH.HideColumns("ID_CTBH", "ID_QA");

            lblTongTien.Text = TongTienHoaDonHienTai.ToString();
        }

        private void lblTongTien_TextChanged(object sender, EventArgs e)
        {
            lblTongTienCuoiCung.Text = TongTienThanhToanCuoiCung.ToString();
            lblTongTienGhiBangChu.Text = TienIch.So_chu(TongTienThanhToanCuoiCung);
        }

        private void nmGiamGia_ValueChanged(object sender, EventArgs e)
        {
            lblTongTienCuoiCung.Text = TongTienThanhToanCuoiCung.ToString();
            lblTongTienGhiBangChu.Text = TienIch.So_chu(TongTienThanhToanCuoiCung);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            nmSoLuong.Value = 1;
            btnThem.PerformClick();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            btnXoaBoLoc.PerformClick();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            btnTaiLaiDS.PerformClick();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            btnThanhToan.PerformClick();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            btnHuyDon.PerformClick();
        }

        private void dgvQuanAo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nmSoLuong.Value = 1;
            btnThem.PerformClick();
        }
        void LuuBanHang()
        {
            string TenKH = txtHoTen.Text;
            string DiaChi = txtDiaChi.Text;
            string SDT = txtSDT.Text;
            float discount = (float)Convert.ToDouble(nmGiamGia.Value);
            string ID_GD = (DateTime.Now).ToString("ddMMyyyyhhmmss");

            ID_BH = BanHangBUS.Instance.InsertBanHang(ID_GD, discount, TenKH, DiaChi, SDT);

            string msg;
            if (ID_BH != -1)
            {
                msg = "Thanh toán thành công";
                dgvCTBH.DataSource = null;
            }
            else
            {
                msg = "Có lỗi khi thanh toán";
            }

            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void LuuChiTietBanHang()
        {
            foreach (ChiTietBanHangDTO chiTietBanHang in listCTBHTamThoi)
            {
                int MaQA = chiTietBanHang.ID_QA;
                int SLBan = chiTietBanHang.SoLuongSanPham;

                if (!ChiTietBanHangBUS.Instance.InsertChiTietBanHang(MaQA, ID_BH, SLBan))
                {
                    string msg = "Có lỗi trong quá trình thêm tạo đơn hàng";
                    MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string tenKH = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            string soDT = txtSDT.Text;
            if (listCTBHTamThoi.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm quần áo cần mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var khachHang = KhachHangBUS.Instance.LayThongTinKhachHang(tenKH, soDT, diaChi);
            if (khachHang == null)
            {
                return;
            }
            frmhoadon frmBill = new frmhoadon(listCTBHTamThoi, khachHang, DiscountHienTai);
            var result = frmBill.ShowDialog();

            if (result == DialogResult.OK)
            {
                LuuBanHang();
                LuuChiTietBanHang();
                listCTBHTamThoi.Clear();
            }
        }
    }
}
