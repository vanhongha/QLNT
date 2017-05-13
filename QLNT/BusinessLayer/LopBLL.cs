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
        public LopBLL() {  }

        public static DataTable GetListLop()
        {
            return LopDAL.GetListLop();
        }

        public static int GetNamHoc(string maLop)
        {
            return LopDAL.GetNamHoc(maLop);
        }
    }
}
