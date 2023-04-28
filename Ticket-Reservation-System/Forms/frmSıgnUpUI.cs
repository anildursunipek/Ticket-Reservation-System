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
            if (txtUsername.Text == "Username")
                txtUsername.Clear();
            if (txtPassword.Text == "")
                txtPassword.Text = "Password";
            if (txtEmail.Text == "")
                txtEmail.Text = "Email";

            pbUsername.BackgroundImage = Properties.Resources.user4;
            panelUsername.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            pbPassword.BackgroundImage = Properties.Resources.password;
            panelPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

            pbEmail.BackgroundImage = Properties.Resources.mail3;
            panelEmail.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.WhiteSmoke;

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Clear();
            if (txtUsername.Text == "")
                txtUsername.Text = "Username";
            if (txtEmail.Text == "")
                txtEmail.Text = "Email";

            pbPassword.BackgroundImage = Properties.Resources.password2;
            panelPassword.BackColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            pbUsername.BackgroundImage = Properties.Resources.user3;
            panelUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            pbEmail.BackgroundImage = Properties.Resources.mail3;
            panelEmail.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.WhiteSmoke;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
                txtEmail.Clear();
            if (txtUsername.Text == "")
                txtUsername.Text = "Username";
            if (txtPassword.Text == "")
                txtPassword.Text = "Password";

            pbEmail.BackgroundImage = Properties.Resources.mail4;
            panelEmail.BackColor = Color.FromArgb(78, 184, 206);
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);

            pbUsername.BackgroundImage = Properties.Resources.user3;
            panelUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            pbPassword.BackgroundImage = Properties.Resources.password;
            panelPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
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
    }
}