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
    class NguyenLieuTungMonBLL
    {
        public static void ThemNLTungMon(NguyenLieuTungMon nlTungMon)
        {
            NLTungMonDAL.ThemNLTungMon(nlTungMon);
        }

        public static void CapNhatNL(NguyenLieuTungMon nlTungMon)
        {
            NLTungMonDAL.CapNhatNL(nlTungMon);
        }

        public static DataTable LayDanhSachNLTungMon(string maMon)
        {
            return NLTungMonDAL.LayDanhSachNLTungMon(maMon);
        }

        public static void XoaNLTungMon(string maMon, string maNL)
        {
            NLTungMonDAL.XoaNLTungMon(maMon, maNL);
        }

        public static bool KiemTraMaNL(string maMon, string MaNL)
        {
            return NLTungMonDAL.KiemTraMaNL(maMon, MaNL);
        }
    }
}
