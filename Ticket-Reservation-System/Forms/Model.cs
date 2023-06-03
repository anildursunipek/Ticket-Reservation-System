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

namespace Ticket_Reservation_System.Forms
{
    public partial class Model : Form
    {
        VehicleModel _vehicleModel;
        VehicleBrand _selectedVehicleBrand;
        VehicleModel _selectedVehicleModel;
        List<VehicleBrand> _vehicleBrands;
        AppDbContext db;
        dynamic _selectedVehicleType;

        public Model()
        {
            InitializeComponent();
            _vehicleModel = new VehicleModel();
            _selectedVehicleModel = new VehicleModel();
            _selectedVehicleBrand = new VehicleBrand();
            db = new AppDbContext();

            fillVehicleType();
            getVehicleModels();
            comboBoxBrand.DropDownStyle = ComboBoxStyle.DropDownList;

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

        private void getVehicleBrands()
        {
            _vehicleBrands = db.VehicleBrands.ToList().FindAll(a => a.VehicleType == _selectedVehicleType.value);
            comboBoxBrand.DataSource = _vehicleBrands;
            comboBoxBrand.DisplayMember = "Name";
        }

        private void comboBoxVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedVehicleType = comboBoxVehicleType.SelectedItem;
            getVehicleBrands();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if (formController())
            {
                _vehicleModel.Name = textBoxModel.Text;
                _vehicleModel.VehicleBrand = (VehicleBrand) comboBoxBrand.SelectedItem;
                _vehicleModel.VehicleBrandId = _vehicleModel.VehicleBrand.Id;

                db.VehicleModels.Add(_vehicleModel);
                db.SaveChanges();
                MessageBox.Show("Kaydedildi");
                clearForm();
                getVehicleModels();
                _vehicleModel = new VehicleModel();

            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz.");
            }
        }

        private bool formController()
        {
            if (textBoxModel.Text != "" && comboBoxBrand.SelectedItem != null)
            {
                return true;
            }
            return false;
        }

        private void clearForm()
        {
            textBoxModel.Text = "";
        }

        private void getVehicleModels()
        {
            var vehicleModels = db.VehicleModels.ToList();
            listBoxModel.DataSource = vehicleModels;
            listBoxModel.DisplayMember = "Name";
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedVehicleBrand = (VehicleBrand) comboBoxBrand.SelectedItem;
        }

        private void btnDeleteModel_Click(object sender, EventArgs e)
        {
            db.VehicleModels.Remove(_selectedVehicleModel);
            db.SaveChanges();
            MessageBox.Show("Silindi.");
            btnDeleteModel.Visible = false;
            getVehicleModels();
        }
        
        private void listBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedVehicleModel = (VehicleModel)listBoxModel.SelectedItem;
            btnDeleteModel.Visible = true;
        }
    }
}
