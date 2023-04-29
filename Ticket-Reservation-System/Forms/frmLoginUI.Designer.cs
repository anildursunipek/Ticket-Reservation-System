namespace Ticket_Reservation_System
{
    partial class frmLoginUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblClose = new Label();
            pbLogo = new PictureBox();
            panelPassword = new Panel();
            pbPassword = new PictureBox();
            panelUsername = new Panel();
            txtUsername = new TextBox();
            pbUsername = new PictureBox();
            btnSignIn = new Button();
            btnRegister = new Button();
            txtPassword = new TextBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(78, 184, 206);
            panelTop.Controls.Add(lblClose);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(350, 30);
            panelTop.TabIndex = 14;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.easy_ticket_logo;
            pbLogo.Location = new Point(93, 59);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(160, 124);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 15;
            pbLogo.TabStop = false;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.White;
            panelPassword.Location = new Point(38, 268);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(270, 1);
            panelPassword.TabIndex = 21;
            // 
            // pbPassword
            // 
            pbPassword.BackgroundImage = Properties.Resources.password;
            pbPassword.BackgroundImageLayout = ImageLayout.Zoom;
            pbPassword.Location = new Point(35, 235);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(32, 32);
            pbPassword.TabIndex = 19;
            pbPassword.TabStop = false;
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.White;
            panelUsername.Location = new Point(38, 211);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(270, 1);
            panelUsername.TabIndex = 18;
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
            txtUsername.TabIndex = 17;
            txtUsername.TabStop = false;
            txtUsername.Text = "Username";
            txtUsername.Click += txtUsername_Click;
            // 
            // pbUsername
            // 
            pbUsername.BackgroundImage = Properties.Resources.user3;
            pbUsername.BackgroundImageLayout = ImageLayout.None;
            pbUsername.Location = new Point(38, 177);
            pbUsername.Name = "pbUsername";
            pbUsername.Size = new Size(32, 32);
            pbUsername.TabIndex = 16;
            pbUsername.TabStop = false;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(78, 184, 206);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.ForeColor = Color.FromArgb(34, 36, 49);
            btnSignIn.Location = new Point(35, 301);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(270, 40);
            btnSignIn.TabIndex = 22;
            btnSignIn.Text = "Login";
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
            btnRegister.Location = new Point(35, 353);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(270, 40);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
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
            txtPassword.TabIndex = 24;
            txtPassword.TabStop = false;
            txtPassword.Text = "Password";
            txtPassword.Click += txtPassword_Click;
            // 
            // frmLoginUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(350, 429);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnSignIn);
            Controls.Add(panelPassword);
            Controls.Add(pbPassword);
            Controls.Add(panelUsername);
            Controls.Add(txtUsername);
            Controls.Add(pbUsername);
            Controls.Add(pbLogo);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoginUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private PictureBox pbLogo;
        private Panel panelPassword;
        private PictureBox pbPassword;
        private Panel panelUsername;
        private TextBox txtUsername;
        private PictureBox pbUsername;
        private Button btnSignIn;
        private Button btnRegister;
        private Label lblClose;
        private TextBox txtPassword;
    }
}