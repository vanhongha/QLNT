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
        public static void ThemApDungThucDon(string maThucDon, string maLop, DateTime ngayApDung, string buoiApDung)
        {

            ApDungThucDon apDungThucDon = new ApDungThucDon();
            apDungThucDon.MaThucDon = maThucDon;
            apDungThucDon.MaLop = maLop;
            apDungThucDon.NgayApDung = ngayApDung;
            apDungThucDon.Buoi = buoiApDung;
            ApDungThucDonDAL.ThemApDungThucDon(apDungThucDon);
        }

        public static void ThemApDungThucDon(ApDungThucDon apDungThucDon)
        {
            ApDungThucDonDAL.ThemApDungThucDon(apDungThucDon);
        }

        public static DataTable LayDanhSachApDungThucDon(string maThucDon)
        {
            return ApDungThucDonDAL.LayDanhSachApDungThucDon(maThucDon);
        }

        public static DataTable LayDanhSachTenVaMaLop()
        {
            return ApDungThucDonDAL.LayDanhSachTenVaMaLop();
        }

        public static DataTable LayDanhSachMaNguyenLieuVaSoLuongTrongMonAn(string maMonAn)
        {
            return ApDungThucDonDAL.LayDanhSachMaNguyenLieuVaSoLuongTrongMonAn(maMonAn);
        }

        public static bool KiemTraApdungThucDon(string maLop, DateTime ngayApDung, string buoiApDung)
        {
            return ApDungThucDonDAL.KiemTraApdungThucDon(maLop, ngayApDung, buoiApDung);
        }

    }
}
