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
    }
}
