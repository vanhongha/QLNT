﻿using System;
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
    }
}
