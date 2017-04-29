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
    public partial class Tab_QLNhanVien : UserControl
    {
        public Tab_QLNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.ThemNV);
        }

        private void btnCapNhatTraCuu_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.TimKiemNV);
        }
    }
}
