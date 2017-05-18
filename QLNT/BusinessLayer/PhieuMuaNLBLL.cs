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
    class PhieuMuaNLBLL
    {
        public static void ThemPhieuMuaNL(PhieuMuaNL phieuMuaNL)
        {
            PhieuMuaNLDAL.ThemPhieuMuaNL(phieuMuaNL);
        }

        public static void XoaPhieuMuaNL(string maPhieuMua)
        {
            PhieuMuaNLDAL.XoaPhieuMuaNL(maPhieuMua);
        }

        public static void CapNhatPhieuMuaNL(PhieuMuaNL phieuMuaNL)
        {
            PhieuMuaNLDAL.CapNhatPhieuMuaNL(phieuMuaNL);
        }

        public static DataTable LayDanhSachPhieuMuaNL()
        {
            return PhieuMuaNLDAL.LayDanhSachPhieuMuaNL();
        }

        public static string SinhMaTuDong()
        {
            string maCuoi = PhieuMuaNLDAL.LayMaCuoi().Trim();

            //chưa có phiếu mua nào trong CSDL
            if (maCuoi == "")
            {
                return "MAPML000001";
            }

            //xoa 4 chữ cái đầu chuỗi và tăng số đếm lên 1
            int maTiepTheo = int.Parse(maCuoi.Remove(0, 4)) + 1;
            string maTuDong = maTiepTheo.ToString().Trim();

            while (maTuDong.Length < 6)
            {
                maTuDong = "0" + maTuDong;
                maTuDong.Trim();
            }

            return "MAPM" + maTuDong;
        }

        public static PhieuMuaNL TaoPhieuMuaMoi()
        {
            PhieuMuaNL phieuMuaNL = new PhieuMuaNL();
            phieuMuaNL.MaPhieu = SinhMaTuDong();
            phieuMuaNL.NgayMua = DateTime.Today;
            phieuMuaNL.TongTien = 0;
            phieuMuaNL.TrangThai = "Chưa nhập kho";
            phieuMuaNL.NguoiLapPhieu = "Nông Thị Lệ";
            ThemPhieuMuaNL(phieuMuaNL);
            return phieuMuaNL;

        }
            
    }
}
