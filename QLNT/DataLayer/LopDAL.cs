using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.Entities;
using System.Data;
using System.Data.SqlClient;

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

        public static DataTable GetListLoaiLop()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("SELECT * FROM LOAILOP");
            return dt;
        }

        public static DataTable ThemLop(Entities.Lop lop)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMLOP");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            cmd.Parameters.AddWithValue("@MaLoaiLop", lop.MaLoaiLop);
            cmd.Parameters.AddWithValue("@NamHoc", lop.NamHoc);
            cmd.Parameters.AddWithValue("@MaGV", lop.MaGV);
            cmd.Parameters.AddWithValue("@SiSo", lop.SiSo);
            cmd.Parameters.AddWithValue("@TenLop", lop.TenLop);
      
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

    }
}
