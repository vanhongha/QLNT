using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DataLayer;
using QLNT.Entities;
using System.Data;

namespace QLNT.BusinessLayer
{
    class ChiTietPhieuMuaNLBLL
    {
        public static void ThemChiTietPhieuMuaNL( string maPhieu, string maNguyenLieu, decimal soLuong, decimal donGia, decimal thanhTien )
        {
            ChiTietPhieuMuaNL chitiet = new ChiTietPhieuMuaNL();
            chitiet.MaPhieu = maPhieu;
            chitiet.MaNguyenLieu = maNguyenLieu;
            chitiet.SoLuong = soLuong;
            chitiet.DonGia = donGia;
            chitiet.ThanhTien = thanhTien;
            ChiTietPhieuMuaNLDAL.ThemChiTietPhieuMuaNL(chitiet);
        }

        public static void ThemChiTietPhieuMuaNL(ChiTietPhieuMuaNL chiTietPhieuMuaNL)
        {
            ChiTietPhieuMuaNLDAL.ThemChiTietPhieuMuaNL(chiTietPhieuMuaNL);
        }

        public static void CapNhatPhieuMuaNL(ChiTietPhieuMuaNL chiTietPhieuMuaNL)
        {
            ChiTietPhieuMuaNLDAL.CapNhatChiTietPhieuMuaNL(chiTietPhieuMuaNL);
        }

        public static DataTable LayDanhSachChiTietPhieuMuaNL(string maPhieu)
        {
            return ChiTietPhieuMuaNLDAL.LayDanhSachChiTietPhieuMuaNL(maPhieu);
        }

        public static void XoaChiTietPhieuMuaNL(string maPhieu, string maNL)
        {
            ChiTietPhieuMuaNLDAL.XoaChiTietPhieuMuaNL(maPhieu, maNL);
        }

        public static bool KiemTraMaNL(string maPhieu, string MaNL)
        {
            return ChiTietPhieuMuaNLDAL.KiemTraMaNL(maPhieu, MaNL);
        }
    }
}
