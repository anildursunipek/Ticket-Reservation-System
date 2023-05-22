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
    public partial class PlaneKoltukEconomy : Form
    {
        public PlaneKoltukEconomy()
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
    }
}
