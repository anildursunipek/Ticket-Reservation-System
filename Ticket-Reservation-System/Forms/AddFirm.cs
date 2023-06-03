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
    public partial class AddFirm : Form
    {
        FirmRepository _firmRepository;
        Firm _firm;
        Firm _selectedFirm;
        List<Firm> _firms;
        public AddFirm()
        {
            InitializeComponent();
            _firmRepository = new FirmRepository();
            _firm = new Firm();
            _selectedFirm = new Firm();

            getFirms();
        }


        private void getFirms()
        {
            _firms = _firmRepository.GetAllFirms();
            listBoxFirm.DataSource = _firms;
            listBoxFirm.DisplayMember = "Name";
        }

        private bool formController()
        {
            if (textBoxFirmName.Text != "" && TextBoxFirmNo.Text != "" && textBoxFirmAddress.Text != "")
            {
                return true;
            }
            return false;
        }

        private void btnAddFirm_Click(object sender, EventArgs e)
        {
            if (formController())
            {
                _firm.Name = textBoxFirmName.Text;
                _firm.PhoneNumber = TextBoxFirmNo.Text;
                _firm.Address = textBoxFirmAddress.Text;

                _firmRepository.AddFirm(_firm);
                MessageBox.Show("Kaydedildi.");
                getFirms();
                textBoxFirmName.Text = "";
                TextBoxFirmNo.Text = "";
                textBoxFirmAddress.Text = "";
                _firm = new Firm();
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz.");
            }
        }

        private void listBoxFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFirm = (Firm)listBoxFirm.SelectedItem;
            btnDeleteFirm.Visible = true;
        }

        private void btnDeleteFirm_Click(object sender, EventArgs e)
        {
            _firmRepository.DeleteFirm(_selectedFirm.Id);
            MessageBox.Show("Silindi.");
            getFirms();
            btnDeleteFirm.Visible = false;
        }
    }
}
