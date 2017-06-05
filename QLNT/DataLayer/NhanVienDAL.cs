using System.Data;
using QLNT.Entities;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QLNT.DataLayer
{
    class NhanVienDAL
    {
        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MaNV from NHANVIEN order by MaNV desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static DataTable ThemNV(NhanVien nhanVien)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMNV");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", nhanVien.MaNV);
            cmd.Parameters.AddWithValue("@TenNhanVien", nhanVien.TenNhanVien);
            cmd.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
            cmd.Parameters.AddWithValue("@SDT", nhanVien.SoDT);
            cmd.Parameters.AddWithValue("@Email", nhanVien.Email);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static DataTable TimNV(string tuKhoa)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("TIMKIEMNV");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TUKHOA", tuKhoa);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable GetThongTinNV(string maNV)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETTHONGTINNV");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", maNV);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static void CapNhatThongTinNV(NhanVien nhanVien)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("SUATTNV");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", nhanVien.MaNV);
            cmd.Parameters.AddWithValue("@TenNhanVien", nhanVien.TenNhanVien);
            cmd.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
            cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
            cmd.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
            cmd.Parameters.AddWithValue("@SDT", nhanVien.SoDT);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static List<NhanVien> GetList()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETLISTNV");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            List<NhanVien> tre = new List<NhanVien>();
            foreach (DataRow row in db.dt.Rows)
            {
                tre.Add(new NhanVien(row));
            }

            return tre;
        }

        public static void XoaNV(string maNV)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOANV");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", maNV);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable GetGVCN()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("SELECT * FROM NHANVIEN");
            return dt;
        }

    }
}
