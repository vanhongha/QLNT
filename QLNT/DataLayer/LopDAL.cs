using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.Entities;
using System.Data;

namespace QLNT.DataLayer
{
    class LopDAL
    {
        public LopDAL() { }


        public static DataTable GetListLop()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("SELECT * FROM LOP");
            return dt;
        }

        public static int GetNamHoc(string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("SELECT NamHoc FROM LOP WHERE MaLop = '" + maLop + "'");
            foreach(DataRow row in dt.Rows)
            {
                return (int)row[0];
            }
            return -1;
        }

    }
}
