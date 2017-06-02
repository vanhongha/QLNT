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
    class ApDungThucDonBLL
    {
        public static void ThemApDungThucDon(string maThucDon, string buoiApDung, DateTime ngayApDung, string maLop)
        {
            ApDungThucDon apDungThucDon = new ApDungThucDon();
            apDungThucDon.MaThucDon = maThucDon;
            apDungThucDon.Buoi = buoiApDung;
            apDungThucDon.NgayApDung = ngayApDung;
            apDungThucDon.MaLop = maLop;
            ApDungThucDonDAL.ThemApDungThucDon(apDungThucDon);
        }

        public static void ThemApDungThucDon(ApDungThucDon apDungThucDon)
        {
            ApDungThucDonDAL.ThemApDungThucDon(apDungThucDon);
        }

        public static DataTable LayDanhSachApDungThucDonTheoMaThucDon(string maThucDon)
        {
            return ApDungThucDonDAL.LayDanhSachApDungThucDonTheoMaThucDon(maThucDon);
        }

        public static DataTable LayDanhSachApDungThucDonTheoThoiGian(DateTime NgayApDung, string Buoi)
        {
            return ApDungThucDonDAL.LayDanhSachApDungThucDonTheoThoiGian(NgayApDung, Buoi);
        }

        public static DataTable LayDanhSachTenVaMaLop()
        {
            return ApDungThucDonDAL.LayDanhSachTenVaMaLop();
        }

        public static DataTable LayDanhSachMaNguyenLieuVaSoLuongTrongMonAn(string maMonAn)
        {
            return ApDungThucDonDAL.LayDanhSachMaNguyenLieuVaSoLuongTrongMonAn(maMonAn);
        }

        public static bool KiemTraApdungThucDon(string maLop, string ngayApDung, string buoiApDung)
        {
            return ApDungThucDonDAL.KiemTraApdungThucDon(maLop, ngayApDung, buoiApDung);
        }

    }
}
