﻿using System;
using System.Windows.Forms;
using System.Data;
using QLNT.Entities;
using QLNT.DataLayer;
using System.Collections.Generic;

namespace QLNT.BusinessLayer
{
    class DichVuSucKhoeBLL
    {

        public static DichVuSucKhoe GetDV(string maDV)
        {
            return DichVuSucKhoeDAL.GetDichVu(maDV);
        }

        public static string GetTenDV(string maDV)
        {
            DichVuSucKhoe dichVu = DichVuSucKhoeDAL.GetDichVu(maDV);
            if(dichVu != null)
                return dichVu.TenDV;
            return "";
        }

        public static DataTable GetListDichVu()
        {
            return DichVuSucKhoeDAL.GetListDichVu();
        }

        public static bool LuuDichVu(DichVuSucKhoe dichVu)
        {
            if (DichVuSucKhoeDAL.CheckExistsDichVu(dichVu.MaDV))
            {
                //da ton tai
                //update cho dich vu
                if(DateTime.Today > dichVu.NgayKham)
                {
                    MessageBox.Show("Dịch vụ sức khỏe này đã diễn ra, không được thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    DichVuSucKhoeDAL.CapNhatDichVu(dichVu);
                    return true;
                }
            }
            else
            {
                //chua ton tai
                //tao moi dich vu
                if (DateTime.Today > dichVu.NgayKham)
                {
                    MessageBox.Show("Ngày khám phải lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    DichVuSucKhoeDAL.ThemDichVu(dichVu);
                    return true;
                }
            }
        }

        public static string[] GetListLopThamGia(string maDV)
        {
            DataTable dt = DichVuSucKhoeDAL.GetListLopThamGia(maDV);
            string[] listLop = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listLop[i] = dt.Rows[i]["MaLop"].ToString();
            }
            return listLop;
        }

        public static bool CapNhatLopThamGia(Dictionary<string, bool> listLop, string maDV)
        {
            DichVuSucKhoe dichVu = DichVuSucKhoeDAL.GetDichVu(maDV);
            if (DateTime.Today > dichVu.NgayKham)
            {
                MessageBox.Show("Dịch vụ sức khỏe này đã diễn ra, không được thay đổi thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                foreach (string key in listLop.Keys)
                {
                    if (listLop[key])
                    {
                        if (!DichVuSucKhoeDAL.CheckExistsLopThamGia(maDV, key))
                        {
                            //lop nay chua tham gia => tao moi
                            ThemLopThamGia(maDV, key);
                        }
                    }
                    else
                    {
                        if (DichVuSucKhoeDAL.CheckExistsLopThamGia(maDV, key))
                        {
                            //lop nay da tham gia, xoa lop nay trong danh sach lop tham gia dich vu
                            XoaLopThamGia(maDV, key);
                        }
                    }
                }
                return true;
            }
        }

        public static void ThemLopThamGia(string maDV, string maLop)
        {
            DichVuSucKhoeDAL.ThemLopThamGia(maDV, maLop);

            //Them ket qua suc khoe mac dinh cho lop nay
            DataTable listTre = TreDAL.GetListTreTheoLop(maLop);
            foreach (DataRow row in listTre.Rows)
            {
                DichVuSucKhoeDAL.ThemThongTinSucKhoe(maDV, row["MaTre"].ToString());
            }
        }

        public static void XoaLopThamGia(string maDV, string maLop)
        {
            //Xoa ket qua mac dinh da tao cho lop nay
            DataTable listTre = TreDAL.GetListTreTheoLop(maLop);
            foreach (DataRow row in listTre.Rows)
            {
                DichVuSucKhoeDAL.XoaThongTinSucKhoe(maDV, row["MaTre"].ToString());
            }

            //Tien hanh xoa lop nay trong danh sach lop tham gia
            DichVuSucKhoeDAL.XoaLopThamGia(maDV, maLop);
        }

        public static DataTable GetListSucKhoe(string maDV, string maLop)
        {
            if (maLop != "")
            {
                //get list suc khoe cua tre tham gia dich vu y te theo lop
                return DichVuSucKhoeDAL.GetListSucKhoeTheoLop(maDV, maLop);
            }
            else
            {
                //get list suc khoe cua tat ca tre tham gia hoat dong
                return DichVuSucKhoeDAL.GetListSucKhoeKoTheoLop(maDV);
            }
        }

        public static bool CapNhatSucKhoe(string maDV, string maTre, float canNang, float chieuCao, string tinhTrang)
        {
            DichVuSucKhoe dichVu = DichVuSucKhoeDAL.GetDichVu(maDV);
            if (DateTime.Today < dichVu.NgayKham)
            {
                MessageBox.Show("Chỉ được nhập sức khỏe sau ngày khám", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                DichVuSucKhoeDAL.CapNhatSucKhoe(maDV, maTre, canNang, chieuCao, tinhTrang);
                return true;
            }
        }

        public static bool XoaDichVu(DichVuSucKhoe dichVu)
        {
            if (DateTime.Today > dichVu.NgayKham)
            {
                MessageBox.Show("Chỉ được xóa dịch vụ chưa diễn ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                string[] listLop = GetListLopThamGia(dichVu.MaDV);
                foreach (string maLop in listLop)
                {
                    XoaLopThamGia(dichVu.MaDV, maLop);
                }
                DichVuSucKhoeDAL.XoaDichVu(dichVu);
                return true;
            }
        }

        public static string AutoMaDichVu()
        {
            string id = DichVuSucKhoeDAL.GetLastID().Trim();
            if (id == "")
            {
                return "MADV000001";
            }
            int nextID = int.Parse(id.Remove(0, "MADV".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MADV" + id;
        }

        public static bool CapNhatTreThamGiaDichVu(Dictionary<string, bool> listTre, string maDV)
        {
            DichVuSucKhoe dichVu = DichVuSucKhoeDAL.GetDichVu(maDV);
            if (DateTime.Today > dichVu.NgayKham)
            {
                MessageBox.Show("Dịch vụ này đã diễn ra, không được thay đổi thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                foreach (string key in listTre.Keys)
                {
                    DichVuSucKhoeDAL.CapNhatTreThamGiaDichVu(maDV, key, listTre[key] ? 1 : 0);
                }
                return true;
            }
        }

        public static string[] GetListTreThamGiaDichVu(string maDV, string maLop)
        {
            DataTable dt = DichVuSucKhoeDAL.GetListTreThamGiaDichVu(maDV, maLop);
            string[] listTre = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listTre[i] = dt.Rows[i]["Matre"].ToString();
            }
            return listTre;
        }

        public static DataTable GetListKetQuaSucKhoeTheoThang(string maTre, int thang, int nam)
        {
            return DichVuSucKhoeDAL.GetListSucKhoeTheoThang(maTre, thang, nam);
        }
    }
}
