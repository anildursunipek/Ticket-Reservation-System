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
    public partial class buus : Form
    {
        public buus()
        {
            InitializeComponent();

            // Panel'i oval hale getir
            OvalShape(panel1);
            OvalShape(panel2);
            OvalShape(panel3);
            OvalShape(panel4);
        }

        private void OvalShape(Control control)
        {
            int cornerRadius = 50; // Oval köşe yarıçapı, ihtiyaçlarınıza göre değiştirebilirsiniz

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

        private void buus_Load(object sender, EventArgs e)
        {

            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);


        }
        public class RoundedButton : Button
        {
            public int CornerRadius { get; set; } = 10; // Adjust the corner radius as needed

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddArc(0, 0, CornerRadius * 2, CornerRadius * 2, 180, 90);
                    path.AddArc(Width - CornerRadius * 2, 0, CornerRadius * 2, CornerRadius * 2, 270, 90);
                    path.AddArc(Width - CornerRadius * 2, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 0, 90);
                    path.AddArc(0, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 90, 90);
                    path.CloseFigure();

                    this.Region = new System.Drawing.Region(path);
                }
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
        }
    }
}
