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

            foreach(DataRow row in db.dt.Rows)
            {
                check = (int)row.ItemArray[0];
            }

            return (check == 1) ? true : false;
        }
    }
}
