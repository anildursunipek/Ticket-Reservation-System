using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Reservation_System.Forms
{
    public partial class PlaneKoltukBusiness : Form
    {
        public PlaneKoltukBusiness()
        {
            InitializeComponent();
        }



        private void ToggleButtonVisibility(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;

            if (button.BackColor == Color.Transparent)
            {
                button.BackColor = Color.Red;
                button.ForeColor = Color.White;
                button.Text = "x";
            }
            else
            {
                button.BackColor = Color.Transparent; // veya başka bir renk
                button.ForeColor = Color.Black; // veya başka bir renk
                button.Text = "";
            }


        }
        private void guna2Button56_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button55_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button57_Click(object sender, EventArgs e)
        {
        }
    }
}
