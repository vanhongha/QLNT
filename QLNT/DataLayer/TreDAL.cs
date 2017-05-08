using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLNT.Entities;

namespace QLNT.DataLayer
{
    class TreDAL
    {
        public TreDAL() { }

        public static DataTable ThemTre(Tre tre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("ThemTre");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", tre.MaTre);
            cmd.Parameters.AddWithValue("@TenTre", tre.HoTenTre);
            cmd.Parameters.AddWithValue("@NgaySinh", tre.NgaySinh);
            cmd.Parameters.AddWithValue("@TenBo", tre.HoTenCha);
            cmd.Parameters.AddWithValue("@TenMe", tre.HoTenMe);
            cmd.Parameters.AddWithValue("@DiaChi", tre.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", tre.SoDT);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static List<Tre> GetListTre()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("SELECT * FROM TRE");
            List<Tre> list = new List<Tre>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Tre(row));
            }
            return list;
        }

        public static DataTable GetListTreTheoLop(string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("GetListTreTheoLop");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MALOP", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }
    }
}
