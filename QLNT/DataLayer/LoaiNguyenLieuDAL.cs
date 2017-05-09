using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLNT.DataLayer
{
    class LoaiNguyenLieuDAL
    {
        public static DataTable layDanhSachLoaiNguyenLieu()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAYDANHSACHLOAINGUYENLIEU");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            //DataTable dt = db.GetDataTable("SELECT * FROM NGUYENLIEU");
            return db.dt;
        }
    }
}
