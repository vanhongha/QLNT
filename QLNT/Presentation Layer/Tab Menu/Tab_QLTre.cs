using System;
using System.Windows.Forms;

namespace QLNT.Presentation_Layer.Tab_Menu
{
    public partial class Tab_QLTre : UserControl
    {
       
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler OnUserControlButtonClicked;
        public Tab_QLTre()
        {
            InitializeComponent();
        }

        private void btn_TiepNhanTre_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.ThemTre);
        }

        private void btnCapNhatTre_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.TimKiemTre);
        }
    }
}
