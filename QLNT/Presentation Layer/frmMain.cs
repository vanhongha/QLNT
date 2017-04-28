using Bunifu.Framework.UI;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
namespace QLNT.Presentation_Layer
{
    public partial class frmMain : Form
    {
        Drag drag = new Drag();

        Dictionary<function, UserControl> listView;

        public frmMain()
        {
            InitializeComponent();
            InitForm();
            InitListView();
            UpdateView(function.TimKiemTre);
        }

        private void InitListView()
        {
            listView = new Dictionary<function, UserControl>();
            listView.Add(function.ThemTre, view_ThemTre1);
            listView.Add(function.TimKiemTre, view_TimKiemTre1);

            foreach (function f in listView.Keys)
            {
                listView[f].Visible = false;
                listView[f].Enabled = false;
            }
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
            foreach (function f in listView.Keys)
            {
                if (f == function)
                {
                    listView[f].Enabled = true;
                    listView[f].Visible = true;
                    listView[f].BringToFront();
                }
                else
                {
                    listView[f].Enabled = false;
                    listView[f].Visible = false;
                }
            }
        }
        
    }
}
