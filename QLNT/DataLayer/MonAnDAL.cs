﻿using System;
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
    class MonAnDAL
    {
        public static void ThemMonAn(MonAn monAn)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEM_MON_AN");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", monAn.MaMonAn);
            cmd.Parameters.AddWithValue("@TenMonAn", monAn.TenMonAn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaMonAn(string maMon)
        {
            try
            {
                DataAccessHelper db = new DataAccessHelper();
                SqlCommand cmd = db.Command("XOA_MON_AN");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaMonAn", maMon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                db.dt = new DataTable();
                da.Fill(db.dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể xóa món ăn đã áp dụng vào thực đơn");
            }

        }

        public static void CapNhatMonAn(MonAn monAn)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAP_NHAT_MON_AN");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", monAn.MaMonAn);
            cmd.Parameters.AddWithValue("@TenMonAn", monAn.TenMonAn);
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable LayDanhSachMonAn()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_DANH_SACH_MON_AN");
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static string LayMaCuoi()
        {

            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("select top 1 MaMonAn from MONAN order by MaMonAn desc");

            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static bool KiemTraMonAn(string maMonAn)
        {

            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("select * from MONAN where MaMonAn = '" + maMonAn.Trim() + "'");

            foreach (DataRow row in dt.Rows)
            {
                return true;
            }
            return false;
        }

        public static bool KiemTraMonAnTrongThucDon(string maMonAn)
        {

            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("select * from CHITIET_THUCDON where MaMonAn = '" + maMonAn.Trim() + "'");

            foreach (DataRow row in dt.Rows)
            {
                return true;
            }
            return false;
        }
    }
}
