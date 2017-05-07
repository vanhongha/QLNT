using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNT.Entities
{
    class HoatDongNgoaiKhoa
    {
        private string _maHoatDong;

        public string MaHoatDong
        {
            get { return _maHoatDong; }
            set { _maHoatDong = value; }
        }

        private string _tenHoatDong;

        public string TenHoatDong
        {
            get { return _tenHoatDong; }
            set { _tenHoatDong = value; }
        }

        private string _keHoach;

        public string KeHoach
        {
            get { return _keHoach; }
            set { _keHoach = value; }
        }

        private decimal _chiPhi;

        public decimal ChiPhi
        {
            get { return _chiPhi; }
            set { _chiPhi = value; }
        }

        private DateTime _ngayBatDau;

        public DateTime NgayBatDau
        {
            get { return _ngayBatDau; }
            set { _ngayBatDau = value; }
        }

        private DateTime _ngayKetThuc;

        public DateTime NgayKetThuc
        {
            get { return _ngayKetThuc; }
            set { _ngayKetThuc = value; }
        }

        public HoatDongNgoaiKhoa() { }

        public HoatDongNgoaiKhoa(DataRow row)
        {
            this._maHoatDong = row["MaHoatDong"].ToString();
            this._tenHoatDong = row["TenHoatDong"].ToString();
            this._keHoach = row["KeHoach"].ToString();
            this._chiPhi = (decimal)row["ChiPhi"];
            this._ngayBatDau = (DateTime)row["NgayBatDau"];
            this._ngayKetThuc = (DateTime)row["NgayKetThuc"];
        }
    }
}
