using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Ticket_Reservation_System.Models;
using Ticket_Reservation_System.Repositories;

namespace Ticket_Reservation_System.Forms
{

    public partial class frmTicketList : Form
    {
        List<Ticket> list;
        String ticketType;
        Bitmap[] logos;
        Location _startingPoint;
        Location _destinationPoint;
        DateTime _dateTime;
        List<List<Models.Task>> _tasks;
        User user;

        List<Models.Task> _searchTaskPlans;

        ProcessRepository _processRepository;

        List<ExpandoObject> _typesPrice;

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

        public frmTicketList(Location startingPoint, Location destinationPoint, string ticketType, DateTime dateTime, User user)
        {
            InitializeComponent();
            _startingPoint = startingPoint;
            _destinationPoint = destinationPoint;
            _dateTime = dateTime;
            _searchTaskPlans = new List<Models.Task>();
            _processRepository = new ProcessRepository();
            _tasks = new List<List<Models.Task>>();
            _typesPrice = new List<ExpandoObject>();
            this.user = user;

            if (ticketType == "PLANE")
            {
                this.ticketType = "Havalimanı";
            this.logos = planeLogos;
            }
            else if (ticketType == "BUS")
            {
                this.ticketType = "Otobüs terminali";
                this.logos = busLogos;
            }
            else if (ticketType == "FERRY")
            {
                this.ticketType = "Havalimanı";
                this.logos = ferryLogos;
            }

            getTaskPlans();
        }
        public frmTicketList()
        {
            InitializeComponent();
            this.logos = busLogos;

        }

        public void getTaskPlans()
        {
            _tasks = _processRepository.searchByDateAndTrip(_startingPoint, _destinationPoint, ticketType, _dateTime);
            var i = 0;
            foreach (List<Models.Task> task in _tasks)
            {
                createTickers(task, i);
                i++;
            }
        }

        private void createTickers(List<Models.Task> tasks,int index)
        {
            this.panel1.AutoScroll = true;

            int panelCount = 15; // Oluşturulacak panellerin sayısı
            int panelHeight = 90;
            int panelWidth = panel1.Width - 20;
            int topMargin = 0;
            int verticalSpacing = 15;

            for (int i = 0; i < tasks.Count; i++)
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
                label.Text = tasks[0].Process.Time;
                label.Font = new System.Drawing.Font("Verdana", 10);
                panel.Controls.Add(label);

                Label label4 = new Label();
                label4.Size = new System.Drawing.Size(100, 20);
                label4.Location = new System.Drawing.Point(350, 28);
                var label4Text = "";
                double durationDouble = 0;
                foreach (var task in tasks)
                {
                    durationDouble += task.TaskPlan.Duration;
                }
                var list = durationDouble.ToString().Split(".");

                if (list.Length == 1)
                {
                    label4Text = list[0] + "s 00dk";
                }
                else
                {
                    label4Text = list[0] + "s " + (list[1].Length == 1 ? list[1] + "0dk" : list[1]);
                }
                label4.Text = "( "+label4Text+" )";
                label4.Font = new System.Drawing.Font("Verdana", 7);
                panel.Controls.Add(label4);

                Label label2 = new Label();
                label2.Size = new System.Drawing.Size(200, 20);
                label2.Location = new System.Drawing.Point(250, 50);
                label2.Text = tasks[0].TaskPlan.StartingPoint.Name+" - "+ tasks[tasks.Count-1].TaskPlan.DestinationPoint.Name;
                label2.Font = new System.Drawing.Font("Verdana", 10);
                panel.Controls.Add(label2);

                List<string> types = new SeatTypes().getSeatTypes();
                List<ExpandoObject> typesPrices = new List<ExpandoObject>();
                foreach (string type in types)
                {
                    dynamic typesPrice = new ExpandoObject();
                    typesPrice.Type = type;
                    typesPrice.Price = 0.00;
                    typesPrices.Add(typesPrice);
                }


                var y = 0;
                foreach (Models.Task task in tasks)
                {
                    List<ExpandoObject> priceTasks = new TicketPlanRepository().getSeatTypePrices(tasks[y].TaskPlan.Id, tasks[y].TaskPlan.Trip.VehicleId);

                    foreach (dynamic priceTask in priceTasks)
                    {
                        foreach (dynamic typesPrice in typesPrices)
                        {
                            if (typesPrice.Type == priceTask.Type)
                            {
                                typesPrice.Price += priceTask.Price;
                                break;
                            }
                        }
                    }
                    _typesPrice = typesPrices;
                    y++;

                }
                var k = 0;
                foreach(dynamic typesPrice in typesPrices)
                {
                    Label label3 = new Label();
                    label3.AutoSize = true;
                    label3.Location = new System.Drawing.Point(450, 20+(k*15));


                    string price = "";

                    var lista = typesPrice.Price.ToString().Split(".");

                    if (lista.Length == 1)
                    {
                        price = lista[0] + ".00 TL";
                    }
                    else
                    {
                        price = lista[0] + "." + (lista[1].ToString().Length == 1 ? lista[1] + "0" : lista[1]) + " TL";
                    }

                    label3.Text = typesPrice.Type+": "+ price; //ücret eklenecek
                    label3.Font = new System.Drawing.Font("Verdana", 8);
                    panel.Controls.Add(label3);
                    k++;
                }


                Button button = new Button();
                button.Name = index.ToString();
                button.Text = "Buy";
                button.Size = new System.Drawing.Size(100, 35);
                button.Location = new System.Drawing.Point(600, 25);
                button.Font = new System.Drawing.Font("Verdana", 12);
                button.ForeColor = System.Drawing.Color.WhiteSmoke;
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = System.Drawing.Color.FromArgb(98, 102, 244);
                button.Click += Button_Click;

                panel.Controls.Add(button);

                panel1.Controls.Add(panel);
            }

        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            List<Models.Task> clickedTasks = _tasks[Convert.ToInt32(clickedButton.Name)];

            OtobüsKoltuk busSeat = new OtobüsKoltuk(clickedTasks, _typesPrice, user);
            this.Controls.Clear();
            busSeat.TopLevel = false;
            busSeat.FormBorderStyle = FormBorderStyle.None;
            busSeat.Dock = DockStyle.Fill;
            this.Controls.Add(busSeat);
            busSeat.BringToFront();
            busSeat.Show();
        }
    }
}
