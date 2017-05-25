using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNT.Entities;
using System.Data.SqlClient;

namespace QLNT.DataLayer
{
    class HoatDongNgoaiKhoaDAL
    {
        public HoatDongNgoaiKhoaDAL() { }

        public static DataTable GetListHoatDong()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("SELECT * FROM HOATDONGNGOAIKHOA");
            return dt;
        }

        public static void ThemHoatDong(HoatDongNgoaiKhoa hoatDong)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("ThemHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", hoatDong.MaHoatDong);
            cmd.Parameters.AddWithValue("@TenHoatDong", hoatDong.TenHoatDong);
            cmd.Parameters.AddWithValue("@KeHoach", hoatDong.KeHoach);
            cmd.Parameters.AddWithValue("@ChiPhi", hoatDong.ChiPhi);
            cmd.Parameters.AddWithValue("@NgayBatDau", hoatDong.NgayBatDau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", hoatDong.NgayKetThuc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatHoatDong(HoatDongNgoaiKhoa hoatDong)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("CapNhatHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", hoatDong.MaHoatDong);
            cmd.Parameters.AddWithValue("@TenHoatDong", hoatDong.TenHoatDong);
            cmd.Parameters.AddWithValue("@KeHoach", hoatDong.KeHoach);
            cmd.Parameters.AddWithValue("@ChiPhi", hoatDong.ChiPhi);
            cmd.Parameters.AddWithValue("@NgayBatDau", hoatDong.NgayBatDau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", hoatDong.NgayKetThuc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static bool CheckExistsHoatDong(string maHD)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("CheckExistHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            int check = 0;

            foreach (DataRow row in db.dt.Rows)
            {
                check = (int)row.ItemArray[0];
            }

            return (check == 1) ? true : false;
        }

        public static void CapNhatDiemHoatDong(string maHD, string maTre, float diem, string nhanXet)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("CapNhatDiemHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@Diem", diem);
            cmd.Parameters.AddWithValue("@NhanXet", nhanXet);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable GetListDiemTheoLop(string maHD, string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("GetListDiemHoatDongTheoLop");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable GetListDiemKoTheoLop(string maHD)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("GetListDiemHoatDongKoTheoLop");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable GetListLopThamGia(string maHD)
        {
            DataAccessHelper db = new DataAccessHelper();

            //DataTable dt = db.GetDataTable("SELECT * FROM HOATDONG_LOP WHERE MaHoatDong = '" + maHD + "'");

            SqlCommand cmd = db.Command("GetListLopThamGiaHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
            //return dt;
        }

        public static bool CheckExistsLopThamGia(string maHD, string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("CheckExistsLopThamGiaHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            int check = 0;

            foreach (DataRow row in db.dt.Rows)
            {
                check = (int)row.ItemArray[0];
            }

            return (check == 1) ? true : false;
        }

        public static void ThemLopThamGia(string maHD, string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("ThemLopThamGiaHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void ThemKetQuaHoatDong(string maHD, string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("ThemKetQuaThamGiaHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaLopThamGia(string maHD, string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("XoaLopThamGiaHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaKetQuaHoatDong(string maHD, string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("XoaKetQuaThamGiaHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static HoatDongNgoaiKhoa GetHoatDong(string maHD)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("GetHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return new HoatDongNgoaiKhoa(row);
            }
            return null;
        }

        public static void XoaHoatDong(HoatDongNgoaiKhoa hoatDong)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("XoaHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", hoatDong.MaHoatDong);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MaHoatDong from HOATDONGNGOAIKHOA order by MaHoatDong desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static void CapNhatTreThamGiaHoatDong(string maHD, string maTre, int thamGia)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("CapNhatTreThamGiaHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@ThamGia", thamGia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable GetListTreThamGiaHoatDong(string maHD, string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("GetListTreThamGiaHoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoatDong", maHD);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

    }
}
