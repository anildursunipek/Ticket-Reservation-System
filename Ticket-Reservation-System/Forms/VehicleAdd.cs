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
    public partial class VehicleAdd : Form
    {
        VehicleRepository _vehicleRepository;
        VehicleModelRepository _vehicleModelRepository;
        FirmRepository _firmRepository;
        SeatRepository _seatRepository;

        Vehicle _selectedVehicle;
        VehicleModel _selectedModel;
        Firm _selectedFirm;
        Vehicle _vehicle;
        dynamic _selectedVehicleType;
        List<ExpandoObject> _dynamicSeats; 


        List<VehicleModel> _vehicleModels;
        List<Vehicle> _vehicles;
        List<Firm> _firms;

        Panel _panel;

        public VehicleAdd()
        {
            InitializeComponent();
            _vehicleRepository = new VehicleRepository();
            _vehicleModelRepository = new VehicleModelRepository();
            _firmRepository = new FirmRepository();
            _seatRepository = new SeatRepository();
            _selectedVehicle = new Vehicle();
            _selectedModel = new VehicleModel();
            _selectedFirm = new Firm();
            _vehicles = new List<Vehicle>();
            _vehicle = new Vehicle();
            _firms = new List<Firm>();
            _vehicleModels = new List<VehicleModel>();
            _dynamicSeats = new List<ExpandoObject>();

            getVehicles();
            getFirms();
            fillVehicleType();

            comboBoxModel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFirm.DropDownStyle = ComboBoxStyle.DropDownList;

            _panel = new Panel();
            _panel.Location = new System.Drawing.Point(220, 10);
            _panel.Size = new System.Drawing.Size(500, 300);
            _panel.AutoScroll = true;
        }

        private List<string> fillComboBoxForDepartment()
        {
            List<string> strList = new List<string>();
            strList.Add("Department 1");
            strList.Add("Department 2");
            strList.Add("Department 3");
            return strList;
        }
        private List<string> fillComboBoxForSeatType()
        {
            List<string> strList = new List<string>();
            strList.Add("NORMAL");
            strList.Add("PREMIUM");
            strList.Add("BUSINESS");
            return strList;
        }
        private void createButtons()
        {
            int buttonWidth = 30;
            int buttonHeight = 30;
            int textBoxWidth = 80;
            int textBoxHeight = 80;
            int spacing = 5; // Butonlar arasındaki boşluk
            bool flag = true;
            var height = 0;
            var width = 0;
            var j = 0;
            
            _dynamicSeats = new List<ExpandoObject>();
            for (int i = 0; i < Convert.ToInt32(textBoxTotalSeat.Text); i++)
            {
                Button dynamicButton = new Button();
                ComboBox dynamicComboBoxDepartment = new ComboBox();
                ComboBox dynamicComboBoxSeatType = new ComboBox();
                dynamic _dynamicSeat = new ExpandoObject();
                dynamicComboBoxDepartment.DataSource = fillComboBoxForDepartment();
                dynamicComboBoxSeatType.DataSource = fillComboBoxForSeatType();

                dynamicComboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
                dynamicComboBoxSeatType.DropDownStyle = ComboBoxStyle.DropDownList;


                dynamicButton.Text = (i + 1).ToString();
                if(i % 2 == 0 && i != 0)
                {
                    flag = flag == true ? false : true;
                    height += buttonWidth+spacing;
                    j = 0;
                    width = 0;
                }
                if(j != 0)
                {
                    width += (textBoxWidth + spacing)+50;
                }
                dynamicButton.Location = new System.Drawing.Point(width, height);
                width += buttonWidth + spacing;
                dynamicComboBoxDepartment.Location = new System.Drawing.Point(width, height);
                width += (textBoxWidth + spacing);
                dynamicComboBoxSeatType.Location = new System.Drawing.Point(width, height);
                dynamicButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

                dynamicComboBoxDepartment.Size = new System.Drawing.Size(textBoxWidth, textBoxHeight);
                dynamicComboBoxSeatType.Size = new System.Drawing.Size(textBoxWidth, textBoxHeight);

                _panel.Controls.Add(dynamicButton);
                _panel.Controls.Add(dynamicComboBoxDepartment);
                _panel.Controls.Add(dynamicComboBoxSeatType);

                _dynamicSeat.Department = dynamicComboBoxDepartment;
                _dynamicSeat.SeatType = dynamicComboBoxSeatType;
                _dynamicSeat.SeatNumber = dynamicButton;

                _dynamicSeats.Add(_dynamicSeat);
                j += 1;
            }
            Controls.Add(_panel);
            
        }


        private void getFirms()
        {
            _firms = _firmRepository.GetAllFirms();
            comboBoxFirm.DataSource = _firms;
            comboBoxFirm.DisplayMember = "Name";

        }


        private void fillVehicleType()
        {
            comboBoxVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVehicleType.Items.Add(new { Name = "Otobüs", value = "Otobüs terminali" });
            comboBoxVehicleType.Items.Add(new { Name = "Uçak", value = "Havalimanı" });
            comboBoxVehicleType.Items.Add(new { Name = "Vapur", value = "İskele" });
            comboBoxVehicleType.DisplayMember = "Name";
            comboBoxVehicleType.SelectedIndex = 0;
        }


        private void getVehicles()
        {
            _vehicles = _vehicleRepository.GetAllVehicles();
            listBoxVehicle.DataSource = _vehicles;
            listBoxVehicle.DisplayMember = "Plate";
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            _vehicleRepository.DeleteVehicle(_selectedVehicle.Id);
            getVehicles();
            MessageBox.Show("Silindi.");
            btnDeleteVehicle.Visible = false;
        }

        private void listBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedVehicle = (Vehicle) listBoxVehicle.SelectedItem;
            btnDeleteVehicle.Visible = true;
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            if (formController())
            {
                _vehicle.TotalSeat = Convert.ToInt32(textBoxTotalSeat.Text);
                _vehicle.Plate = textBoxPlate.Text;
                _vehicle.VehicleModelId = _selectedModel.Id;
                _vehicle.FirmId = _selectedFirm.Id;

                var savedVehicle = _vehicleRepository.AddVehicle(_vehicle);

                foreach(dynamic dynamicSeat in _dynamicSeats)
                {
                    Seat seat = new Seat();
                    seat.VehicleId = savedVehicle.Id;
                    seat.SeatNumber = Convert.ToInt32(dynamicSeat.SeatNumber.Text);
                    seat.Department = dynamicSeat.Department.Text;
                    seat.SeatType = dynamicSeat.SeatType.Text;
                    _seatRepository.AddSeat(seat);

                }

                _vehicle = new Vehicle();
                textBoxTotalSeat.Text = "";
                textBoxPlate.Text = "";
                _panel.Controls.Clear();
                getVehicles();
                MessageBox.Show("Kaydedildi.");
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz.");
            }
        }
        private bool formController()
        {
            if(textBoxPlate.Text != "" && textBoxTotalSeat.Text != "" && comboBoxVehicleType.SelectedItem != null && comboBoxModel.SelectedItem != null && comboBoxFirm.SelectedItem != null)
            {
                if(_dynamicSeats.Count() == 0)
                {
                    createButtons();
                    return false;
                }
                return true;
            }
            return false;
        }

        private void comboBoxVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedVehicleType = (dynamic) comboBoxVehicleType.SelectedItem;
            getModelsByVehicleyType();
        }

        private void getModelsByVehicleyType() {
            _vehicleModels = _vehicleModelRepository.getModelsByVehicleyType(_selectedVehicleType.value);
            comboBoxModel.DataSource = _vehicleModels;
            comboBoxModel.DisplayMember = "Name";
        }
        
        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedModel = (VehicleModel) comboBoxModel.SelectedItem;
        }

        private void comboBoxFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFirm = (Firm) comboBoxFirm.SelectedItem;
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            if(textBoxTotalSeat.Text != null)
            {
                _panel.Controls.Clear();
                createButtons();
            }
        }

    }
}
