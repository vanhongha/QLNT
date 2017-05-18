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
    public partial class Tab_QLSucKhoe : UserControl
    {
        public Tab_QLSucKhoe()
        {
            InitializeComponent();
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.ThemCapNhatSucKhoe);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.DichVuSucKhoe);
        }

        private void btnCapNhatSucKhoe_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.CapNhatSucKhoe);
        }
    }
}
