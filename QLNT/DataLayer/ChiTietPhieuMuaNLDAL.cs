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
    class ChiTietPhieuMuaNLDAL
    {

        public static void ThemChiTietPhieuMuaNL( ChiTietPhieuMuaNL chiTietPM)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEM_CHI_TIET_PHIEU_MUA");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieu", chiTietPM.MaPhieu);
            cmd.Parameters.AddWithValue("@MaNL", chiTietPM.MaNguyenLieu);
            cmd.Parameters.AddWithValue("@SoLuong", chiTietPM.SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", chiTietPM.DonGia);
            cmd.Parameters.AddWithValue("@ThanhTien", chiTietPM.ThanhTien);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatChiTietPhieuMuaNL(ChiTietPhieuMuaNL chiTietPM)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAP_NHAT_CHI_TIET_PHIEU_MUA");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieu", chiTietPM.MaPhieu);
            cmd.Parameters.AddWithValue("@MaNL", chiTietPM.MaNguyenLieu);
            cmd.Parameters.AddWithValue("@SoLuong", chiTietPM.SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", chiTietPM.DonGia);
            cmd.Parameters.AddWithValue("@ThanhTien", chiTietPM.ThanhTien);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaChiTietPhieuMuaNL(string maPhieu, string maNL)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOA_CHI_TIET_PHIEU_MUA");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
            cmd.Parameters.AddWithValue("@MaNL", maNL);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaDanhSachChiTietPhieuMuaNL(string maPhieuMua)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOA_DANH_SACH_CHI_TIET_PHIEU_MUA");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieu", maPhieuMua);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable LayDanhSachChiTietPhieuMuaNL(string maPhieu)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_DANH_SACH_CHI_TIET_PHIEU_MUA_THEO_MA_PHIEU");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static bool KiemTraMaNL(string maPhieu, string maNL)
        {

            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_MA_NGUYEN_LIEU_TU_PHIEU_MUA");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
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
