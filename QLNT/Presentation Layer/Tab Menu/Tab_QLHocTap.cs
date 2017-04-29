using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.Presentation_Layer.Tab_Menu
{
    public partial class Tab_QLHocTap : UserControl
    {
        public Tab_QLHocTap()
        {
            InitializeComponent();
        }

        private void btnChinhSuaDiemHocTap_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.ChinhSuaDiemHocTap);
        }

        private void btnChinhSuaDiemNgoaiKhoa_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.ChinhSuaDiemNgoaiKhoa);
        }
    }
}
