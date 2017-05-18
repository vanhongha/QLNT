using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class ChiTietPhieuMuaNL
    {
        private string _maPhieu;
        public string MaPhieu
        {
            get { return _maPhieu; }
            set { _maPhieu = value; }
        }

        private string _maNguyenLieu;
        public string MaNguyenLieu
        {
            get { return _maNguyenLieu; }
            set { _maNguyenLieu = value; }
        }

        private decimal _soLuong;
        public decimal SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        private decimal _donGia;
        public decimal DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

        private decimal _thanhTien;
        public decimal ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }
    }
}
