using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket_Reservation_System.Models;
using Ticket_Reservation_System.Repositories;

namespace Ticket_Reservation_System.Forms
{

    public partial class OtobüsKoltuk : Form
    {
        List<Models.Task> tasks;
        List<ExpandoObject> typesPrice;
        List<int> _selectedSeatNumbers;
        List<Button> _seatButtons;

        TaskRepository _taskRepository;
        TicketRepository _ticketRepository;

        User user;

        public OtobüsKoltuk(List<Models.Task> clickedTasks, List<ExpandoObject> typesPrice, User user)
        {
            InitializeComponent();
            tasks = clickedTasks;
            this.typesPrice= typesPrice;
            _selectedSeatNumbers = new List<int>();
            _seatButtons = new List<Button>();
            _taskRepository = new TaskRepository();
            _ticketRepository = new TicketRepository();
            this.user = user;

            // Panel'i oval hale getir
            OvalShape(label1);
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

        private void OtobüsKoltuk_Load(object sender, EventArgs e)
        {
            SetButtonStyles(button34);

            SetButtonStyles(button33);
            SetButtonStyles(button32);
            SetButtonStyles(button31);
            SetButtonStyles(button30);
            SetButtonStyles(button29);
            SetButtonStyles(button28);
            SetButtonStyles(button27);
            SetButtonStyles(button19);
            SetButtonStyles(button2);
            SetButtonStyles(button3);
            SetButtonStyles(button20);
            SetButtonStyles(button21);
            SetButtonStyles(button22);
            SetButtonStyles(button24);
            SetButtonStyles(button23);
            SetButtonStyles(button25);
            SetButtonStyles(button25);
            SetButtonStyles(button26);
            SetButtonStyles(button10);
            SetButtonStyles(button13);
            SetButtonStyles(button16);
            SetButtonStyles(button18);
            SetButtonStyles(button17);
            SetButtonStyles(button12);
            SetButtonStyles(button15);
            SetButtonStyles(button7);
            SetButtonStyles(button14);
            SetButtonStyles(button11);
            SetButtonStyles(button5);
            SetButtonStyles(button6);
            SetButtonStyles(button8);
            SetButtonStyles(button9);
            SetButtonStyles(button4);
            SetButtonStyles(button1);

        }
        private void SetButtonStyles(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.MouseOverBackColor = buttonContinue.BackColor;
            button.FlatAppearance.MouseDownBackColor = buttonContinue.BackColor;
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

        private void button3_Click(object sender, EventArgs e)
        {
            SetButtonStyle(button34);

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.BackColor == Color.Gray)
            {
                if (clickedButton.AccessibleName == "NORMAL")
                {
                clickedButton.BackColor = DefaultBackColor; // Eski arka plan rengine dönüş
                }else if (clickedButton.AccessibleName == "PREMIUM")
                {
                    SetButtonPremium(clickedButton);
                }
                else if(clickedButton.AccessibleName == "BUSINESS")
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
                        List<Ticket> tickets = _ticketRepository.getTicketsByTaskAndStatus(task.Id,"ONSALE");
                        foreach (Ticket ticket in tickets)
                        {
                            if (ticket.TicketPlan.Seat.SeatNumber == seatNumber)
                            {
                                selectedTickets.Add(ticket);
                            }
                        }
                    }
                }
                OdemeBilgileri odemeBilgileri = new OdemeBilgileri(selectedTickets,tasks, user);
                odemeBilgileri.Show();
            }
            else
            {
                MessageBox.Show("Lütfen koltuk seçiniz.");
            }
        }
    }
}
