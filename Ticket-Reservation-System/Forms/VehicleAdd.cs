using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        Vehicle _selectedVehicle;
        VehicleModel _selectedModel;
        Firm _selectedFirm;
        Vehicle _vehicle;
        dynamic _selectedVehicleType;


        List<VehicleModel> _vehicleModels;
        List<Vehicle> _vehicles;
        List<Firm> _firms;
        public VehicleAdd()
        {
            InitializeComponent();
            _vehicleRepository = new VehicleRepository();
            _vehicleModelRepository = new VehicleModelRepository();
            _firmRepository = new FirmRepository();
            _selectedVehicle = new Vehicle();
            _selectedModel = new VehicleModel();
            _selectedFirm = new Firm();
            _vehicles = new List<Vehicle>();
            _firms = new List<Firm>();
            _vehicleModels = new List<VehicleModel>();

            getVehicles();
            getFirms();
            fillVehicleType();

            comboBoxModel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFirm.DropDownStyle = ComboBoxStyle.DropDownList;
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
                _vehicle.TotalSeat = Convert.ToInt32(textBoxTotalSeat);
                _vehicle.Plate = textBoxTotalSeat.Text;
                _vehicle.VehicleModel = _selectedModel;
                _vehicle.VehicleModelId = _selectedModel.Id;
                _vehicle.Firm = _selectedFirm;
                _vehicle.FirmId = _selectedFirm.Id;

                _vehicleRepository.AddVehicle(_vehicle);
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
            if(textBoxTotalSeat.Text != "" && textBoxTotalSeat.Text.ToString() != "" && comboBoxVehicleType.SelectedItem != null && comboBoxModel.SelectedItem != null && comboBoxFirm.SelectedItem != null)
            {
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
    }
}
