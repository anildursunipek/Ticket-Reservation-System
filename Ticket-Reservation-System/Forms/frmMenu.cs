using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Reservation_System
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customizeDesign()
        {
            panelSubMenu1.Visible = false;
            panelSubMenu2.Visible = false;
            panelSubMenu3.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelSubMenu1.Visible == true)
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
            if(subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void btnMain1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubmenu(panelSubMenu1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubmenu(panelSubMenu2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubmenu(panelSubMenu3);
        }
    }
}
