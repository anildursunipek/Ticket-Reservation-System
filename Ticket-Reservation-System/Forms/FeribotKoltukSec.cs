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
    public partial class FeribotKoltukSec : Form
    {
        List<Models.Task> tasks;
        List<ExpandoObject> typesPrice;
        List<int> _selectedSeatNumbers;
        List<Button> _seatButtons;

        TaskRepository _taskRepository;
        TicketRepository _ticketRepository;

        User user;
        public FeribotKoltukSec(List<Models.Task> clickedTasks, List<ExpandoObject> typesPrice, User user)
        {
            InitializeComponent();
            tasks = clickedTasks;
            this.typesPrice = typesPrice;
            _selectedSeatNumbers = new List<int>();
            _seatButtons = new List<Button>();
            _taskRepository = new TaskRepository();
            _ticketRepository = new TicketRepository();
            this.user = user;

            fillSeatButtons();
            priceFill();
            fullOrNullSeatButtons();
        }

        private void priceFill()
        {
            labelNormal.Text = "-";
            labelPremium.Text = "-";
            labelBusiness.Text = "-";
            foreach (dynamic typePrice in typesPrice)
            {
                if (typePrice.Price != null)
                {

                    string price = "";

                    var list = typePrice.Price.ToString().Split(".");

                    if (list.Length == 1)
                    {
                        price = list[0] + ".00 TL";
                    }
                    else
                    {
                        price = list[0] + "." + (list[1].ToString().Length == 1 ? list[1] + "0" : list[1]) + " TL";
                    }


                    if (typePrice.Type == "NORMAL")
                    {
                        labelNormal.Text = price;
                    }
                    else if (typePrice.Type == "PREMIUM")
                    {
                        labelPremium.Text = price;
                    }
                    else if (typePrice.Type == "BUSINESS")
                    {
                        labelBusiness.Text = price;
                    }
                }
            }
        }

        private void fullOrNullSeatButtons()
        {
            foreach (var task in tasks)
            {
                List<Ticket> tickets = _ticketRepository.getTicketsByTask(task.Id);

                foreach (Ticket ticket in tickets)
                {
                    if (ticket.Status == "SOLD")
                    {
                        SetButtonFull(_seatButtons.Find(b => b.Text == ticket.TicketPlan.Seat.SeatNumber.ToString()));
                    }
                }

                foreach (Button seatButton in _seatButtons)
                {
                    var findTicket = tickets.Find(ticket => ticket.TicketPlan.Seat.SeatNumber.ToString() == seatButton.Text);
                    if (findTicket != null)
                    {
                        if (findTicket.TicketPlan.Seat.SeatType == "PREMIUM")
                        {
                            seatButton.AccessibleName = "PREMIUM";
                            SetButtonPremium(seatButton);
                        }
                        else if (findTicket.TicketPlan.Seat.SeatType == "BUSINESS")
                        {
                            seatButton.AccessibleName = "BUSINESS";
                            SetButtonBusiness(seatButton);
                        }
                        else
                        {
                            seatButton.AccessibleName = "NORMAL";
                        }
                    }
                }

            }
        }


        private void fillSeatButtons()
        {
            _seatButtons.Add(b1);
            _seatButtons.Add(b2);
            _seatButtons.Add(b3);
            _seatButtons.Add(b4);
            _seatButtons.Add(b5);
            _seatButtons.Add(b6);
            _seatButtons.Add(b7);
            _seatButtons.Add(b8);
            _seatButtons.Add(b9);
            _seatButtons.Add(b10);
            _seatButtons.Add(b11);
            _seatButtons.Add(b12);
            _seatButtons.Add(b13);
            _seatButtons.Add(b14);
            _seatButtons.Add(b15);
            _seatButtons.Add(b16);
            _seatButtons.Add(b17);
            _seatButtons.Add(b18);
            _seatButtons.Add(b19);
            _seatButtons.Add(b20);
            _seatButtons.Add(b21);
            _seatButtons.Add(b22);
            _seatButtons.Add(b23);
            _seatButtons.Add(b24);
            _seatButtons.Add(b25);
            _seatButtons.Add(b26);
            _seatButtons.Add(b27);
            _seatButtons.Add(b28);
            _seatButtons.Add(b29);
            _seatButtons.Add(b30);
            _seatButtons.Add(b31);
            _seatButtons.Add(b32);
            _seatButtons.Add(b33);
            _seatButtons.Add(b34);
            _seatButtons.Add(b35);
            _seatButtons.Add(b36);
            _seatButtons.Add(b37);
            _seatButtons.Add(b38);
            _seatButtons.Add(b39);
            _seatButtons.Add(b40);
            _seatButtons.Add(b41);
            _seatButtons.Add(b42);
            _seatButtons.Add(b43);
            _seatButtons.Add(b44);
            _seatButtons.Add(b45);
            _seatButtons.Add(b46);
            _seatButtons.Add(b47);
            _seatButtons.Add(b48);
            _seatButtons.Add(b49);
            _seatButtons.Add(b50);
            _seatButtons.Add(b51);
            _seatButtons.Add(b52);
            _seatButtons.Add(b53);
            _seatButtons.Add(b54);
            _seatButtons.Add(b55);
            _seatButtons.Add(b56);
            _seatButtons.Add(b57);
            _seatButtons.Add(b58);
            _seatButtons.Add(b59);
            _seatButtons.Add(b60);
            _seatButtons.Add(b61);
            _seatButtons.Add(b62);
            _seatButtons.Add(b63);
            _seatButtons.Add(b64);
            _seatButtons.Add(b65);
            _seatButtons.Add(b66);
            _seatButtons.Add(b67);
            _seatButtons.Add(b68);
            _seatButtons.Add(b69);
            _seatButtons.Add(b70);
            _seatButtons.Add(b71);
            _seatButtons.Add(b72);
            _seatButtons.Add(b73);
            _seatButtons.Add(b74);
            _seatButtons.Add(b75);
            _seatButtons.Add(b76);
            _seatButtons.Add(b77);
            _seatButtons.Add(b78);
            _seatButtons.Add(b79);
            _seatButtons.Add(b80);
            _seatButtons.Add(b81);
            _seatButtons.Add(b82);
            _seatButtons.Add(b83);
            _seatButtons.Add(b84);
            _seatButtons.Add(b85);
            _seatButtons.Add(b86);
            _seatButtons.Add(b87);
            _seatButtons.Add(b88);
            _seatButtons.Add(b89);
            _seatButtons.Add(b90);
            _seatButtons.Add(b91);
            _seatButtons.Add(b92);
            _seatButtons.Add(b93);
            _seatButtons.Add(b94);
            _seatButtons.Add(b95);
            _seatButtons.Add(b96);
            _seatButtons.Add(b97);
            _seatButtons.Add(b98);
            _seatButtons.Add(b99);
            _seatButtons.Add(b100);
            _seatButtons.Add(b101);
            _seatButtons.Add(b102);
            _seatButtons.Add(b103);
            _seatButtons.Add(b104);
            _seatButtons.Add(b105);
            _seatButtons.Add(b106);
            _seatButtons.Add(b107);
            _seatButtons.Add(b108);
            _seatButtons.Add(b109);
            _seatButtons.Add(b110);
            _seatButtons.Add(b111);
            _seatButtons.Add(b112);
            _seatButtons.Add(b113);
            _seatButtons.Add(b114);
            _seatButtons.Add(b115);
            _seatButtons.Add(b116);
            _seatButtons.Add(b117);
            _seatButtons.Add(b118);
            _seatButtons.Add(b119);
            _seatButtons.Add(b120);
            _seatButtons.Add(b121);
            _seatButtons.Add(b122);
            _seatButtons.Add(b123);
            _seatButtons.Add(b124);
            _seatButtons.Add(b125);
            _seatButtons.Add(b126);
            _seatButtons.Add(b127);
            _seatButtons.Add(b128);
            _seatButtons.Add(b129);
            _seatButtons.Add(b130);
            _seatButtons.Add(b131);
            _seatButtons.Add(b132);
            _seatButtons.Add(b133);
            _seatButtons.Add(b134);
        }
        private void SetButtonStyle(Button button)
        {
            button.BackColor = Color.Gray;
        }
        private void SetButtonFull(Button button)
        {
            button.BackColor = Color.Green;
        }
        private void SetButtonPremium(Button button)
        {
            if (button.BackColor != Color.Green)
            {
                button.BackColor = Color.Yellow;
            }
        }
        private void SetButtonBusiness(Button button)
        {
            if (button.BackColor != Color.Green)
            {
                button.BackColor = Color.Gold;
            }
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

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.BackColor == Color.Gray)
            {
                if (clickedButton.AccessibleName == "NORMAL")
                {
                    clickedButton.BackColor = Color.Transparent; // Eski arka plan rengine dönüş
                }
                else if (clickedButton.AccessibleName == "PREMIUM")
                {
                    SetButtonPremium(clickedButton);
                }
                else if (clickedButton.AccessibleName == "BUSINESS")
                {
                    SetButtonBusiness(clickedButton);
                }
                _selectedSeatNumbers.Remove(Convert.ToInt32(clickedButton.Text));

            }
            else
            {
                if (clickedButton.BackColor != Color.Green)
                {
                    clickedButton.BackColor = Color.Gray; // Yeni arka plan rengi
                    _selectedSeatNumbers.Add(Convert.ToInt32(clickedButton.Text));
                }
                else
                {
                    MessageBox.Show("Bu koltuk dolu.");
                }
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (_selectedSeatNumbers.Count != 0)
            {

                List<Ticket> selectedTickets = new List<Ticket>();

                foreach (int seatNumber in _selectedSeatNumbers)
                {

                    foreach (Models.Task task in tasks)
                    {
                        List<Ticket> tickets = _ticketRepository.getTicketsByTaskAndStatus(task.Id, "ONSALE");
                        foreach (Ticket ticket in tickets)
                        {
                            if (ticket.TicketPlan.Seat.SeatNumber == seatNumber)
                            {
                                selectedTickets.Add(ticket);
                            }
                        }
                    }
                }
                OdemeBilgileri odemeBilgileri = new OdemeBilgileri(selectedTickets, tasks, user);
                odemeBilgileri.Show();
            }
            else
            {
                MessageBox.Show("Lütfen koltuk seçiniz.");
            }
        }
    }
}