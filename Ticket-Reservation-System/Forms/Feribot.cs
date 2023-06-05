using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket_Reservation_System.Models;
using Ticket_Reservation_System.Repositories;

namespace Ticket_Reservation_System.Forms
{
    public partial class Feribot : Form
    {
        Location _startingPoint;
        Location _destinationPoint;
        User user;
        public Feribot(User user)
        {
            InitializeComponent();
            _startingPoint = new Location();
            _destinationPoint = new Location();
            this.user = user;
            OvalShape(panel1);
            OvalShape(panel2);
            OvalShape(panel3);
            OvalShape(panel4);
            getLocations();
        }

        private void getLocations()
        {
            var locations = new LocationRepository().GetAllLocations();
            var locations2 = new LocationRepository().GetAllLocations();
            locations = locations.FindAll(location => location.Type == "Otobüs terminali");
            locations2 = locations2.FindAll(location => location.Type == "Otobüs terminali");

            comboBoxDestinationPoint.DataSource = locations;
            comboBoxDestinationPoint.DisplayMember = "Name";
            comboBoxStarPoint.DataSource = locations2;
            comboBoxStarPoint.DisplayMember = "Name";
        }
        private void OvalShape(Control control)
        {
            int cornerRadius = 50;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddLine(cornerRadius, 0, control.Width - cornerRadius, 0);
            path.AddArc(control.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddLine(control.Width, cornerRadius, control.Width, control.Height - cornerRadius);
            path.AddArc(control.Width - cornerRadius, control.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddLine(control.Width - cornerRadius, control.Height, cornerRadius, control.Height);
            path.AddArc(0, control.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.AddLine(0, control.Height - cornerRadius, 0, cornerRadius);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        private void Feribot_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.LightGray;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
            button3.BackColor = Color.Gray;
            button2.BackColor = Color.LightGray;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxStarPoint.SelectedIndex;
            string selectedValue = comboBoxStarPoint.SelectedItem.ToString();

            comboBoxStarPoint.SelectedIndex = comboBoxDestinationPoint.SelectedIndex;
            comboBoxStarPoint.SelectedItem = comboBoxDestinationPoint.SelectedItem;

            comboBoxDestinationPoint.SelectedIndex = selectedIndex;
            comboBoxDestinationPoint.SelectedItem = selectedValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTicketList frmTicketList = new frmTicketList();
            this.Controls.Clear();
            frmTicketList.TopLevel = false;
            frmTicketList.FormBorderStyle = FormBorderStyle.None;
            frmTicketList.Dock = DockStyle.Fill;
            this.Controls.Add(frmTicketList);
            frmTicketList.BringToFront();
            frmTicketList.Show();
        }

        private void comboBoxStarPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            _startingPoint = (Location)comboBoxStarPoint.SelectedItem;
        }

        private void comboBoxDestinationPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            _destinationPoint = (Location)comboBoxDestinationPoint.SelectedItem;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_startingPoint != null && _destinationPoint != null)
            {
            frmTicketList frmTicketList = new frmTicketList(_startingPoint, _destinationPoint, "FERRY", dateTimePicker1.Value.Date, user);
            this.Controls.Clear();
            frmTicketList.TopLevel = false;
            frmTicketList.FormBorderStyle = FormBorderStyle.None;
            frmTicketList.Dock = DockStyle.Fill;
            this.Controls.Add(frmTicketList);
            frmTicketList.BringToFront();
            frmTicketList.Show();
            }
        }
    }
}
