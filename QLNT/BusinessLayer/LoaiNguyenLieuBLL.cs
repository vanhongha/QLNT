using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DataLayer;
using System.Data;

namespace QLNT.BusinessLayer
{
    class LoaiNguyenLieuBLL
    {
        public static DataTable layDanhSachLoaiNguyenLieu()
        {
            return LoaiNguyenLieuDAL.layDanhSachLoaiNguyenLieu();
        }
    }
}
