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

        Dictionary<tab, UserControl> listTabMenu;

        public frmMain()
        {
            InitializeComponent();
            InitForm();
            InitListView();
            InitTabMenu();
            UpdateView(function.Introduction);
        }

        private void InitListView()
        {
            listView = new Dictionary<function, UserControl>();

            listView.Add(function.Introduction, view_Introduction1);
            listView.Add(function.ThemTre, view_ThemTre1);
            listView.Add(function.TimKiemTre, view_TimKiemTre1);
            listView.Add(function.ThemNV, view_ThemNV1);
            listView.Add(function.TimKiemNV, view_TimKiemNV1);
            listView.Add(function.ChinhSuaDiemHocTap, view_ChinhSuaDiemHocTap1);
            listView.Add(function.ChinhSuaDiemNgoaiKhoa, view_ChinhSuaDiemNgoaiKhoa1);

            foreach (function f in listView.Keys)
            {
                listView[f].Visible = false;
                listView[f].Enabled = false;
            }
        }

        private void InitTabMenu()
        {
            listTabMenu = new Dictionary<tab, UserControl>();

            listTabMenu.Add(tab.QLTre, tab_QLTre1);
            listTabMenu.Add(tab.QLNhanVien, tab_QLNhanVien1);
            listTabMenu.Add(tab.QLDinhDuong, tab_QLDinhDuong1);
            listTabMenu.Add(tab.QLHocTap, tab_QLHocTap1);

            foreach (tab tab in listTabMenu.Keys)
            {
                listTabMenu[tab].Visible = false;
                listTabMenu[tab].Enabled = false;
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
            //SetNormalColor(btnQLTreEm);
            UpdateTab(tab.QLNhanVien);
        }

        private void btnQLTreEm_Click(object sender, System.EventArgs e)
        {
            UpdateTab(tab.QLTre);
        }

        private void btnQLDinhDuong_Click(object sender, System.EventArgs e)
        {
            UpdateTab(tab.QLDinhDuong);
        }
        
        private void btnQLHocTap_Click(object sender, System.EventArgs e)
        {
            UpdateTab(tab.QLHocTap);
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

        private void UpdateTab(tab tab)
        {
            foreach (tab t in listTabMenu.Keys)
            {
                if (t == tab)
                {
                    listTabMenu[t].Enabled = true;
                    listTabMenu[t].Visible = true;
                    listTabMenu[t].BringToFront();
                }
                else
                {
                    listTabMenu[t].Enabled = false;
                    listTabMenu[t].Visible = false;
                }
            }
        }

    }
}
