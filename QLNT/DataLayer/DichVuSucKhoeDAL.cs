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
    class DichVuSucKhoeDAL
    {
        public DichVuSucKhoeDAL() { }

        public static DataTable GetListDichVu()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("SELECT * FROM DICHVUYTE");
            return dt;
        }

        public static void ThemDichVu(DichVuSucKhoe dichVu)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("ThemDichVu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", dichVu.MaDV);
            cmd.Parameters.AddWithValue("@TenDichVu", dichVu.TenDV);
            cmd.Parameters.AddWithValue("@ChiTiet", dichVu.ChiTiet);
            cmd.Parameters.AddWithValue("@ChiPhi", dichVu.ChiPhi);
            cmd.Parameters.AddWithValue("@NgayKham", dichVu.NgayKham);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatDichVu(DichVuSucKhoe dichVu)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("CapNhatDichVu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", dichVu.MaDV);
            cmd.Parameters.AddWithValue("@TenDichVu", dichVu.TenDV);
            cmd.Parameters.AddWithValue("@ChiTiet", dichVu.ChiTiet);
            cmd.Parameters.AddWithValue("@ChiPhi", dichVu.ChiPhi);
            cmd.Parameters.AddWithValue("@NgayKham", dichVu.NgayKham);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static bool CheckExistsDichVu(string maDV)
        {

            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("CheckExistsDichVu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", maDV);
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
        public static DataTable GetListLopThamGia(string maDV)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("GetListLopThamGiaDichVu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", maDV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static bool CheckExistsLopThamGia(string maDV, string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("CheckExistsLopThamGiaDichVu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", maDV);
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

        public static void ThemLopThamGia(string maDV, string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("ThemLopThamGiaDichVu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", maDV);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void ThemThongTinSucKhoe(string maDV, string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("ThemThongTinSucKhoe");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", maDV);
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaLopThamGia(string maDV, string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("XoaLopThamGiaDichVu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", maDV);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaThongTinSucKhoe(string maDV, string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("XoaThongTinSucKhoe");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", maDV);
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DichVuSucKhoe GetDichVu(string maDV)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("GetDichVu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", maDV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return new DichVuSucKhoe(row);
            }
            return null;
        }

        public static void CapNhatSucKhoe(string maDV, string maTre, float canNang, float chieuCao, string tinhTrang)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("CapNhatSucKhoe");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", maDV);
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@CanNang", canNang);
            cmd.Parameters.AddWithValue("@ChieuCao", chieuCao);
            cmd.Parameters.AddWithValue("@TheTrang", tinhTrang);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable GetListSucKhoeTheoLop(string maLop, string maDV)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("GetKetQuaKhamTheoLop");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", maDV);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static DataTable GetListSucKhoeKoTheoLop(string maDV)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("GetKetQuaKhamKoTheoLop");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDichVu", maDV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

    }
}
