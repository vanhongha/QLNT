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
    class PhieuMuaNLDAL
    {
        public static void ThemPhieuMuaNL(PhieuMuaNL phieuMuaNL)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEM_PHIEU_MUA_NL");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieu", phieuMuaNL.MaPhieu);
            cmd.Parameters.AddWithValue("@NgayMua", phieuMuaNL.NgayMua);
            cmd.Parameters.AddWithValue("@TongTien", phieuMuaNL.TongTien);
            cmd.Parameters.AddWithValue("@TrangThai", phieuMuaNL.TrangThai);
            cmd.Parameters.AddWithValue("@NguoiLapPhieu", phieuMuaNL.NguoiLapPhieu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaPhieuMuaNL(string MaPhieuMua)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOA_PHIEU_MUA_NGUYEN_LIEU");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieu", MaPhieuMua);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatPhieuMuaNL(PhieuMuaNL phieuMuaNL)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAP_NHAT_PHIEU_MUA_NL");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieu", phieuMuaNL.MaPhieu);
            cmd.Parameters.AddWithValue("@NgayMua", phieuMuaNL.NgayMua);
            cmd.Parameters.AddWithValue("@TongTien", phieuMuaNL.TongTien);
            cmd.Parameters.AddWithValue("@TrangThai", phieuMuaNL.TrangThai);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatTrangThaiPhieuMuaNL(string maPhieu)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAP_NHAT_TRANG_THAI_PHIEU_MUA_NL");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable LayDanhSachPhieuMuaNL()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_DANH_SACH_PHIEU_MUA");
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static string LayMaCuoi()
        {

            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("select top 1 MaPhieu from PHIEUMUANL order by MaPhieu desc");

            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static string LayTongTienTuMaPhieu(string maPhieu)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_TONG_TIEN_TU_PHIEU_MUA");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieuMua", maPhieu);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }
    }
}
