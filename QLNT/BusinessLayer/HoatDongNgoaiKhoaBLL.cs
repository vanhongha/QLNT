using System;
using System.Collections.Generic;
using System.Data;
using QLNT.DataLayer;
using QLNT.Entities;
using System.Windows.Forms;

namespace QLNT.BusinessLayer
{
    class HoatDongNgoaiKhoaBLL
    {
        public static DataTable GetListHoatDong()
        {
            return HoatDongNgoaiKhoaDAL.GetListHoatDong();
        }

        public static bool LuuHoatDong(HoatDongNgoaiKhoa hoatDong)
        {
            if(hoatDong.NgayKetThuc < hoatDong.NgayBatDau)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (HoatDongNgoaiKhoaDAL.CheckExistsHoatDong(hoatDong.MaHoatDong))
                {
                    //da ton tai
                    //update cho hoat dong
                    if(DateTime.Today > hoatDong.NgayBatDau)
                    {
                        MessageBox.Show("Hoạt động này đã diễn ra, không được thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        HoatDongNgoaiKhoaDAL.CapNhatHoatDong(hoatDong);
                        return true;
                    }
                    
                }
                else
                {
                    //chua ton tai
                    //tao moi hoat dong
                    if (DateTime.Today > hoatDong.NgayBatDau)
                    {
                        MessageBox.Show("Ngày bắt đầu phải lớn hơn ngày hôm nay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        HoatDongNgoaiKhoaDAL.ThemHoatDong(hoatDong);
                        return true;
                    }
                    
                }
            }
            
        }

        public static bool CapNhatDiemHoatDong(string maHD, string maTre, float diem, string nhanXet)
        {
            HoatDongNgoaiKhoa hoatDong = HoatDongNgoaiKhoaDAL.GetHoatDong(maHD);
            if(DateTime.Today < hoatDong.NgayKetThuc)
            {
                MessageBox.Show("Chỉ được nhập điểm sau khi kết thúc hoạt động ngoại khóa này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                HoatDongNgoaiKhoaDAL.CapNhatDiemHoatDong(maHD, maTre, diem, nhanXet);
                return true;
            }
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

        public static bool CapNhatLopThamGia(Dictionary<string, bool> listLop, string maHD)
        {
            HoatDongNgoaiKhoa hoatDong = HoatDongNgoaiKhoaDAL.GetHoatDong(maHD);
            if (DateTime.Today > hoatDong.NgayBatDau)
            {
                MessageBox.Show("Hoạt động này đã diễn ra, không được thay đổi thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                foreach (string key in listLop.Keys)
                {
                    if (listLop[key])
                    {
                        if (!HoatDongNgoaiKhoaDAL.CheckExistsLopThamGia(maHD, key))
                        {
                            //lop nay chua tham gia => tao moi
                            ThemLopThamGia(maHD, key);
                        }
                    }
                    else
                    {
                        if (HoatDongNgoaiKhoaDAL.CheckExistsLopThamGia(maHD, key))
                        {
                            //lop nay da tham gia, xoa lop nay trong danh sach lop tham gia hoat dong
                            XoaLopThamGia(maHD, key);
                        }
                    }
                }
                return true;
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
