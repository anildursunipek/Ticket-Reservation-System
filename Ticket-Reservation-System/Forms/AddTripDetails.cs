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
    public partial class AddTripDetails : Form
    {
        Trip _trip;
        List<Location> _locations;

        SeatRepository _seatRepository;
        TaskPlanRepository _taskPlanRepository;
        TripRepository _tripRepository;
        TicketPlanRepository _ticketPlanRepository;
        List<Seat> _seats;

        dynamic _dynamic;

        public AddTripDetails(Trip trip, List<Location> locations)
        {
            InitializeComponent();
            _trip = trip;
            _locations = locations;

            _seatRepository = new SeatRepository();
            _tripRepository = new TripRepository();
            _taskPlanRepository = new TaskPlanRepository();
            _ticketPlanRepository = new TicketPlanRepository();
            _seats = new List<Seat>();
            _dynamic = new List<ExpandoObject>();

            getSeatByVehicle();
            fillPanel();
        }

        private void fillPanel()
        {
            int spacing = 20; // Butonlar arasındaki boşluk
            var height = 0;
            var width = 10;
            var buttonWidth = 30;
            var buttonHeight = 30;

            Label dynamicLabelTrip = new Label();
            dynamicLabelTrip.AutoSize = true;
            dynamicLabelTrip.Text = "Açıklama: " + _trip.Description;
            dynamicLabelTrip.Location = new System.Drawing.Point(width, height);
            height += spacing;

            Label dynamicLabelDuration = new Label();
            dynamicLabelDuration.AutoSize = true;
            dynamicLabelDuration.Text = "Süre: " + _trip.Duration.ToString().Split(".")[0] + "s " + (_trip.Duration.ToString().Split(".")[1].Length == 1 ? _trip.Duration.ToString().Split(".")[1] + "0" : _trip.Duration.ToString().Split(".")[1]) + "dk";
            dynamicLabelDuration.Location = new System.Drawing.Point(width, height);
            height += spacing;

            Label dynamicLabelLongTrip = new Label();
            dynamicLabelLongTrip.AutoSize = true;
            dynamicLabelLongTrip.Text = "Rota: " + _trip.StartingPoint.Name + " --> " + _trip.DestinationPoint.Name;
            dynamicLabelLongTrip.Location = new System.Drawing.Point(width, height);
            height += spacing;

            Label dynamicLabelFirmAndVehicle = new Label();
            dynamicLabelFirmAndVehicle.AutoSize = true;
            dynamicLabelFirmAndVehicle.Text = "Firma ve Araç: " + _trip.Vehicle.Firm.Name+ " ( " + _trip.Vehicle.Plate + " )"; 
            dynamicLabelFirmAndVehicle.Location = new System.Drawing.Point(width, height);
            height += 60;

            panel.Controls.Add(dynamicLabelTrip);
            panel.Controls.Add(dynamicLabelDuration);
            panel.Controls.Add(dynamicLabelLongTrip);
            panel.Controls.Add(dynamicLabelFirmAndVehicle);

            for (int i = 1; i < _locations.Count; i++)
            {
                dynamic dynamicSeat = new ExpandoObject();

                dynamicSeat.StartingPointId = _locations[i - 1].Id;
                dynamicSeat.DestinationPointId = _locations[i].Id;

                Label dynamicLabelShortTrip = new Label();
                dynamicLabelShortTrip.AutoSize = true;
                dynamicLabelShortTrip.Text = "Rota: " + _locations[i-1].Name + " --> " + _locations[i].Name;
                dynamicLabelShortTrip.Location = new System.Drawing.Point(width, height);
                width += 345;

                TextBox dynamicTextBoxDuration = new TextBox();
                dynamicTextBoxDuration.Size = new System.Drawing.Size(50, buttonHeight);
                dynamicTextBoxDuration.Text = "0";
                dynamicTextBoxDuration.Location = new System.Drawing.Point(width, height);
                width += 55;
                dynamicSeat.Duration = dynamicTextBoxDuration;

                ComboBox dynamicComboBoxType = new ComboBox();
                dynamicComboBoxType.Size = new System.Drawing.Size(80, buttonHeight);
                dynamicComboBoxType.DataSource = fillSeatType();
                dynamicComboBoxType.Location = new System.Drawing.Point(width, height);
                dynamicComboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
                width += 85;
                dynamicSeat.ComboBoxType = dynamicComboBoxType;

                TextBox dynamicTextBoxTypePrice = new TextBox();
                dynamicTextBoxTypePrice.Size = new System.Drawing.Size(50, buttonHeight);
                dynamicTextBoxTypePrice.Text = "0";
                dynamicTextBoxTypePrice.Location = new System.Drawing.Point(width, height);
                width += 55;
                dynamicSeat.TextBoxTypePrice = dynamicTextBoxTypePrice;

                Button dynamicButtonPrice = new Button();
                dynamicButtonPrice.Size = new System.Drawing.Size(80, buttonHeight);
                dynamicButtonPrice.Name = (i - 0).ToString();
                dynamicButtonPrice.Text = "Uygula";
                dynamicButtonPrice.Location = new System.Drawing.Point(width, height);
                dynamicButtonPrice.Click += dynamicButtonPrice_Click;
                dynamicSeat.ButtonPrice = dynamicButtonPrice;


                height += spacing + 15;
                width = 10;
                List<ExpandoObject> dynamicObjects = new List<ExpandoObject>();

                for (int j = 0; j < _seats.Count; j++)
                {
                    dynamic dynamicObject = new ExpandoObject();

                    if (j != 0 && j % 4 == 0)
                    {
                        width = 10;
                        height += 30;
                    }

                    Button dynamicButton = new Button();
                    dynamicButton.Text = _seats[j].SeatNumber.ToString();
                    dynamicButton.Location = new System.Drawing.Point(width, height);
                    dynamicButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                    width += buttonWidth + 5;

                    Label dynamicLabelSeatType = new Label();
                    dynamicLabelSeatType.AutoSize = true;
                    dynamicLabelSeatType.Text = _seats[j].SeatType;
                    dynamicLabelSeatType.Location = new System.Drawing.Point(width, height);
                    width += buttonWidth + 35;
                    dynamicObject.LabelSeatType = dynamicLabelSeatType;

                    TextBox dynamicPrice = new TextBox();
                    dynamicPrice.Name = j.ToString();
                    dynamicPrice.Text = "0.00";
                    dynamicPrice.Location = new System.Drawing.Point(width, height);
                    dynamicPrice.Size = new System.Drawing.Size(buttonWidth + 20, buttonHeight);
                    width += buttonWidth + 25;
                    dynamicObject.TextBoxPrice = dynamicPrice;

                    dynamicObjects.Add(dynamicObject);

                    panel.Controls.Add(dynamicLabelShortTrip);
                    panel.Controls.Add(dynamicButton);
                    panel.Controls.Add(dynamicComboBoxType);
                    panel.Controls.Add(dynamicTextBoxTypePrice);
                    panel.Controls.Add(dynamicLabelSeatType);
                    panel.Controls.Add(dynamicPrice);
                    panel.Controls.Add(dynamicButtonPrice);
                    panel.Controls.Add(dynamicTextBoxDuration);
                }

                dynamicSeat.DynamicObjects = dynamicObjects;
                _dynamic.Add(dynamicSeat);
                width = 10;
                height += 50;
            }

            Controls.Add(panel);

        }

        private void dynamicButtonPrice_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;


            for (var i = 0; i < _dynamic.Count; i++)
            {
                if (_dynamic[i].ButtonPrice.Name == clickedButton.Name)
                {
                    if (_dynamic[i].TextBoxTypePrice.Text != "")
                    {
                        for (var j = 0; j < _dynamic[i].DynamicObjects.Count; j++)
                        {
                            if (_dynamic[i].ComboBoxType.SelectedItem == _dynamic[i].DynamicObjects[j].LabelSeatType.Text)
                            {
                                _dynamic[i].DynamicObjects[j].TextBoxPrice.Text = _dynamic[i].TextBoxTypePrice.Text;
                            }
                        }
                        break;
                    }
                }
            }

        }

        private List<string> fillSeatType()
        {
            return new SeatTypes().getSeatTypes();
        }
        private void getSeatByVehicle()
        {
            _seats = _seatRepository.GetSeatByVehichle(_trip.VehicleId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _trip.Vehicle = null;
            _trip.StartingPoint = null;
            _trip.DestinationPoint = null;
            var savedTrip = _tripRepository.AddTrip(_trip);

            for (var i = 0; i < _dynamic.Count; i++)
            {
                TaskPlan taskPlan = new TaskPlan();
                taskPlan.Route = i;
                taskPlan.StartingPointId = _dynamic[i].StartingPointId;
                taskPlan.DestinationPointId = _dynamic[i].DestinationPointId;
                taskPlan.Duration = Convert.ToDouble(_dynamic[i].Duration.Text);
                taskPlan.TripId = savedTrip.Id;

                var savedTaskPlan = _taskPlanRepository.AddTaskPlan(taskPlan);

                for (var j = 0; j < _dynamic[i].DynamicObjects.Count; j++)
                {
                    TicketPlan ticketPlan = new TicketPlan();
                    ticketPlan.SeatId = _seats[Convert.ToInt32(_dynamic[i].DynamicObjects[j].TextBoxPrice.Name)].Id;
                    ticketPlan.Price = Convert.ToDouble(_dynamic[i].DynamicObjects[j].TextBoxPrice.Text);
                    ticketPlan.TaskPlanId = savedTaskPlan.Id;

                    _ticketPlanRepository.AddTicketPlan(ticketPlan);
                }
            }
        }
    }
}
