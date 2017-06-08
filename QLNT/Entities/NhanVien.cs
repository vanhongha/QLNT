using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class NhanVien
    {

        #region Properties
        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private string _tenNhanVien;

        public string TenNhanVien
        {
            get { return _tenNhanVien; }
            set { _tenNhanVien = value; }
        }

        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        private string _gioiTinh;

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        private string _soDT;

        public string SoDT
        {
            get { return _soDT; }
            set { _soDT = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        #endregion

        public NhanVien() { }

        public NhanVien(string maNV, string TenNhanVien, string gioiTinh, DateTime ngaySinh, string email, string diaChi, string dienThoai)
        {
            this._maNV = maNV;
            this._tenNhanVien = TenNhanVien;
            this._gioiTinh = gioiTinh;
            this._ngaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.SoDT = dienThoai;
            this._email = email;
        }

        public NhanVien(DataRow row)
        {
            this._maNV = row["MaNV"].ToString();
            this._tenNhanVien = row["TenNhanVien"].ToString();
            this._gioiTinh = row["GioiTinh"].ToString();
            this._diaChi = row["DiaChi"].ToString();
            this._ngaySinh = (DateTime)row["NgaySinh"];
            this._soDT = row["SDT"].ToString();
            this._email = row["Email"].ToString();
        }
    }
}
