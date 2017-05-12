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
        private String _maNV;

        public String MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private String _tenNhanVien;

        public String TenNhanVien
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

        private String _gioiTinh;

        public String GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        private String _diaChi;

        public String DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        private String _soDT;

        public String SoDT
        {
            get { return _soDT; }
            set { _soDT = value; }
        }

        private String _email;

        public String Email
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
