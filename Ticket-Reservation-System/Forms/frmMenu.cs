using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket_Reservation_System.CustomControls;
using Ticket_Reservation_System.Forms;

namespace Ticket_Reservation_System
{
    public partial class frmMenu : Form
    {
        private int borderSize = 2;
        public frmMenu()
        {
            InitializeComponent();
            CollapseMenu();
            //customizeDesign();
            this.Padding = new Padding(this.borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
        }
        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
        private void customizeDesign()
        {
            panelSubMenu1.Visible = false;
            panelSubMenu2.Visible = false;
            panelSubMenu3.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMenu1.Visible == true)
            {
                panelSubMenu1.Visible = false;
            }
            if (panelSubMenu2.Visible == true)
            {
                panelSubMenu2.Visible = false;
            }
            if (panelSubMenu3.Visible == true)
            {
                panelSubMenu3.Visible = false;
            }
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        */
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private Form? activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (this.activeForm != null)
                this.activeForm.Close();
            this.activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSideMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelSideMenu.Width > 200) // Collapse Menu
            {
                this.panelSideMenu.Width = 100;
                this.pictureLogo.Visible = false;
                this.btnSideMenu.Dock = DockStyle.Top;
                foreach (Button sideMenuButton in panelSideMenu.Controls.OfType<Button>())
                {
                    sideMenuButton.Text = "";
                    sideMenuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    sideMenuButton.Padding = new Padding(0);
                }
            }
            else // Expand Menu
            {
                this.panelSideMenu.Width = 230;
                this.pictureLogo.Visible = true;
                this.btnSideMenu.Dock = DockStyle.None;
                foreach (Button sideMenuButton in panelSideMenu.Controls.OfType<Button>())
                {
                    sideMenuButton.Text = "  " + sideMenuButton.Tag.ToString();
                    sideMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    sideMenuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomDataGridView());
        }
    }
}
