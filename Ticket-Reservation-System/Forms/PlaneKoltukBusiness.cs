using Guna.UI2.WinForms;
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
    public partial class PlaneKoltukBusiness : Form
    {
        List<Models.Task> tasks;
        List<ExpandoObject> typesPrice;
        List<int> _selectedSeatNumbers;
        List<Button> _seatButtons;

        TaskRepository _taskRepository;
        TicketRepository _ticketRepository;

        User user;
        public PlaneKoltukBusiness(List<Models.Task> clickedTasks, List<ExpandoObject> typesPrice, User user)
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
            _seatButtons.Add(button1);
            _seatButtons.Add(button2);
            _seatButtons.Add(button3);
            _seatButtons.Add(button4);
            _seatButtons.Add(button5);
            _seatButtons.Add(button6);
            _seatButtons.Add(button7);
            _seatButtons.Add(button8);
            _seatButtons.Add(button9);
            _seatButtons.Add(button10);
            _seatButtons.Add(button11);
            _seatButtons.Add(button12);
            _seatButtons.Add(button13);
            _seatButtons.Add(button14);
            _seatButtons.Add(button15);
            _seatButtons.Add(button16);
            _seatButtons.Add(button17);
            _seatButtons.Add(button18);
            _seatButtons.Add(button19);
            _seatButtons.Add(button20);
            _seatButtons.Add(button21);
            _seatButtons.Add(button22);
            _seatButtons.Add(button23);
            _seatButtons.Add(button24);
            _seatButtons.Add(button25);
            _seatButtons.Add(button26);
            _seatButtons.Add(button27);
            _seatButtons.Add(button28);
            _seatButtons.Add(button29);
            _seatButtons.Add(button30);
            _seatButtons.Add(button31);
            _seatButtons.Add(button32);
            _seatButtons.Add(button33);
            _seatButtons.Add(button34);
            _seatButtons.Add(button35);
            _seatButtons.Add(button36);
            _seatButtons.Add(button37);
            _seatButtons.Add(button38);
            _seatButtons.Add(button39);
            _seatButtons.Add(button40);
            _seatButtons.Add(button41);
            _seatButtons.Add(button42);
            _seatButtons.Add(button43);
            _seatButtons.Add(button44);
            _seatButtons.Add(button45);
            _seatButtons.Add(button46);
            _seatButtons.Add(button47);
            _seatButtons.Add(button48);
            _seatButtons.Add(button49);
            _seatButtons.Add(button50);
            _seatButtons.Add(button51);
            _seatButtons.Add(button52);
            _seatButtons.Add(button53);
            _seatButtons.Add(button54);
            _seatButtons.Add(button55);
            _seatButtons.Add(button56);
            _seatButtons.Add(button57);
            _seatButtons.Add(button58);
            _seatButtons.Add(button59);
            _seatButtons.Add(button60);
            _seatButtons.Add(button61);
            _seatButtons.Add(button62);
            _seatButtons.Add(button63);
            _seatButtons.Add(button64);
            _seatButtons.Add(button65);
            _seatButtons.Add(button66);
            _seatButtons.Add(button67);
            _seatButtons.Add(button68);
            _seatButtons.Add(button69);
            _seatButtons.Add(button70);
            _seatButtons.Add(button71);
            _seatButtons.Add(button72);
            _seatButtons.Add(button73);
            _seatButtons.Add(button74);
            _seatButtons.Add(button75);
            _seatButtons.Add(button76);
            _seatButtons.Add(button77);
            _seatButtons.Add(button78);
            _seatButtons.Add(button79);
            _seatButtons.Add(button80);
            _seatButtons.Add(button81);
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
