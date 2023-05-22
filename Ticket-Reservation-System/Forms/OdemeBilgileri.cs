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
    public partial class OdemeBilgileri : Form
    {
        public OdemeBilgileri()
        {
            InitializeComponent();
            OvalShape(button1);
        }
        
        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void OdemeBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       

        private void OvalShape(Control control)
        {
            int cornerRadius = 15; // Oval köşe yarıçapı, ihtiyaçlarınıza göre değiştirebilirsiniz

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
    }
}
