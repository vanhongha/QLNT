using QLNT.DataLayer;
using QLNT.Entities;
using System.Collections.Generic;
using System.Data;

namespace QLNT.BusinessLayer
{
    class NhanVienBLL
    {
        public static string AutoMaNV()
        {
            string id = NhanVienDAL.GetLastID().Trim();
            if (id == "")
            {
                return "MANV000001";
            }
            int nextID = int.Parse(id.Remove(0, "MANV".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MANV" + id;
        }

        public static bool ThemNV(NhanVien nhanVien)
        {
            DataTable dt = NhanVienDAL.ThemNV(nhanVien);
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;
            }

            return false;
        }

        public static DataTable TimNV(string tuKhoa)
        {
            return NhanVienDAL.TimNV(tuKhoa);
        }

        public static DataTable GetThongTinNV(string maNV)
        {
            return NhanVienDAL.GetThongTinNV(maNV);
        }

        public static void CapNhatThongTinNV(NhanVien nhanVien)
        {
            NhanVienDAL.CapNhatThongTinNV(nhanVien);
        }

        public static List<NhanVien> GetList()
        {
            return NhanVienDAL.GetList();
        }

        public static void XoaNV(string maNV)
        {
            NhanVienDAL.XoaNV(maNV);
        }

        public static DataTable GetGVCN()
        {
            return NhanVienDAL.GetGVCN();
        }
    }
}
