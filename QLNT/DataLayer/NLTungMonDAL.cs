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
    class NLTungMonDAL
    {

        public static void ThemNLTungMon(NguyenLieuTungMon nlTungMon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEM_NGUYEN_LIEU_TUNG_MON");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", nlTungMon.MaMon);
            cmd.Parameters.AddWithValue("@MaNL", nlTungMon.MaNL);
            cmd.Parameters.AddWithValue("@SL", nlTungMon.SoLuong);
            

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatNL(NguyenLieuTungMon nlTungMon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAP_NHAT_NGUYEN_LIEU_TUNG_MON");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", nlTungMon.MaMon);
            cmd.Parameters.AddWithValue("@MaNL", nlTungMon.MaNL);
            cmd.Parameters.AddWithValue("@SL", nlTungMon.SoLuong);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaNLTungMon(string maMon, string maNL)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOA_NGUYEN_LIEU_TUNG_MON");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMon", maMon);
            cmd.Parameters.AddWithValue("@MaNL", maNL);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        //public static void XoaDanhSachChiTietPhieuMuaNL(string maPhieuMua)
        //{
        //    DataAccessHelper db = new DataAccessHelper();
        //    SqlCommand cmd = db.Command("XOA_DANH_SACH_CHI_TIET_PHIEU_MUA");
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@MaPhieu", maPhieuMua);

        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    db.dt = new DataTable();
        //    da.Fill(db.dt);
        //}

        public static DataTable LayDanhSachNLTungMon(string maMon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_DANH_SACH_NGUYEN_LIEU_THEO_MA_MON");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", maMon);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static bool KiemTraMaNL(string maMon, string maNL)
        {

            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_MA_NGUYEN_LIEU_TU_MON_AN");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMon", maMon);
            cmd.Parameters.AddWithValue("@MaNL", maNL);

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
