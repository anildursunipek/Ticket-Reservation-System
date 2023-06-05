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
using Ticket_Reservation_System.Models;
using Ticket_Reservation_System.Repositories;

namespace Ticket_Reservation_System.Forms
{
    public partial class OdemeBilgileri : Form
    {
        List<Ticket> _selectedTickets;
        List<Models.Task> _tasks;

        TicketRepository _ticketRepository;
        User user;
        public OdemeBilgileri(List<Ticket> selectedTickets, List<Models.Task> selectedTasks, User user)
        {
            InitializeComponent();
            _selectedTickets = selectedTickets;
            _tasks = selectedTasks;
            _ticketRepository = new TicketRepository();
            this.user = user;
            OvalShape(button1);

            writePanelSeats();
        }

        private void writePanelSeats()
        {
            var width = 5;
            var height = 5;

            var i = 0;
            var j = 0;
            var flag = true;
            var totalPrice = 0.00;
            var total = 0.00;
            foreach (Ticket ticket in _selectedTickets)
            {

                if (i != ticket.TicketPlan.Seat.SeatNumber)
                {
                    height += 12;
                    Label label2 = new Label();
                    label2.AutoSize = true;
                    label2.Location = new System.Drawing.Point(width, height);

                    label2.Text = "Koltuk: " + ticket.TicketPlan.Seat.SeatNumber + " ( " + ticket.TicketPlan.Seat.SeatType + " )";
                    label2.Font = new System.Drawing.Font("Verdana", 7);
                    panelSeat.Controls.Add(label2);

                    height += 15;
                }

                totalPrice += ticket.Price;
                total += ticket.Price;
                Label label3 = new Label();
                label3.AutoSize = true;
                label3.Location = new System.Drawing.Point(width, height);
                label3.Text = ticket.Task.TaskPlan.StartingPoint.Name + " --> " + ticket.Task.TaskPlan.DestinationPoint.Name + "(Fiyat): " + ticket.Price + " TL";
                ;
                label3.Font = new System.Drawing.Font("Verdana", 7);
                panelSeat.Controls.Add(label3);
                height += 13;
                i = ticket.TicketPlan.Seat.SeatNumber;

                if (_selectedTickets.Count-1 == j || i != _selectedTickets[j+1].TicketPlan.Seat.SeatNumber)
                {
                    Label labeltotal = new Label();
                    labeltotal.AutoSize = true;
                    labeltotal.Location = new System.Drawing.Point(width, height);

                    string pricea = "";

                    var listaa = totalPrice.ToString().Split(".");

                    if (listaa.Length == 1)
                    {
                        pricea = listaa[0] + ".00 TL";
                    }
                    else
                    {
                        pricea = listaa[0] + "." + (listaa[1].ToString().Length == 1 ? listaa[1] + "0" : listaa[1]) + " TL";
                    }

                    labeltotal.Text = "Toplam Tutar: " + pricea;
                    labeltotal.Font = new System.Drawing.Font("Verdana", 7);
                    panelSeat.Controls.Add(labeltotal);
                    height += 13;
                    totalPrice = 0.0;
                }

                j++;
            }

            string price = "";

            var lista = total.ToString().Split(".");

            if (lista.Length == 1)
            {
                price = lista[0] + ".00 TL";
            }
            else
            {
                price = lista[0] + "." + (lista[1].ToString().Length == 1 ? lista[1] + "0" : lista[1]) + " TL";
            }
            labelTotal.Text = price;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (formController())
            {
                foreach (Ticket ticket in _selectedTickets)
                {
                    DateTime now = DateTime.Now;
                    DateTime nowInUtc = DateTime.UtcNow;

                    ticket.PurchaseDate = nowInUtc;
                    ticket.Status = "SOLD";
                    ticket.UserId = 1;
                    _ticketRepository.UpdateTicket(ticket);
                }
                MessageBox.Show("Satın alma işlemi başarılı.");
                Form activeForm = Form.ActiveForm;
                activeForm.Close();

            }
            else
            {
                MessageBox.Show("Kart bilgilerini doldurunuz.");
            }
        }

        private bool formController()
        {
            if (textBoxCardName.Text != "" && textBoxCardNumber.Text != "" && textBoxCvv.Text != "" && textBoxLast.Text != "" && checkBoxConfirm.Checked == true)
            {
                return true;
            }
            return false;
        }
    }
}
