using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class NguyenLieuTungMon 
    {
        private string _maMon;
        private string _maNL;
        private int _soLuong;

        public string MaMon
        {
            get
            {
                return _maMon;
            }

            set
            {
                _maMon = value;
            }
        }

        public string MaNL
        {
            get
            {
                return _maNL;
            }

            set
            {
                _maNL = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                _soLuong = value;
            }
        }
    }
}
