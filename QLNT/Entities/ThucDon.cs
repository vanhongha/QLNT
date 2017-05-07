using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class ThucDon
    {
        private string _maThucDon;
        public string MaThucDon
        {
            get { return _maThucDon; }
            set { _maThucDon = value; }
        }


        private string _maLop;
        private string maLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }

        private DateTime _ngay;
        public DateTime Ngay
        {
            get { return _ngay; }
            set { _ngay = value; }
        }
    }
}
