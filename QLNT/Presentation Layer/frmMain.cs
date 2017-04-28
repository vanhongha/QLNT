using Bunifu.Framework.UI;
using System.Windows.Forms;
using System.Drawing;

namespace QLNT.Presentation_Layer
{
    public partial class frmMain : Form
    {
         private void OnUCButtonClicked(object sender, MouseEventArgs e)
        {
            // Handle event from here
            MessageBox.Show("Horray!");
        }

        Drag drag = new Drag();
        public frmMain()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            tab_QLTre1.BringToFront();
        }

        private void headerDrag_MouseDown(object sender, MouseEventArgs e)
        {
            drag.Grab(this);
        }

        private void headerDrag_MouseMove(object sender, MouseEventArgs e)
        {
            drag.MoveObject();
        }

        private void headerDrag_MouseUp(object sender, MouseEventArgs e)
        {
            drag.Release();
        }

        private void btnQLNhanVien_Click(object sender, System.EventArgs e)
        {
            SetNormalColor(btnQLTreEm);
            tab_QLNhanVien1.BringToFront();
        }

        private void btnQLTreEm_Click(object sender, System.EventArgs e)
        {
            tab_QLTre1.BringToFront();
        }

        private void SetNormalColor(BunifuFlatButton button)
        {
            button.Normalcolor = Color.FromArgb(1, 41, 89, 180);

        }

        public void UpdateView(function function)
        {
            switch(function)
            {
                case function.ThemTre:
                    view_ThemTre1.Enabled = true;
                    view_ThemTre1.BringToFront();

                    view_TimKiemTre1.Enabled = false;
                    break;
                case function.TimKiemTre:
                    view_TimKiemTre1.Enabled = true;
                    view_TimKiemTre1.BringToFront();

                    view_ThemTre1.Enabled = false;
                    break;
            }
            
        }
        
    }
}
