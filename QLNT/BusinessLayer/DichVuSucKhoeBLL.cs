using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNT.Entities;
using QLNT.DataLayer;

namespace QLNT.BusinessLayer
{
    class DichVuSucKhoeBLL
    {
        public static DataTable GetListDichVu()
        {
            return DichVuSucKhoeDAL.GetListDichVu();
        }

        public static void LuuDichVu(DichVuSucKhoe dichVu)
        {
            if (DichVuSucKhoeDAL.CheckExistsDichVu(dichVu.MaDV))
            {
                //da ton tai
                //update cho dich vu
                DichVuSucKhoeDAL.ThemDichVu(dichVu);
            }
            else
            {
                //chua ton tai
                //tao moi dich vu
                DichVuSucKhoeDAL.CapNhatDichVu(dichVu);
            }
        }
    }
}
