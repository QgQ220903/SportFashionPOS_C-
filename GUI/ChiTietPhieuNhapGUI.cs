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

namespace GUI
{
    public partial class ChiTietPhieuNhapGUI : Form
    {
        ChiTietPhieuNhapBUS chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        int maPhieuNhap;
        List<ChiTietPhieuNhap> listPhieuNhap = new List<ChiTietPhieuNhap>();
        float thanhTien = 0;
        public ChiTietPhieuNhapGUI()
        {
            InitializeComponent();
            LoadDataTable();
        }

        public ChiTietPhieuNhapGUI(int maPhieuNhap)
        {
            InitializeComponent();
            LoadDataTable(maPhieuNhap);
            this.maPhieuNhap = maPhieuNhap;
        }

        public void LoadDataTable()
        {
            danhSachChiPhieuNhap.RowCount = 0;
            foreach (var item in chiTietPhieuNhapBUS.LayToanBoChiTietPhieuNhap())
            {
                ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LaySanPhamChiTietQuaMa(item.MaChiTietSanPham);
                SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                MauSac mauSac = mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac);
                KichCo kichCo = kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo);

                danhSachChiPhieuNhap.Rows.Add(item.MaChiTietPhieuNhap, phieuNhapBUS.LayPhieuNhapQuaMa(item.MaPhieuNhap).TenPhieuNhap, sanPham.TenSanPham, mauSac.TenMauSac, kichCo.TenKichCo, item.SoLuongNhap, item.DonVi, item.TienNhap, item.ThanhTien);
            }
        }

        public void LoadDataTable(int maPhieuNhap)
        {
            danhSachChiPhieuNhap.RowCount = 0;
            foreach (var item in chiTietPhieuNhapBUS.LayToanBoChiTietPhieuNhap())
            {
                if (item.MaPhieuNhap == maPhieuNhap)
                {
                    ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LaySanPhamChiTietQuaMa(item.MaChiTietSanPham);
                    SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                    MauSac mauSac = mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac);
                    KichCo kichCo = kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo);
                    this.listPhieuNhap.Add(item);
                    thanhTien += item.ThanhTien;

                    danhSachChiPhieuNhap.Rows.Add(item.MaChiTietPhieuNhap, phieuNhapBUS.LayPhieuNhapQuaMa(item.MaPhieuNhap).TenPhieuNhap, sanPham.TenSanPham, mauSac.TenMauSac, kichCo.TenKichCo, item.SoLuongNhap, item.DonVi, item.TienNhap, item.ThanhTien);
                }

            }
        }




        private void danhSachChiPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void export()
        {

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            export();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)

        {
            /*  e.Graphics.DrawString("Mã Hóa Đơn:       " + hd.TenHoaDon, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, 50));
              e.Graphics.DrawString("Mã Nhân Viên:       " + hd.MaNhanVien, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, 75));
              e.Graphics.DrawString("Mã Khách Hàng:       " + hd.MaKhachHang, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, 100));
              e.Graphics.DrawString("Ngày:       " + DateTime.Now, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, 130));
              e.Graphics.DrawString("Tên Sản Phẩm                                                                               Số Lượng              Giá                  Thành Tiền", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 165));
              e.Graphics.DrawString("_______________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, 170));
              int local_x = 180;
              foreach (ChiTietHoaDon cthd in this.banHang.listCTHD)
              {
                  local_x += 20;
                  SanPham sp = new SanPham();
                  sp = SanPhamBUS.getFromCTSP(cthd.MaChiTietSanPham + "");
                  e.Graphics.DrawString(sp.TenSanPham + "                                                                               " + cthd.SoLuong + "              +" + cthd.GiaSanPham + " VNĐ                " + cthd.ThanhTien + " VNĐ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, local_x));
              }
              local_x += 10;
              e.Graphics.DrawString("_______________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 30;
              e.Graphics.DrawString("Tổng tiền sản phẩm:      " + this.TongTienDonHang + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("Khuyến Mãi:      " + this.MucKhuyenMai + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("Thuế:      " + this.MucThue + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("Tổng Thành Tiền:      " + this.TongThanhTien + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("Tổng Khách Đưa:      " + this.KhachDua + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("Thối lại:      " + this.ThoiLai + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("_______________________________________________________________________________", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("|                                                    Xin Cảm Ơn Quý Khách đã Mua Hàng!                                                 |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("|_____________________________________________________________________________|", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
  */

            PhieuNhap phieuNhap = phieuNhapBUS.LayPhieuNhapQuaMa(this.listPhieuNhap[0].MaPhieuNhap);
            e.Graphics.DrawString("PHIẾU NHẬP", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 20));
            e.Graphics.DrawString("Mã phiếu nhập: " + this.maPhieuNhap, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString("Tên Phiếu Nhập: " + phieuNhap.TenPhieuNhap, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 85));
            e.Graphics.DrawString("Tên Người Nhập: " + nhanVienBUS.LayNhanVienQuaMa(phieuNhap.MaNhanVien).TenNhanVien, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 110));
            e.Graphics.DrawString("Ngày Lập: " + phieuNhap.NgayNhap + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(360, 60));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 175));
            e.Graphics.DrawString("STT", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, 190));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(90, 190));
            e.Graphics.DrawString("Màu Sắc", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(340, 190));
            e.Graphics.DrawString("Kích Cỡ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(450, 190));
            e.Graphics.DrawString("Số Lượng ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, 190));
            e.Graphics.DrawString("Tổng tiền", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(700, 190));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 200));
            int point = 220;
            for (int i = 0; i < this.danhSachChiPhieuNhap.Rows.Count; i++)
            {
                e.Graphics.DrawString((i + 1) + "", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, point));
                e.Graphics.DrawString(danhSachChiPhieuNhap.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(90, point));
                e.Graphics.DrawString(danhSachChiPhieuNhap.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(340, point));
                e.Graphics.DrawString(danhSachChiPhieuNhap.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(450, point));
                e.Graphics.DrawString(danhSachChiPhieuNhap.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, point));
                e.Graphics.DrawString(danhSachChiPhieuNhap.Rows[i].Cells[8].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(700, point));
                point += 25;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, point));
            e.Graphics.DrawString("Tổng tiền phiếu nhập: " + this.thanhTien + "VND",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));


        }




    }
}
