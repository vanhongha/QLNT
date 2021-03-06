﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLNT.Entities;

namespace QLNT.DataLayer
{
    class TreDAL
    {
        public TreDAL() { }

        public static DataTable ThemTre(Tre tre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("ThemTre");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", tre.MaTre);
            cmd.Parameters.AddWithValue("@TenTre", tre.HoTenTre);
            cmd.Parameters.AddWithValue("@GioiTinh", tre.GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", tre.NgaySinh);
            cmd.Parameters.AddWithValue("@TenBo", tre.HoTenCha);
            cmd.Parameters.AddWithValue("@TenMe", tre.HoTenMe);
            cmd.Parameters.AddWithValue("@DiaChi", tre.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", tre.SoDT);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static void ThemTreVaoLop(string maTre, string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMTREVAOLOP");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@MaLop", maLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static List<Tre> GetListTre()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("SELECT * FROM TRE");
            List<Tre> list = new List<Tre>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Tre(row));
            }
            return list;
        }

        public static DataTable GetListTreTheoLop(string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("GetListTreTheoLop");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MALOP", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MaTre from TRE order by MaTre desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }
        
        public static Tre GetTre(string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();

            SqlCommand cmd = db.Command("GetTre");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return new Tre(row);
            }
            return null;
        }

        public static DataTable TimKiemTre(string tuKhoa)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("TIMKIEMTRE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TUKHOA", tuKhoa);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable GetThongTinTre(string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETTHONGTINTRE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static void CapNhatThongTinTre(Tre tre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("SUATTTRE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", tre.MaTre);
            cmd.Parameters.AddWithValue("@TenTre", tre.HoTenTre);
            cmd.Parameters.AddWithValue("@GioiTinh", tre.GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", tre.NgaySinh);
            cmd.Parameters.AddWithValue("@TenBo", tre.HoTenCha);
            cmd.Parameters.AddWithValue("@TenMe", tre.HoTenMe);
            cmd.Parameters.AddWithValue("@DiaChi", tre.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", tre.SoDT);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static List<Tre> GetList()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETLISTTRE");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            List<Tre> tre = new List<Tre>();
            foreach (DataRow row in db.dt.Rows)
            {
                tre.Add(new Tre(row));
            }

            return tre;
        }

        public static void XoaTre(string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOATRE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable GetLopDaHoc(string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetLopDaHoc");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable GetSucKhoe(string maTre, int nam)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetCanNang");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable GetSucKhoeTheoThang(string maTre, int thang, int nam)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetSucKhoeTheoThang");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable GetHoTenTre(string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetHoTenTre");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable TreChuaCoLop(string namSinh)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("TRECHUACOLOP");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NamSinh", namSinh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }
    }
}
