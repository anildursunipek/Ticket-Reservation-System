namespace Ticket_Reservation_System
{
    partial class frmSignUpUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLogo = new PictureBox();
            pbUsername = new PictureBox();
            txtUsername = new TextBox();
            panelUsername = new Panel();
            panelPassword = new Panel();
            pbPassword = new PictureBox();
            panelEmail = new Panel();
            pbEmail = new PictureBox();
            btnSignIn = new Button();
            btnRegister = new Button();
            panelTop = new Panel();
            lblClose = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.easy_ticket_logo;
            pbLogo.Location = new Point(88, 37);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(170, 146);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pbUsername
            // 
            pbUsername.BackgroundImage = Properties.Resources.user3;
            pbUsername.BackgroundImageLayout = ImageLayout.None;
            pbUsername.Location = new Point(38, 177);
            pbUsername.Name = "pbUsername";
            pbUsername.Size = new Size(32, 32);
            pbUsername.TabIndex = 2;
            pbUsername.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(34, 36, 49);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.White;
            txtUsername.HideSelection = false;
            txtUsername.Location = new Point(78, 189);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(230, 20);
            txtUsername.TabIndex = 3;
            txtUsername.TabStop = false;
            txtUsername.Text = "Username";
            txtUsername.Click += txtUsername_Click;
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.White;
            panelUsername.Location = new Point(38, 211);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(270, 1);
            panelUsername.TabIndex = 4;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.White;
            panelPassword.Location = new Point(38, 268);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(270, 1);
            panelPassword.TabIndex = 7;
            // 
            // pbPassword
            // 
            pbPassword.BackgroundImage = Properties.Resources.password;
            pbPassword.BackgroundImageLayout = ImageLayout.Zoom;
            pbPassword.Location = new Point(35, 235);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(32, 32);
            pbPassword.TabIndex = 5;
            pbPassword.TabStop = false;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.White;
            panelEmail.Location = new Point(38, 325);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(270, 1);
            panelEmail.TabIndex = 10;
            // 
            // pbEmail
            // 
            pbEmail.BackgroundImage = Properties.Resources.mail3;
            pbEmail.BackgroundImageLayout = ImageLayout.None;
            pbEmail.Location = new Point(38, 291);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(32, 32);
            pbEmail.TabIndex = 8;
            pbEmail.TabStop = false;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(78, 184, 206);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.ForeColor = Color.FromArgb(34, 36, 49);
            btnSignIn.Location = new Point(38, 350);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(270, 40);
            btnSignIn.TabIndex = 11;
            btnSignIn.Text = "Sıgn Up";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(34, 36, 49);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(38, 402);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(270, 40);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "I already have an account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(78, 184, 206);
            panelTop.Controls.Add(lblClose);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(350, 30);
            panelTop.TabIndex = 13;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblClose.ForeColor = Color.FromArgb(34, 36, 49);
            lblClose.Location = new Point(325, 4);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(24, 24);
            lblClose.TabIndex = 14;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(34, 36, 49);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.HideSelection = false;
            txtPassword.Location = new Point(78, 246);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 20);
            txtPassword.TabIndex = 14;
            txtPassword.TabStop = false;
            txtPassword.Text = "Password";
            txtPassword.Click += txtPassword_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(34, 36, 49);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.White;
            txtEmail.HideSelection = false;
            txtEmail.Location = new Point(78, 303);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 20);
            txtEmail.TabIndex = 15;
            txtEmail.TabStop = false;
            txtEmail.Text = "Email";
            txtEmail.Click += txtEmail_Click;
            // 
            // frmSignUpUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(350, 460);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(panelTop);
            Controls.Add(btnRegister);
            Controls.Add(btnSignIn);
            Controls.Add(panelEmail);
            Controls.Add(pbEmail);
            Controls.Add(panelPassword);
            Controls.Add(pbPassword);
            Controls.Add(panelUsername);
            Controls.Add(txtUsername);
            Controls.Add(pbUsername);
            Controls.Add(pbLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSignUpUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoginUI";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private PictureBox pbUsername;
        private TextBox txtUsername;
        private Panel panelUsername;
        private Panel panelPassword;
        private PictureBox pbPassword;
        private Panel panelEmail;
        private PictureBox pbEmail;
        private Button btnSignIn;
        private Button btnRegister;
        private Panel panelTop;
        private Label lblClose;
        private TextBox txtPassword;
        private TextBox txtEmail;
    }
}