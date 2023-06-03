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
    public partial class frmTicketList : Form
    {
        public frmTicketList()
        {
            InitializeComponent();
        }

        private void frmTicketList_Load(object sender, EventArgs e)
        {
            this.panel1.AutoScroll = true;
            int panelCount = 15; // Oluşturulacak panellerin sayısı

            int panelHeight = 90; // Her bir panelin yüksekliği
            int panelWidth = panel1.Width - 20; // Her bir panelin genişliği ana Panel'e eşit olsun

            int topMargin = 10; // Panellerin üst kenardan başlayacağı mesafe
            int verticalSpacing = 10; // Paneller arasındaki dikey mesafe

            for (int i = 0; i < panelCount; i++)
            {
                Panel panel = new Panel();
                panel.Location = new Point(0, topMargin + i * (panelHeight + verticalSpacing));
                panel.Size = new Size(panelWidth, panelHeight);
                panel.BackColor = Color.LightBlue; // Panelin arka plan rengini ayarlayabilirsiniz

                // Panel üzerine istediğiniz kontrol ve özellikleri ekleyebilirsiniz
                // Örneğin, içerisinde bir buton oluşturabilirsiniz:
                Button button = new Button();
                button.Text = "Buton";
                button.Location = new Point(10, 10); // Butonun yerini belirleyin
                panel.Controls.Add(button); // Butonu panele ekleyin

                panel1.Controls.Add(panel); // Paneli ana Panel'e ekleyin
            }

        }
    }
}
