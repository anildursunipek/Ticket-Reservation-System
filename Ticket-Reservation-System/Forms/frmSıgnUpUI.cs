using Ticket_Reservation_System.Models;
using Ticket_Reservation_System.Repositories;

namespace Ticket_Reservation_System
{
    public partial class frmSignUpUI : Form
    {
        public frmSignUpUI()
        {
            InitializeComponent();
        }
        Thread thread;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Username")
                txtName.Clear();
            if (txtEmail.Text == "")
                txtEmail.Text = "Password";
            if (txtUsername.Text == "")
                txtUsername.Text = "Email";

            pbUsername.BackgroundImage = Properties.Resources.user4;
            panelUsername.BackColor = Color.FromArgb(78, 184, 206);
            txtName.ForeColor = Color.FromArgb(78, 184, 206);

            pbPassword.BackgroundImage = Properties.Resources.password;
            panelPassword.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.WhiteSmoke;

            txtEmail.BackgroundImage = Properties.Resources.mail3;
            panelEmail.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Password")
                txtEmail.Clear();
            if (txtName.Text == "")
                txtName.Text = "Username";
            if (txtUsername.Text == "")
                txtUsername.Text = "Email";

            pbPassword.BackgroundImage = Properties.Resources.password2;
            panelPassword.BackColor = Color.FromArgb(78, 184, 206);
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);

            pbUsername.BackgroundImage = Properties.Resources.user3;
            panelUsername.BackColor = Color.WhiteSmoke;
            txtName.ForeColor = Color.WhiteSmoke;

            txtEmail.BackgroundImage = Properties.Resources.mail3;
            panelEmail.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Email")
                txtUsername.Clear();
            if (txtName.Text == "")
                txtName.Text = "Username";
            if (txtEmail.Text == "")
                txtEmail.Text = "Password";

            txtEmail.BackgroundImage = Properties.Resources.mail4;
            panelEmail.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            pbUsername.BackgroundImage = Properties.Resources.user3;
            panelUsername.BackColor = Color.WhiteSmoke;
            txtName.ForeColor = Color.WhiteSmoke;

            pbPassword.BackgroundImage = Properties.Resources.password;
            panelPassword.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.WhiteSmoke;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            this.thread = new Thread(() => openNewForm(new frmLoginUI()));
            this.thread.SetApartmentState(ApartmentState.STA);
            this.thread.Start();

        }
        public void openNewForm(Form frm)
        {
            Application.Run(frm);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            if (formController())
            {
                User user = new User();
                user.Name = txtName.Text;
                user.Surname = txtSurname.Text;
                user.Email = txtEmail.Text;
                user.PhoneNumber = txtPhoneNumber.Text;
                user.UserName = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.Age = Convert.ToInt32(txtAge.Text);
                user.Gender = "ERKEK";
                user.Birthday = DateTime.Now;

                new UserRepository().AddUser(user);

                user = new User();

                txtName.Text = "";
                txtSurname.Text = "";
                txtEmail.Text = "";
                txtPhoneNumber.Text = "";
                txtSurname.Text = "";
                txtPassword.Text = "";
                txtAge.Text = "";

                MessageBox.Show("Kaydolma başarılı.");
                btnRegister_Click_1("",new EventArgs());
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz.");
            }
        }

        private bool formController()
        {
            if (txtName.Text != "" && txtSurname.Text != "" && txtEmail.Text != "" && txtPhoneNumber.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtAge.Text != "")
            {
                return true;
            }
            return false;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.thread = new Thread(() => openNewForm(new frmLoginUI()));
            this.thread.SetApartmentState(ApartmentState.STA);
            this.thread.Start();
        }
    }
}