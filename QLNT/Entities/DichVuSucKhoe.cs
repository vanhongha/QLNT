using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNT.Entities
{
    class DichVuSucKhoe
    {
        private string _maDV;

        public string MaDV
        {
            get { return _maDV; }
            set { _maDV = value; }
        }

        private string _tenDV;

        public string TenDV
        {
            get { return _tenDV; }
            set { _tenDV = value; }
        }

        private string _chiTiet;

        public string ChiTiet
        {
            get { return _chiTiet; }
            set { _chiTiet = value; }
        }

        private decimal _chiPhi;

        public decimal ChiPhi
        {
            get { return _chiPhi; }
            set { _chiPhi = value; }
        }

        private DateTime _ngayKham;

        public DateTime NgayKham
        {
            get { return _ngayKham; }
            set { _ngayKham = value; }
        }

        public DichVuSucKhoe() { }

        public DichVuSucKhoe(DataRow row)
        {
            this._maDV = row["MaDichVu"].ToString();
            this._tenDV = row["TenDichVu"].ToString();
            this._chiTiet = row["ChiTiet"].ToString();
            this._chiPhi = (decimal)row["ChiPhi"];
            this._ngayKham = (DateTime)row["NgayKham"];
        }
    }
}
