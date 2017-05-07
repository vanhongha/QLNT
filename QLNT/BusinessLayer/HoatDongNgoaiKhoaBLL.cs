using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNT.DataLayer;
using QLNT.Entities;

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
            if(HoatDongNgoaiKhoaDAL.CheckExistsHoatDong(hoatDong.MaHoatDong))
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
    }
}
