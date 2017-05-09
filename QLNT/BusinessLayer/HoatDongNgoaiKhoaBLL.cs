using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNT.DataLayer;
using QLNT.Entities;
using System.Collections.Generic;

namespace QLNT.BusinessLayer
{
    class HoatDongNgoaiKhoaBLL
    {
        public static DataTable GetListHoatDong()
        {
            return HoatDongNgoaiKhoaDAL.GetListHoatDong();
        }

        public static void LuuHoatDong(HoatDongNgoaiKhoa hoatDong)
        {
            if (HoatDongNgoaiKhoaDAL.CheckExistsHoatDong(hoatDong.MaHoatDong))
            {
                //da ton tai
                //update cho hoat dong
                HoatDongNgoaiKhoaDAL.ThemHoatDong(hoatDong);
            }
            else
            {
                //chua ton tai
                //tao moi hoat dong
                HoatDongNgoaiKhoaDAL.CapNhatHoatDong(hoatDong);
            }
        }

        public static void CapNhatDiemHoatDong(string maHD, string maTre, float diem, string nhanXet)
        {
            HoatDongNgoaiKhoaDAL.CapNhatDiemHoatDong(maHD, maTre, diem, nhanXet);
        }

        public static DataTable GetListDiemHoatDong(string maHD, string maLop)
        {
            if (maLop != "")
            {
                //get list diem cua tre tham gia hoat dong theo lop
                return HoatDongNgoaiKhoaDAL.GetListDiemTheoLop(maHD, maLop);
            }
            else
            {
                //get list diem cua tat ca tre tham gia hoat dong
                return HoatDongNgoaiKhoaDAL.GetListDiemKoTheoLop(maHD);
            }
        }

        public static string[] GetListLopThamGia(string maHD)
        {
            DataTable dt = HoatDongNgoaiKhoaDAL.GetListLopThamGia(maHD);
            string[] listLop = new string[dt.Rows.Count];
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                listLop[i] = dt.Rows[i]["MaLop"].ToString();
            }
            return listLop;
        }

        public static void CapNhatLopThamGia(Dictionary<string, bool> listLop, string maHD)
        {
            foreach(string key in listLop.Keys)
            {
                if(listLop[key])
                {
                    if(!HoatDongNgoaiKhoaDAL.CheckExistsLopThamGia(maHD, key))
                    {
                        //lop nay chua tham gia => tao moi
                        ThemLopThamGia(maHD, key);
                    }
                }
                else
                {
                    if(HoatDongNgoaiKhoaDAL.CheckExistsLopThamGia(maHD, key))
                    {
                        //lop nay da tham gia, xoa lop nay trong danh sach lop tham gia hoat dong
                        XoaLopThamGia(maHD, key);
                    }
                }
            }
        }

        public static void ThemLopThamGia(string maHD, string maLop)
        {
            HoatDongNgoaiKhoaDAL.ThemLopThamGia(maHD, maLop);

            //Them ket qua hoat dong mac dinh cho lop nay
            DataTable listTre = TreDAL.GetListTreTheoLop(maLop);
            foreach(DataRow row in listTre.Rows)
            {
                HoatDongNgoaiKhoaDAL.ThemKetQuaHoatDong(maHD, row["MaTre"].ToString());
            }
        }

        public static void XoaLopThamGia(string maHD, string maLop)
        {
            //Xoa ket qua mac dinh da tao cho lop nay
            DataTable listTre = TreDAL.GetListTreTheoLop(maLop);
            foreach (DataRow row in listTre.Rows)
            {
                HoatDongNgoaiKhoaDAL.XoaKetQuaHoatDong(maHD, row["MaTre"].ToString());
            }

            //Tien hanh xoa lop nay trong danh sach lop tham gia
            HoatDongNgoaiKhoaDAL.XoaLopThamGia(maHD, maLop);
        }
    }
}
