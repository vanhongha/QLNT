using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class ChiTietMonAn
    {
        private string _maMonAn;
        public string MaMonAn
        {
            get { return _maMonAn; }
            set { _maMonAn = value; }
        }

        private string _maNguyenLieu;
        public string MaNguyenLieu
        {
            get { return _maNguyenLieu; }
            set { _maNguyenLieu = value; }
        }

        private string _soLuong;
        public string SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
    }
}
