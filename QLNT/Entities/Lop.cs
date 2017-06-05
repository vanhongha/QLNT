using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNT.Entities
{
    class Lop
    {

        private string _maLop;

        public string MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }

        private string _maLoaiLop;

        public string MaLoaiLop
        {
            get { return _maLoaiLop; }
            set { _maLoaiLop = value; }
        }

        private string _tenLop;

        public string TenLop
        {
            get { return _tenLop; }
            set { _tenLop = value; }
        }


        private int _namHoc;

        public int NamHoc
        {
            get { return _namHoc; }
            set { _namHoc = value; }
        }

        private string _maGV;

        public string MaGV
        {
            get { return _maGV; }
            set { _maGV = value; }
        }

        private int _siSo;

        public int SiSo
        {
            get { return _siSo; }
            set { _siSo = value; }
        }


        public Lop() { }


        public Lop(string maLop, string maLoaiLop, string tenLop, int namHoc, string maGV, int siSo)
        {
            this.MaLop = maLop;
            this.MaLoaiLop = maLoaiLop;
            this.TenLop = tenLop;
            this.NamHoc = namHoc;
            this.MaGV = maGV;
            this.SiSo = siSo;
        }

        public Lop(DataRow row)
        {
            this._maLop = row["MaLop"].ToString();
            this._maLoaiLop = row["MaLoaiLop"].ToString();
            this._maGV = row["MaGV"].ToString();
            this._namHoc = (int)row["NamHoc"];
            this._siSo = (int)row["SiSo"];
        }
    }
}
