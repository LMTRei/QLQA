using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace UI
{
    public partial class frmAdmin : Form
    {
        BindingSource BHList = new BindingSource();
        BindingSource QAList = new BindingSource();
        public frmAdmin()
        {
            InitializeComponent();
            LoadState();
        }
        void LoadState()
        {
            InitStateThongKeHoaDon();
            /*InitStateQuanAo();
            InitStateLoaiQuanAo();
            InitStateKhachHang();
            LoadAccount();
            LoadKieuTaiKhoan();
            LoadSoLuongSP_Theoloai();
            Load_Master_TheoMatHang();
            Load_5SP_BanChay();
            Load_DoanhThuTungThang();
            Load_5KH();*/
        }
        void InitStateThongKeHoaDon()
        {
            dtgvHD.DataSource = BHList;
            LoadDefaultDatetimePicker();
            LoadListThongKeBanHang();
            dtgvHD.HideColumns("ID_BH", "ID_GD");

            if (dtgvHD.Rows.Count > 0)
            {
                dtgvHD.Rows[0].Selected = true;
                dtgvHD_Click(dtgvHD.Rows[0], new EventArgs());
            }

            LoadDoanhThuBanHang();
        }

        void LoadDefaultDatetimePicker()
        {
            DateTime today = DateTime.Now;
            dtpBatDau.Value = new DateTime(today.Year, today.Month, 1);
            dtpKetThuc.Value = dtpBatDau.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListThongKeBanHang()
        {
            BHList.DataSource = ThongKeBanHangBUS.Instance.GetListThongKeBanHangInTime(dtpBatDau.Value, dtpKetThuc.Value);
        }

        void LoadDoanhThuBanHang()
        {
            DateTime fromdate = dtpBatDau.Value;
            DateTime todate = dtpKetThuc.Value;

            decimal tongTienChuaGiamGia = BanHangBUS.Instance.TinhTongTienChuaGiamGia(fromdate, todate);
            decimal tongTienGiamGia = BanHangBUS.Instance.TinhTongTienGiamGia(fromdate, todate);
            decimal tongTienThucThu = tongTienChuaGiamGia - tongTienGiamGia;

            lbTT_ChuaGiamGia.Text = tongTienChuaGiamGia.ToString();
            lbTT_GiamGia.Text = tongTienGiamGia.ToString();
            lbTT_ThucThu.Text = tongTienThucThu.ToString();
        }

        void btnTimKiemBH_Click(object sender, EventArgs e)
        {
            dtgvHD.DataSource = ThongKeBanHangBUS.Instance.GetListThongKeBanHangInTime(dtpBatDau.Value, dtpKetThuc.Value);
            LoadDoanhThuBanHang();
        }

        void btnXemBH_Click(object sender, EventArgs e)
        {
            dtgvHD.DataSource = ThongKeBanHangBUS.Instance.GetListThongKeBanHang();

            if (dtgvHD.Rows.Count > 0)
            {
                dtgvHD.Rows[0].Selected = true;
                dtgvHD_Click(this, new EventArgs());
            }
        }

        void dtgvHD_Click(object sender, EventArgs e)
        {
            if (dtgvHD.SelectedRows.Count == 0) return;

            int ID_BH = Convert.ToInt32(dtgvHD.SelectedRows[0].Cells["ID_BH"].Value);
            double Discount = Convert.ToDouble(dtgvHD.SelectedRows[0].Cells["Discount"].Value);

            List<ChiTietBanHangDTO> listCTBH = ChiTietBanHangBUS.Instance.Load_CTBH(ID_BH);

            dtgvChiTietBanHang.DataSource = listCTBH;
            dtgvChiTietBanHang.HideColumns("ID_CTBH");

            txtDiscountBH.Text = Discount.ToString() + " %";

            double tongSoTien = 0;
            foreach (ChiTietBanHangDTO chiTietBanHang in listCTBH)
                tongSoTien += chiTietBanHang.ThanhTien;

            tongSoTien -= (tongSoTien / 100) * Discount;
            txtTongTienBH.Text = tongSoTien.ToString("###.###.###");
        }

        private void dtpKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (dtpKetThuc.Value <= dtpBatDau.Value)
            {
                dtpKetThuc.Value = dtpKetThuc.Value.AddDays(1);
            }
        }
    }
}


        
