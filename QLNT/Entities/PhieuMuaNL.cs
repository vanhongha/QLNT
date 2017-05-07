using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class PhieuMuaNL
    {
        private string _maPhieu;
        public string MaPhieu
        {
            get { return _maPhieu; }
            set { _maPhieu = value; }
        }

        private DateTime _ngayMua;
        public DateTime NgayMua
        {
            get { return _ngayMua; }
            set { _ngayMua = value; }
        }

        private double _tongTien;
        public double TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
    }
}
