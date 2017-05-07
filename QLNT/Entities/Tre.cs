using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNT.Entities
{
    class Tre
    {
        #region Properties
        private String _maTre;

        public String MaTre
        {
            get { return _maTre; }
            set { _maTre = value; }
        }

        private String _hoTenTre;

        public String HoTenTre
        {
            get { return _hoTenTre; }
            set { _hoTenTre = value; }
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

        private String _hoTenCha;

        public String HoTenCha
        {
            get { return _hoTenCha; }
            set { _hoTenCha = value; }
        }

        private String _hoTenMe;

        public String HoTenMe
        {
            get { return _hoTenMe; }
            set { _hoTenMe = value; }
        }
        #endregion

        #region constructor
        public Tre() { }

        public Tre(DataRow row)
        {
            this._maTre = row["MaTre"].ToString();
            this._hoTenTre = row["HoTenTre"].ToString();
            this._gioiTinh = row["GioiTinh"].ToString();
            this._hoTenCha = row["HoTenCha"].ToString();
            this._hoTenMe = row["HoTenMe"].ToString();
            this._diaChi = row["DiaChi"].ToString();
            this._ngaySinh = (DateTime)row["NgaySinh"];
            this._soDT = row["SDTLienLac"].ToString();
        }
        #endregion
    }
}
