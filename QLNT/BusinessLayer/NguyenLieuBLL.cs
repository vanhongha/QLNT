using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DataLayer;
using QLNT.Entities;
using System.Data;


namespace QLNT.BusinessLayer
{
    class NguyenLieuBLL
    {
        public static DataTable layDanhSachNguyenLieu()
        {
            return NguyenLieuDAL.layDanhSachNguyenLieu();
        }

        public static void themNguyenLieu(NguyenLieu nguyenlieu)
        {
            NguyenLieuDAL.themNguyenLieu(nguyenlieu);
        }

        public static void capNhatNguyenLieu(NguyenLieu nguyenlieu)
        {
            NguyenLieuDAL.capNhatNguyenLieu(nguyenlieu);
        }
    }
}
