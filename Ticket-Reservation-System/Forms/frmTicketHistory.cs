using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket_Reservation_System.Models;
using Ticket_Reservation_System.Repositories;

namespace Ticket_Reservation_System.Forms
{
    public partial class frmTicketHistory : Form
    {
        User user;
        List<Ticket> tickets;
        Bitmap[] logos;
        Bitmap[] busLogos = new Bitmap[]{
            Properties.Resources.anadolu,
            Properties.Resources.anadolu,
            Properties.Resources.buzlu,
            Properties.Resources.Metro_Turizm_Logo,
            Properties.Resources.kamilkoc,
            Properties.Resources.karadeniz,
            Properties.Resources.pamukkale,
            Properties.Resources.nil_tur
        };
        Bitmap[] planeLogos = new Bitmap[]{
            Properties.Resources.emirates,
            Properties.Resources.qatar,
            Properties.Resources.singapore,
            Properties.Resources.thy,
            Properties.Resources.qantas
        };
        Bitmap[] ferryLogos = new Bitmap[]{
            Properties.Resources.f_dfds,
            Properties.Resources.f_gnv,
            Properties.Resources.f_grim,
            Properties.Resources.f_pq,
            Properties.Resources.f_stena
        };
        public frmTicketHistory(User user)
        {
            InitializeComponent();
            this.logos = busLogos;
            this.user = user;
            getTickets();
            createTickets();
        }

        private void getTickets()
        {
            tickets = new TicketRepository().getTicketsByUser(user.Id);
        }
        private void createTickets()
        {
            this.panel1.AutoScroll = true;

            int panelCount = 15; // Oluşturulacak panellerin sayısı
            int panelHeight = 90;
            int panelWidth = panel1.Width - 20;
            int topMargin = 0;
            int verticalSpacing = 15;

            for (int i = 0; i < tickets.Count; i++)
            {
                Panel panel = new Panel();
                panel.Margin = new Padding(10, 0, 0, 0);
                panel.Location = new Point(0, topMargin + i * (panelHeight + verticalSpacing));
                panel.Size = new Size(panelWidth - 10, panelHeight);
                panel.BackColor = System.Drawing.Color.WhiteSmoke; // Panelin arka plan rengini ayarlayabilirsiniz
                panel.BorderStyle = BorderStyle.FixedSingle;

                // Panel üzerine istediğiniz kontrol ve özellikleri ekleyebilirsiniz
                // Örneğin, içerisinde bir buton oluşturabilirsiniz:

                PictureBox pictureBox = new PictureBox();

                pictureBox.Size = new System.Drawing.Size(100, 100);
                pictureBox.Location = new System.Drawing.Point(40, 0);
                //pictureBox.Image = Image.FromFile(Application.StartupPath.ToString());
                pictureBox.Image = this.logos[new Random().Next(logos.Count())];
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                panel.Controls.Add(pictureBox);

                FontAwesome.Sharp.IconPictureBox iconButton = new FontAwesome.Sharp.IconPictureBox();
                iconButton.Size = new System.Drawing.Size(30, 20);
                iconButton.Location = new System.Drawing.Point(270, 25);
                iconButton.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
                panel.Controls.Add(iconButton);

                Label label = new Label();
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(300, 25);
                label.Text = tickets[i].Task.Process.Time;
                label.Font = new System.Drawing.Font("Verdana", 10);
                panel.Controls.Add(label);

                Label label4 = new Label();
                label4.Size = new System.Drawing.Size(100, 20);
                label4.Location = new System.Drawing.Point(350, 28);
                var label4Text = "";
                var list = tickets[i].Task.TaskPlan.Duration.ToString().Split(".");

                if (list.Length == 1)
                {
                    label4Text = list[0] + "s 00dk";
                }
                else
                {
                    label4Text = list[0] + "s " + (list[1].Length == 1 ? list[1] + "0dk" : list[1]);
                }
                label4.Text = "( " + label4Text + " )";
                label4.Font = new System.Drawing.Font("Verdana", 7);
                panel.Controls.Add(label4);

                Label label2 = new Label();
                label2.Size = new System.Drawing.Size(200, 20);
                label2.Location = new System.Drawing.Point(250, 50);
                label2.Text = tickets[i].Task.TaskPlan.StartingPoint.Name + " - "+ tickets[i].Task.TaskPlan.DestinationPoint.Name;
                label2.Font = new System.Drawing.Font("Verdana", 10);
                panel.Controls.Add(label2);



                Label label3 = new Label();
                label3.AutoSize = true;
                label3.Location = new System.Drawing.Point(450, 35);

                string price = "-";

                    var lista = tickets[i].Price.ToString().Split(".");

                    if (lista.Length == 1)
                    {
                        price = lista[0] + ".00 TL";
                    }
                    else
                    {
                        price = lista[0] + "." + (lista[1].ToString().Length == 1 ? lista[1] + "0" : lista[1]) + " TL";
                    }

                label3.Text = price+" ( "+ tickets[i].TicketPlan.Seat.SeatType +" )";
                label3.Font = new System.Drawing.Font("Verdana", 8);
                panel.Controls.Add(label3);


                if (tickets[i].Status != "CANCEL")
                {
                Button button = new Button();
                //button.Name = index.ToString();
                button.Text = "İptal et";
                button.Name = i.ToString();
                button.Size = new System.Drawing.Size(100, 35);
                button.Location = new System.Drawing.Point(600, 25);
                button.Font = new System.Drawing.Font("Verdana", 12);
                button.ForeColor = System.Drawing.Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = System.Drawing.Color.FromArgb(196, 71, 110);
                    button.Click += Button_Click;
                    panel.Controls.Add(button);
                }
                else
                {
                    Label label24 = new Label();
                    label24.Size = new System.Drawing.Size(200, 20);
                    label24.Location = new System.Drawing.Point(600, 35);
                    label24.Text = "İptal Edildi";
                    label24.Font = new System.Drawing.Font("Verdana", 10);
                    panel.Controls.Add(label24);

                }


                panel1.Controls.Add(panel);
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            var ticket = tickets[Convert.ToInt32(clickedButton.Name)];

            ticket.Status = "CANCEL";

            new TicketRepository().UpdateTicket(ticket);
            MessageBox.Show("Bilet iptal edildi.");
            panel1.Controls.Clear();
            getTickets();
            createTickets();
        }
    }
}
