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
    public partial class AddWorker : Form
    {
        WorkerRepository _workerRepository;
        FirmRepository _firmRepository;

        Firm _selectedFirm;
        Worker _worker;
        Worker _selectedWorker;

        List<Worker> _workers;
        List<Firm> _firms;
        public AddWorker()
        {
            InitializeComponent();
            _workerRepository = new WorkerRepository();
            _firmRepository = new FirmRepository();
            _selectedFirm = new Firm();
            _worker = new Worker();
            _selectedWorker = new Worker();
            _workers = new List<Worker>();
            _firms = new List<Firm>();

            getFirms();

            comboBoxFirm.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void getWorkerByFirm()
        {
             _workers = _workerRepository.GetWorkerByFirm(_selectedFirm.Id);
            listBoxWorker.DataSource = _workers;
            listBoxWorker.DisplayMember = "Name";

        }
        private void getFirms()
        {
            _firms = _firmRepository.GetAllFirms();
            comboBoxFirm.DataSource = _firms;
            comboBoxFirm.DisplayMember = "Name";

        }
        private void listBoxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWorker = (Worker) listBoxWorker.SelectedItem;
            btnDeleteWorker.Visible = true;
        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            _workerRepository.DeleteWorker(_selectedWorker.Id);
            MessageBox.Show("Silindi.");
            getWorkerByFirm();
            btnDeleteWorker.Visible = false;
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            if (formController())
            {
                _worker.Name = textBoxName.Text;
                _worker.SurName = textBoxSurname.Text;
                _worker.Tc = textBoxTc.Text;
                _worker.Email = textBoxEmail.Text;
                _worker.Age = Convert.ToInt32(textBoxAge.Text);
                _worker.PhoneNumber = textBoxPhoneNumber.Text;
                _worker.Role = textBoxPosition.Text;
                _worker.FirmId = ((Firm)comboBoxFirm.SelectedItem).Id;

                _workerRepository.AddWorker(_worker);
                MessageBox.Show("Kaydedildi.");
                _worker = new Worker();
                getWorkerByFirm();
                clearForm();
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz.");
            }
        }
        private bool formController()
        {
            if (
                textBoxName.Text != "" && textBoxSurname.Text != "" &&
                textBoxTc.Text != "" && textBoxEmail.Text != "" && textBoxAge.Text != "" &&
                textBoxPhoneNumber.Text != "" && textBoxPosition.Text != "" && comboBoxFirm.SelectedItem != null
                )
            {
                return true;
            }
            return false;
        }

        private void clearForm()
        {
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxTc.Text = "";
            textBoxEmail.Text = "";
            textBoxAge.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxPosition.Text = "";
        }

        private void comboBoxFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFirm = (Firm) comboBoxFirm.SelectedItem;
            getWorkerByFirm();
        }
    }
}
