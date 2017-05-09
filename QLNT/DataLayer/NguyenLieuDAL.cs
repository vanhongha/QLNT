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
    class NguyenLieuDAL
    {
        public static DataTable layDanhSachNguyenLieu()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAYTHONGTINNGUYENLIEU");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            //DataTable dt = db.GetDataTable("SELECT * FROM NGUYENLIEU");
            return db.dt;
        }

        public static void themNguyenLieu(NguyenLieu nguyenLieu)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("ADDNGUYENLIEU");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNL", nguyenLieu.MaNguyenLieu);
            cmd.Parameters.AddWithValue("@TenNL", nguyenLieu.TenNguyenLieu);
            cmd.Parameters.AddWithValue("@MaLoaiNL", nguyenLieu.MaLoai);
            cmd.Parameters.AddWithValue("@ChiSoDD", nguyenLieu.ChiSoDinhDuong);
            cmd.Parameters.AddWithValue("@SoLuongTon", nguyenLieu.SoLuongTon);
            cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void capNhatNguyenLieu(NguyenLieu nguyenLieu)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAPNHATNGUYENLIEU");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNL", nguyenLieu.MaNguyenLieu);
            cmd.Parameters.AddWithValue("@TenNL", nguyenLieu.TenNguyenLieu);
            cmd.Parameters.AddWithValue("@MaLoaiNL", nguyenLieu.MaLoai);
            cmd.Parameters.AddWithValue("@ChiSoDD", nguyenLieu.ChiSoDinhDuong);
            cmd.Parameters.AddWithValue("@SoLuongTon", nguyenLieu.SoLuongTon);
            cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
