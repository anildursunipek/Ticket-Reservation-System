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

namespace Ticket_Reservation_System.Forms
{
    public partial class Feribot : Form
    {
        public Feribot()
        {
            InitializeComponent();

            OvalShape(panel1);
            OvalShape(panel2);
            OvalShape(panel3);
            OvalShape(panel4);
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
            int selectedIndex = comboBox1.SelectedIndex;
            string selectedValue = comboBox1.SelectedItem.ToString();

            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            comboBox1.SelectedItem = comboBox2.SelectedItem;

            comboBox2.SelectedIndex = selectedIndex;
            comboBox2.SelectedItem = selectedValue;
        }
    }
}
