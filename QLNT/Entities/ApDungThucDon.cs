using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class ApDungThucDon
    {
        private string _maThucDon;
        public string MaThucDon
        {
            get { return _maThucDon; }
            set { _maThucDon = value; }
        }

        private string _maLop;
        public string MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }

        private string _buoi;
        public string Buoi
        {
            get { return _buoi; }
            set { _buoi = value; }
        }

        private DateTime _ngayApDung;
        public DateTime NgayApDung
        {
            get { return _ngayApDung; }
            set { _ngayApDung = value; }
        }
    }
}

