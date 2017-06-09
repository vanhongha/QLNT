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
    class MonAnBLL
    {
        public static void ThemMonAn(MonAn monAn)
        {
            MonAnDAL.ThemMonAn(monAn);
        }

        public static void XoaMonAn(string maMon)
        {
            MonAnDAL.XoaMonAn(maMon);
        }

        public static void CapNhatMonAn(MonAn monAn)
        {
            MonAnDAL.CapNhatMonAn(monAn);
        }

        public static DataTable LayDanhSachMonAn()
        {
            return MonAnDAL.LayDanhSachMonAn();
        }
       
        public static string SinhMaTuDong()
        {
            string maCuoi = MonAnDAL.LayMaCuoi().Trim();

            //chưa có phiếu mua nào trong CSDL
            if (maCuoi == "")
            {
                return "MAMA000001";
            }

            //xoa 4 chữ cái đầu chuỗi và tăng số đếm lên 1
            int maTiepTheo = int.Parse(maCuoi.Remove(0, 4)) + 1;
            string maTuDong = maTiepTheo.ToString().Trim();

            while (maTuDong.Length < 6)
            {
                maTuDong = "0" + maTuDong;
                maTuDong.Trim();
            }

            return "MAMA" + maTuDong;
        }

        public static bool KiemTraMonAn(string maMonAn)
        {
            return MonAnDAL.KiemTraMonAn(maMonAn);
        }

        public static bool KiemTraMonAnTrongThucDon(string maMonAn)
        {
            return MonAnDAL.KiemTraMonAnTrongThucDon(maMonAn);
        }
    }
}
