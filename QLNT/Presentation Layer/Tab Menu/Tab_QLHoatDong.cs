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
    public partial class Tab_QLHoatDong : UserControl
    {
        public Tab_QLHoatDong()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.ThemCapNhatHoatDong);
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.ApDungHoatDong);
        }
    }
}
