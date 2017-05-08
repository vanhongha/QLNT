using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_BieuDoChieuCao : UserControl
    {
        public string maTre;

        public View_BieuDoChieuCao()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Visible = false;
        }
    }
}
