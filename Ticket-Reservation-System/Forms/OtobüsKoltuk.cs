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
    public partial class OtobüsKoltuk : Form
    {
   
        public OtobüsKoltuk()
        {
            InitializeComponent();

            // Panel'i oval hale getir
            OvalShape(label1);
        }
       
      
        private void OvalShape(Control control)
        {
            int cornerRadius = 10; // Oval köşe yarıçapı, ihtiyaçlarınıza göre değiştirebilirsiniz

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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void OtobüsKoltuk_Load(object sender, EventArgs e)
        {
            SetButtonStyles(button3);

            SetButtonStyles(button4);
            SetButtonStyles(button5);
            SetButtonStyles(button6);
            SetButtonStyles(button7);
            SetButtonStyles(button8);
            SetButtonStyles(button9);
            SetButtonStyles(button10);
            SetButtonStyles(button11);
            SetButtonStyles(button12);
            SetButtonStyles(button13);
            SetButtonStyles(button14);
            SetButtonStyles(button15);
            SetButtonStyles(button16);
            SetButtonStyles(button17);
            SetButtonStyles(button18);
            SetButtonStyles(button19);
            SetButtonStyles(button19);
            SetButtonStyles(button20);
            SetButtonStyles(button21);
            SetButtonStyles(button22);
            SetButtonStyles(button23);
            SetButtonStyles(button24);
            SetButtonStyles(button25);
            SetButtonStyles(button26);
            SetButtonStyles(button27);
            SetButtonStyles(button28);
            SetButtonStyles(button29);
            SetButtonStyles(button30);
            SetButtonStyles(button31);
            SetButtonStyles(button32);
            SetButtonStyles(button33);
            SetButtonStyles(button34);
            SetButtonStyles(button35);
            SetButtonStyles(button37);




        }
        private void SetButtonStyles(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.MouseOverBackColor = button1.BackColor;
            button.FlatAppearance.MouseDownBackColor = button1.BackColor;
        }
        private void SetButtonStyle(Button button)
        {
           

            button.BackColor = Color.Gray;
            
        }
        private void ToggleButtonText(Button button)
        {
            if (button.Tag == null)
            {
                // İlk kez tıklanıyor, orijinal yazıyı kaydet
                button.Tag = button.Text;
                button.Text = ""; // Yazıyı temizle veya istediğiniz başka bir değeri atayabilirsiniz
            }
            else
            {
                // Daha önce tıklandı, orijinal yazıyı geri yükle
                button.Text = button.Tag.ToString();
                button.Tag = null; // Tag'i sıfırla
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetButtonStyle(button3);

        }

        private void button_Click(object sender, EventArgs e)
        {
           

            Button clickedButton = (Button)sender;

            if (clickedButton.BackColor == Color.Gray)
            {
                clickedButton.BackColor = DefaultBackColor; // Eski arka plan rengine dönüş
            }
            else
            {
                clickedButton.BackColor = Color.Gray; // Yeni arka plan rengi
            }
        }
    }
}
