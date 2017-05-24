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
    class ApDungThucDonDAL
    {
        public static void ThemApDungThucDon(ApDungThucDon apDungThucDon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEM_AP_DUNG_THUC_DON");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaThucDon", apDungThucDon.MaThucDon);
            cmd.Parameters.AddWithValue("@Buoi", apDungThucDon.Buoi);
            cmd.Parameters.AddWithValue("@NgayApDung", apDungThucDon.NgayApDung);
            cmd.Parameters.AddWithValue("@MaLop", apDungThucDon.MaLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable LayDanhSachApDungThucDon(string maThucDon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_DANH_SACH_AP_DUNG_THUC_DON_THEO_MA");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static DataTable LayDanhSachTenVaMaLop()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_DANH_SACH_TEN_VA_MA_LOP");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static DataTable LayDanhSachMaNguyenLieuVaSoLuongTrongMonAn(string maMonAn)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_MA_NGUYEN_LIEU_VA_SO_LUONG_CAN_TU_MON_AN");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static bool KiemTraApdungThucDon(string maLop, DateTime ngayApDung , string buoiApDung)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("KIEM_TRA_AP_DUNG_THUC_DON_THEO_LOP");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@NgayApDung", ngayApDung);
            cmd.Parameters.AddWithValue("@Buoi", buoiApDung);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            foreach (DataRow row in db.dt.Rows)
            {
                return true;
            }
            return false;
        }
    }
}
