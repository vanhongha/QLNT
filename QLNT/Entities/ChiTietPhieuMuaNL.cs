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

        private double _maNguyenLieu;
        public double MaNguyenLieu
        {
            get { return _maNguyenLieu; }
            set { _maNguyenLieu = value; }
        }

        private int _soLuong;
        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        private double _donGia;
        public double DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

        private double _thanhTien;
        public double ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }
    }
}
