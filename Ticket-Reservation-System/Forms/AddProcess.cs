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
    public partial class AddProcess : Form
    {

        FirmRepository _firmRepository;
        WorkerRepository _workerRepository;
        VehicleRepository _vehicleRepository;
        TripRepository _tripRepository;
        TaskPlanRepository _taskPlanRepository;
        TicketPlanRepository _ticketPlanRepository;
        ProcessRepository _processRepository;
        TaskRepository _taskRepository;
        TicketRepository _ticketRepository;

        Firm _selectedFirm;
        Worker _selectedWorker;
        Vehicle _selectedVehicle;
        Trip _selectedTrip;

        Process _process;

        List<Firm> _firms;
        List<Worker> _workers;
        List<Vehicle> _vehicles;
        List<Trip> _trips;
        List<TaskPlan> _taskPlans;

        public AddProcess()
        {
            InitializeComponent();
            _firmRepository = new FirmRepository();
            _workerRepository = new WorkerRepository();
            _vehicleRepository = new VehicleRepository();
            _tripRepository = new TripRepository();
            _taskPlanRepository = new TaskPlanRepository();
            _ticketPlanRepository = new TicketPlanRepository();
            _processRepository = new ProcessRepository();
            _taskRepository = new TaskRepository();
            _ticketRepository = new TicketRepository();

            _selectedFirm = new Firm();
            _selectedWorker = new Worker();
            _selectedVehicle = new Vehicle();
            _selectedTrip = new Trip();
            _process = new Process();

            getFirm();

            comboBoxFirm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWorker.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrip.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void getFirm()
        {
            _firms = _firmRepository.GetAllFirms();
            comboBoxFirm.DataSource = _firms;
            comboBoxFirm.DisplayMember = "Name";
        }
        private void comboBoxFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFirm.Text = "";
            labelWorker.Text = "";
            labelVehicle.Text = "";
            labelTrip.Text = "";

            _selectedTrip = new Trip();
            _selectedWorker = new Worker();
            _selectedVehicle = new Vehicle();

            panel.Controls.Clear();

            _selectedFirm = (Firm)comboBoxFirm.SelectedItem;
            getVehicleByFirm();
            getWorkerByFirm();
            labelFirm.Text = "Firma: " + _selectedFirm.Name;
        }
        private void getWorkerByFirm()
        {
            _workers = _workerRepository.GetWorkerByFirm(_selectedFirm.Id);
            comboBoxWorker.DataSource = _workers;
            comboBoxWorker.DisplayMember = "Name";
        }
        private void getVehicleByFirm()
        {
            _vehicles = _vehicleRepository.GetVehiclesByFirmId(_selectedFirm.Id);
            comboBoxVehicle.DataSource = _vehicles;
            comboBoxVehicle.DisplayMember = "Plate";
        }

        private void comboBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTrip.Text = "";

            _selectedTrip = new Trip();

            panel.Controls.Clear();

            _selectedVehicle = (Vehicle)comboBoxVehicle.SelectedItem;
            labelVehicle.Text = "Araç: " + _selectedVehicle.VehicleModel.Name + " ( " + _selectedVehicle.VehicleModel.VehicleBrand.Name + " ) -> " + _selectedVehicle.Plate;
            getTripsByVehicle();
        }
        private void getTripsByVehicle()
        {
            _trips = _tripRepository.getTripsByVehicle(_selectedVehicle.Id);
            comboBoxTrip.DataSource = _trips;
            comboBoxTrip.DisplayMember = "Description";
        }

        private void comboBoxTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTrip = (Trip)comboBoxTrip.SelectedItem;
            labelTrip.Text = "Rota: " + _selectedTrip.StartingPoint.Name + " --> " + _selectedTrip.DestinationPoint.Name;
            getTaskPlanByTrip();
        }

        private void comboBoxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWorker = (Worker)comboBoxWorker.SelectedItem;
            labelWorker.Text = "Şoför: " + _selectedWorker.Name + " " + _selectedWorker.SurName;
        }

        private void getTaskPlanByTrip()
        {
            _taskPlans = _taskPlanRepository.getTaskPlanByTrip(_selectedTrip.Id);
            panel.Controls.Clear();
            var height = 5;
            var width = 5;

            for (int i = 0; i < _taskPlans.Count; i++)
            {
                TaskPlan taskPlan = _taskPlans[i];

                List<ExpandoObject> _dynamictypePrices = _ticketPlanRepository.getSeatTypePrices(taskPlan.Id, taskPlan.Trip.VehicleId);

                Label labelTrip = new Label();
                labelTrip.AutoSize = true;
                labelTrip.Location = new Point(width, height);
                labelTrip.Text = (taskPlan.Route + 1).ToString() + ". rota -> " + taskPlan.StartingPoint.Name + " --> " + taskPlan.DestinationPoint.Name;
                panel.Controls.Add(labelTrip);
                height += 30;

                Label labelDuration = new Label();
                labelDuration.AutoSize = true;
                labelDuration.Location = new Point(width, height);

                var durationText = "";

                if (taskPlan.Duration.ToString().Split(".").Length == 1)
                {
                    durationText = taskPlan.Duration.ToString() + "s 00dk";
                }
                else
                {
                    durationText = taskPlan.Duration.ToString().Split(".")[0] + "s " +
                        (taskPlan.Duration.ToString().Split(".")[1].Length == 1 ? taskPlan.Duration.ToString().Split(".")[1] + "0" : taskPlan.Duration.ToString().Split(".")[1]) + "dk";

                }

                labelDuration.Text = "Süre: " + durationText;
                panel.Controls.Add(labelDuration);

                foreach (dynamic dynamic in _dynamictypePrices)
                {
                    height += 20;
                    Label labelTypes = new Label();
                    labelTypes.AutoSize = true;
                    labelTypes.Location = new Point(width, height);

                    var priceText = "-";
                    if (dynamic.Price != null)
                    {
                    if ( dynamic.Price.ToString().Split(".").Length == 1)
                    {
                        priceText = dynamic.Price.ToString() + ".00 TL";
                    }
                    else
                    {
                        priceText = dynamic.Price.ToString().Split(".")[0] + "." +
                            (dynamic.Price.ToString().Split(".")[1].Length == 1 ? dynamic.Price.ToString().Split(".")[1] + "0" : dynamic.Price.ToString().Split(".")[1]) + " TL";
                        }
                    }

                    labelTypes.Text = dynamic.Type + ": " + priceText;
                    panel.Controls.Add(labelTypes);
                }
                height += 50;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (formController())
            {
                MessageBox.Show("Kaydedildi.");
                _process = new Process();
                _process.Date = dateTimePickerDate.Value.Date;
                _process.Time = textBoxTime.Text;
                _process.WorkerId = _selectedWorker.Id;
                _process.TripId = _selectedTrip.Id;

                var _savedProcess = _processRepository.AddProcess(_process);

                foreach (var taskPlan in _taskPlans)
                {
                    Models.Task task = new Models.Task();
                    task.ProcessId = _savedProcess.Id;
                    task.TaskPlanId = taskPlan.Id;

                    var _savedTask = _taskRepository.AddTask(task);

                    List<TicketPlan> _ticketPlans = _ticketPlanRepository.GetTicketPlanByTaskPlan(taskPlan.Id);

                    foreach (var ticketPlan in _ticketPlans)
                    {
                        Ticket ticket = new Ticket();
                        ticket.TicketPlanId = ticketPlan.Id;
                        ticket.TaskId = _savedTask.Id;
                        ticket.Status = "ONSALE";
                        ticket.Price = ticketPlan.Price;

                        _ticketRepository.AddTicket(ticket);
                    }

                }
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz.");
            }
        }

        private bool formController()
        {
            if (
                textBoxTime.ToString() != null && comboBoxFirm.SelectedItem != null &&
                comboBoxWorker.SelectedItem != null &&
                comboBoxTrip.SelectedItem != null && comboBoxVehicle.SelectedItem != null)
            {
                return true;
            }
            return false;
        }
    }
}