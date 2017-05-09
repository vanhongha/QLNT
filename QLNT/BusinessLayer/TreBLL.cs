using System;
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
                return "G2_TRE_00001";
            }
            int nextID = int.Parse(id.Remove(0, "G20_PSC_".Length)) + 1;
            id = "0000" + nextID.ToString();
            id = id.Substring(id.Length - 5, 5);
            return "G2_TRE_" + id;
        }

        public static bool ThemTre(Tre tre)
        {
            DataTable dt = TreDAL.ThemTre(tre);
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;
            }
            
            return true;
        }

        public static DataTable GetListTreTheoLop(String maLop)
        {
            return TreDAL.GetListTreTheoLop(maLop);
        }
    }
}
