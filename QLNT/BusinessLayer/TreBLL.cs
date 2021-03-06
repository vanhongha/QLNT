﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DataLayer;
using System.Data;
using QLNT.Entities;

namespace QLNT.BusinessLayer
{
    class TreBLL
    {
        public TreBLL() { }

        public static string AutoMaTre()
        {
            string id = TreDAL.GetLastID().Trim();
            if (id == "")
            {
                return "MTRE000001";
            }
            int nextID = int.Parse(id.Remove(0, "MTRE".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MTRE" + id;
        }

        public static bool ThemTre(Tre tre)
        {
            DataTable dt = TreDAL.ThemTre(tre);
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;
            }

            return false;
        }

        public static DataTable GetListTreTheoLop(String maLop)
        {
            return TreDAL.GetListTreTheoLop(maLop);
        }


        public static Tre GetTre(string maTre)
        {
            return TreDAL.GetTre(maTre);
        }

        public static DataTable TimKiemTre(string tuKhoa)
        {
            return TreDAL.TimKiemTre(tuKhoa);
        }

        public static DataTable GetThongTinTre(string maTre)
        {
            return TreDAL.GetThongTinTre(maTre);
        }
        public static void CapNhatThongTinTre(Tre tre)
        {
            TreDAL.CapNhatThongTinTre(tre);
        }

        public static List<Tre> GetList()
        {
            return TreDAL.GetList();
        }

        public static void XoaTre(string maTre)
        {
            TreDAL.XoaTre(maTre);
        }

        public static DataTable GetLopDaHoc(string maTre)
        {
            return TreDAL.GetLopDaHoc(maTre);
        }

        public static DataTable GetSucKhoe(string maTre, int nam)
        {
            return TreDAL.GetSucKhoe(maTre, nam);
        }

        public static DataTable GetSucKhoeTheoThang(string maTre, int thang, int nam)
        {
            return TreDAL.GetSucKhoeTheoThang(maTre, thang, nam);
        }

        public static string GetHoTen(string maTre)
        {
            DataTable dt = TreDAL.GetHoTenTre(maTre);
            foreach(DataRow row in dt.Rows)
            {
                return row["HoTenTre"].ToString();
            }

            return "";
        }

        public static DataTable TreChuaCoLop(string namSinh)
        {
            return TreDAL.TreChuaCoLop(namSinh);
        }

        public static void ThemTreVaoLop(string maTre, string maLop)
        {
            TreDAL.ThemTreVaoLop(maTre, maLop);
        }
    }
}
