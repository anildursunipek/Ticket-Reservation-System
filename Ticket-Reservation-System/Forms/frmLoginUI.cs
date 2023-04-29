using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Reservation_System
{
    public partial class frmLoginUI : Form
    {
        public frmLoginUI()
        {
            InitializeComponent();

        }

        Thread thread;
        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Clear();
            if (txtPassword.Text == "")
                txtPassword.Text = "Password";

            pbUsername.BackgroundImage = Properties.Resources.user4;
            panelUsername.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            pbPassword.BackgroundImage = Properties.Resources.password;
            panelPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Clear();
            if (txtUsername.Text == "")
                txtUsername.Text = "Username";

            pbPassword.BackgroundImage = Properties.Resources.password2;
            panelPassword.BackColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            pbUsername.BackgroundImage = Properties.Resources.user3;
            panelUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            this.thread = new Thread(() => openNewForm(new frmSignUpUI()));
            this.thread.SetApartmentState(ApartmentState.STA);
            this.thread.Start();
        }

        public void openNewForm(Form frm)
        {
            Application.Run(frm);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "123" && txtPassword.Text == "123")
            {
                this.Close();
                this.thread = new Thread(() => openNewForm(new frmMenu()));
                this.thread.SetApartmentState(ApartmentState.STA);
                this.thread.Start();
            }
        }
    }
}
