using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNT.DataLayer;

namespace QLNT.BusinessLayer
{
    class LopBLL
    {
        public LopBLL() { }

        public static string AutoMaLop()
        {
            string id = TreDAL.GetLastID().Trim();
            if (id == "")
            {
                return "MLOP000001";
            }
            int nextID = int.Parse(id.Remove(0, "MLOP".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MLOP" + id;
        }

        public static DataTable GetListLop()
        {
            return LopDAL.GetListLop();
        }

        public static int GetNamHoc(string maLop)
        {
            return LopDAL.GetNamHoc(maLop);
        }

        public static DataTable GetListLoaiLop()
        {
            return LopDAL.GetListLoaiLop();
        }

        public static bool ThemLop(Entities.Lop lop)
        {
            DataTable dt = LopDAL.ThemLop(lop);
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;
            }

            return false;
        }
    }
}
