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
    public partial class Brand : Form
    {
        AppDbContext db;
        VehicleBrandRepository _vehicleBrandRepository;
        VehicleBrand _vehicleBrand;
        VehicleBrand _selectedVehicleBrand;
        List<VehicleBrand> _vehicleBrands;
        public Brand()
        {
            InitializeComponent();
            db = new AppDbContext();
            _vehicleBrandRepository = new VehicleBrandRepository();
            _vehicleBrand = new VehicleBrand();
            _selectedVehicleBrand = new VehicleBrand();

            getVehicleBrands();
            fillVehicleType();
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
            _vehicleBrands = _vehicleBrandRepository.GetAllVehicleBrands();
            listBoxBrand.DataSource = _vehicleBrands;
            listBoxBrand.DisplayMember = "Name";
        }

        private void btnSaveBrand_Click(object sender, EventArgs e)
        {
            if (formController())
            {
                _vehicleBrand.Name = textBoxBrandName.Text;
                _vehicleBrand.VehicleType = ((dynamic)comboBoxVehicleType.SelectedItem).value;

                _vehicleBrandRepository.AddVehicleBrand(_vehicleBrand);
                MessageBox.Show("Kaydedildi.");
                getVehicleBrands();
                textBoxBrandName.Text = "";
                _vehicleBrand = new VehicleBrand();
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz.");
            }
        }

        private bool formController()
        {
            if(textBoxBrandName.Text != "")
            {
                return true;
            }
            return false;
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            _vehicleBrandRepository.DeleteVehicleBrand(_selectedVehicleBrand.Id);
            MessageBox.Show("Silindi.");
            getVehicleBrands();
            btnDeleteBrand.Visible = false;
        }

        private void listBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedVehicleBrand = (VehicleBrand) listBoxBrand.SelectedItem;
            btnDeleteBrand.Visible = true;

        }
    }
}
