namespace Ticket_Reservation_System
{
    partial class frmMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            panelSideMenu = new Panel();
            btnMapButton = new FontAwesome.Sharp.IconButton();
            btnAdministration = new FontAwesome.Sharp.IconButton();
            ıconButton9 = new FontAwesome.Sharp.IconButton();
            btnFerry = new FontAwesome.Sharp.IconButton();
            btnPlane = new FontAwesome.Sharp.IconButton();
            btnBus = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnSideMenu = new FontAwesome.Sharp.IconButton();
            pictureLogo = new PictureBox();
            panel1 = new Panel();
            ıconButton2 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            labelNameSurname = new Label();
            circularPictureBox1 = new CustomControls.CircularPictureBox();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            panelChildForm = new Panel();
            rjDropdownMenu1 = new CustomControls.RJDropdownMenu(components);
            vehiclePageToolStripMenuItem = new ToolStripMenuItem();
            brandPageToolStripMenuItem = new ToolStripMenuItem();
            modelPageToolStripMenuItem = new ToolStripMenuItem();
            firmPageToolStripMenuItem = new ToolStripMenuItem();
            tripPageToolStripMenuItem = new ToolStripMenuItem();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            rjDropdownMenu1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(98, 102, 244);
            panelSideMenu.Controls.Add(btnMapButton);
            panelSideMenu.Controls.Add(btnAdministration);
            panelSideMenu.Controls.Add(ıconButton9);
            panelSideMenu.Controls.Add(btnFerry);
            panelSideMenu.Controls.Add(btnPlane);
            panelSideMenu.Controls.Add(btnBus);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(230, 600);
            panelSideMenu.TabIndex = 1;
            // 
            // btnMapButton
            // 
            btnMapButton.Dock = DockStyle.Top;
            btnMapButton.FlatAppearance.BorderSize = 0;
            btnMapButton.FlatStyle = FlatStyle.Flat;
            btnMapButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMapButton.ForeColor = Color.White;
            btnMapButton.IconChar = FontAwesome.Sharp.IconChar.Map;
            btnMapButton.IconColor = Color.White;
            btnMapButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMapButton.IconSize = 30;
            btnMapButton.ImageAlign = ContentAlignment.MiddleLeft;
            btnMapButton.Location = new Point(0, 250);
            btnMapButton.Name = "btnMapButton";
            btnMapButton.Padding = new Padding(10, 0, 0, 0);
            btnMapButton.Size = new Size(230, 45);
            btnMapButton.TabIndex = 12;
            btnMapButton.Tag = "Support";
            btnMapButton.Text = "  Map";
            btnMapButton.TextAlign = ContentAlignment.MiddleLeft;
            btnMapButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMapButton.UseVisualStyleBackColor = true;
            btnMapButton.Click += btnMapButton_Click;
            // 
            // btnAdministration
            // 
            btnAdministration.Dock = DockStyle.Top;
            btnAdministration.FlatAppearance.BorderSize = 0;
            btnAdministration.FlatStyle = FlatStyle.Flat;
            btnAdministration.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdministration.ForeColor = Color.White;
            btnAdministration.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            btnAdministration.IconColor = Color.White;
            btnAdministration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdministration.IconSize = 30;
            btnAdministration.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdministration.Location = new Point(0, 205);
            btnAdministration.Name = "btnAdministration";
            btnAdministration.Padding = new Padding(10, 0, 0, 0);
            btnAdministration.Size = new Size(230, 45);
            btnAdministration.TabIndex = 10;
            btnAdministration.Tag = "Administration";
            btnAdministration.Text = "  Administration";
            btnAdministration.TextAlign = ContentAlignment.MiddleLeft;
            btnAdministration.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdministration.UseVisualStyleBackColor = true;
            btnAdministration.Click += btnAdministration_Click;
            // 
            // ıconButton9
            // 
            ıconButton9.Dock = DockStyle.Bottom;
            ıconButton9.FlatAppearance.BorderSize = 0;
            ıconButton9.FlatStyle = FlatStyle.Flat;
            ıconButton9.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ıconButton9.ForeColor = Color.White;
            ıconButton9.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            ıconButton9.IconColor = Color.White;
            ıconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton9.IconSize = 30;
            ıconButton9.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton9.Location = new Point(0, 555);
            ıconButton9.Name = "ıconButton9";
            ıconButton9.Padding = new Padding(10, 0, 0, 0);
            ıconButton9.Size = new Size(230, 45);
            ıconButton9.TabIndex = 8;
            ıconButton9.Tag = "Exit";
            ıconButton9.Text = "  Exit";
            ıconButton9.TextAlign = ContentAlignment.MiddleLeft;
            ıconButton9.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton9.UseVisualStyleBackColor = true;
            ıconButton9.Click += ıconButton9_Click;
            // 
            // btnFerry
            // 
            btnFerry.Dock = DockStyle.Top;
            btnFerry.FlatAppearance.BorderSize = 0;
            btnFerry.FlatStyle = FlatStyle.Flat;
            btnFerry.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFerry.ForeColor = Color.White;
            btnFerry.IconChar = FontAwesome.Sharp.IconChar.Ship;
            btnFerry.IconColor = Color.White;
            btnFerry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFerry.IconSize = 30;
            btnFerry.ImageAlign = ContentAlignment.MiddleLeft;
            btnFerry.Location = new Point(0, 160);
            btnFerry.Name = "btnFerry";
            btnFerry.Padding = new Padding(10, 0, 0, 0);
            btnFerry.Size = new Size(230, 45);
            btnFerry.TabIndex = 3;
            btnFerry.Tag = "Ferry";
            btnFerry.Text = "  Ferry";
            btnFerry.TextAlign = ContentAlignment.MiddleLeft;
            btnFerry.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFerry.UseVisualStyleBackColor = true;
            btnFerry.Click += btnFerry_Click;
            // 
            // btnPlane
            // 
            btnPlane.Dock = DockStyle.Top;
            btnPlane.FlatAppearance.BorderSize = 0;
            btnPlane.FlatStyle = FlatStyle.Flat;
            btnPlane.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlane.ForeColor = Color.White;
            btnPlane.IconChar = FontAwesome.Sharp.IconChar.PlaneUp;
            btnPlane.IconColor = Color.White;
            btnPlane.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPlane.IconSize = 30;
            btnPlane.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlane.Location = new Point(0, 115);
            btnPlane.Name = "btnPlane";
            btnPlane.Padding = new Padding(10, 0, 0, 0);
            btnPlane.Size = new Size(230, 45);
            btnPlane.TabIndex = 2;
            btnPlane.Tag = "Plane";
            btnPlane.Text = "  Plane";
            btnPlane.TextAlign = ContentAlignment.MiddleLeft;
            btnPlane.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPlane.UseVisualStyleBackColor = true;
            btnPlane.Click += btnPlane_Click;
            // 
            // btnBus
            // 
            btnBus.Dock = DockStyle.Top;
            btnBus.FlatAppearance.BorderSize = 0;
            btnBus.FlatStyle = FlatStyle.Flat;
            btnBus.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBus.ForeColor = Color.White;
            btnBus.IconChar = FontAwesome.Sharp.IconChar.BusAlt;
            btnBus.IconColor = Color.White;
            btnBus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBus.IconSize = 30;
            btnBus.ImageAlign = ContentAlignment.MiddleLeft;
            btnBus.Location = new Point(0, 70);
            btnBus.Name = "btnBus";
            btnBus.Padding = new Padding(10, 0, 0, 0);
            btnBus.Size = new Size(230, 45);
            btnBus.TabIndex = 1;
            btnBus.Tag = "Bus";
            btnBus.Text = "  Bus";
            btnBus.TextAlign = ContentAlignment.MiddleLeft;
            btnBus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBus.UseVisualStyleBackColor = true;
            btnBus.Click += btnBus_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(98, 102, 244);
            panelLogo.Controls.Add(btnSideMenu);
            panelLogo.Controls.Add(pictureLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(230, 70);
            panelLogo.TabIndex = 0;
            // 
            // btnSideMenu
            // 
            btnSideMenu.CausesValidation = false;
            btnSideMenu.Cursor = Cursors.Hand;
            btnSideMenu.FlatAppearance.BorderSize = 0;
            btnSideMenu.FlatStyle = FlatStyle.Flat;
            btnSideMenu.ForeColor = Color.Transparent;
            btnSideMenu.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            btnSideMenu.IconColor = Color.White;
            btnSideMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideMenu.IconSize = 35;
            btnSideMenu.Location = new Point(187, 0);
            btnSideMenu.Name = "btnSideMenu";
            btnSideMenu.Size = new Size(43, 70);
            btnSideMenu.TabIndex = 1;
            btnSideMenu.UseVisualStyleBackColor = true;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = Properties.Resources.easy_ticket_logo;
            pictureLogo.Location = new Point(14, 9);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(150, 50);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(ıconButton2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ıconButton1);
            panel1.Controls.Add(labelNameSurname);
            panel1.Controls.Add(circularPictureBox1);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(230, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 70);
            panel1.TabIndex = 26;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // ıconButton2
            // 
            ıconButton2.BackColor = Color.Transparent;
            ıconButton2.FlatAppearance.BorderSize = 0;
            ıconButton2.FlatStyle = FlatStyle.Flat;
            ıconButton2.ForeColor = Color.Transparent;
            ıconButton2.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            ıconButton2.IconColor = Color.Black;
            ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton2.IconSize = 35;
            ıconButton2.Location = new Point(4, 16);
            ıconButton2.Name = "ıconButton2";
            ıconButton2.Size = new Size(47, 34);
            ıconButton2.TabIndex = 9;
            ıconButton2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(46, 19);
            label2.Name = "label2";
            label2.Size = new Size(158, 29);
            label2.TabIndex = 8;
            label2.Text = "Dashboard";
            // 
            // ıconButton1
            // 
            ıconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ıconButton1.BackColor = Color.Transparent;
            ıconButton1.FlatAppearance.BorderSize = 0;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.ForeColor = Color.Transparent;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowDownShortWide;
            ıconButton1.IconColor = Color.FromArgb(98, 102, 244);
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 35;
            ıconButton1.Location = new Point(558, 30);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(47, 34);
            ıconButton1.TabIndex = 7;
            ıconButton1.UseVisualStyleBackColor = false;
            // 
            // labelNameSurname
            // 
            labelNameSurname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNameSurname.AutoSize = true;
            labelNameSurname.BackColor = Color.Transparent;
            labelNameSurname.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameSurname.ForeColor = Color.Black;
            labelNameSurname.Location = new Point(436, 9);
            labelNameSurname.Name = "labelNameSurname";
            labelNameSurname.Size = new Size(132, 18);
            labelNameSurname.TabIndex = 4;
            labelNameSurname.Text = "Name Surname";
            labelNameSurname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            circularPictureBox1.BorderColor = Color.FromArgb(98, 102, 244);
            circularPictureBox1.BorderColor2 = Color.FromArgb(98, 102, 244);
            circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            circularPictureBox1.BorderSize = 2;
            circularPictureBox1.GradientAngle = 50F;
            circularPictureBox1.Image = (Image)resources.GetObject("circularPictureBox1.Image");
            circularPictureBox1.Location = new Point(607, 0);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(66, 66);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            circularPictureBox1.TabIndex = 3;
            circularPictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(10, 184, 210);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.White;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 25;
            btnMinimize.Location = new Point(713, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 20);
            btnMinimize.TabIndex = 2;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(255, 94, 132);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 20;
            btnClose.Location = new Point(740, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 20);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.LightGray;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(230, 70);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(770, 530);
            panelChildForm.TabIndex = 27;
            // 
            // rjDropdownMenu1
            // 
            rjDropdownMenu1.BackColor = Color.FromArgb(98, 102, 244);
            rjDropdownMenu1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rjDropdownMenu1.IsMainMenu = false;
            rjDropdownMenu1.Items.AddRange(new ToolStripItem[] { vehiclePageToolStripMenuItem, brandPageToolStripMenuItem, modelPageToolStripMenuItem, firmPageToolStripMenuItem, tripPageToolStripMenuItem });
            rjDropdownMenu1.MenuItemHeight = 25;
            rjDropdownMenu1.MenuItemTextColor = Color.DimGray;
            rjDropdownMenu1.Name = "rjDropdownMenu1";
            rjDropdownMenu1.PrimaryColor = Color.MediumSlateBlue;
            rjDropdownMenu1.Size = new Size(158, 114);
            // 
            // vehiclePageToolStripMenuItem
            // 
            vehiclePageToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            vehiclePageToolStripMenuItem.Name = "vehiclePageToolStripMenuItem";
            vehiclePageToolStripMenuItem.Size = new Size(157, 22);
            vehiclePageToolStripMenuItem.Text = "Vehicle Page";
            vehiclePageToolStripMenuItem.Click += vehiclePageToolStripMenuItem_Click;
            // 
            // brandPageToolStripMenuItem
            // 
            brandPageToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            brandPageToolStripMenuItem.Name = "brandPageToolStripMenuItem";
            brandPageToolStripMenuItem.Size = new Size(157, 22);
            brandPageToolStripMenuItem.Text = "Brand Page";
            brandPageToolStripMenuItem.Click += brandPageToolStripMenuItem_Click;
            // 
            // modelPageToolStripMenuItem
            // 
            modelPageToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            modelPageToolStripMenuItem.Name = "modelPageToolStripMenuItem";
            modelPageToolStripMenuItem.Size = new Size(157, 22);
            modelPageToolStripMenuItem.Text = "Model Page";
            modelPageToolStripMenuItem.Click += modelPageToolStripMenuItem_Click_1;
            // 
            // firmPageToolStripMenuItem
            // 
            firmPageToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            firmPageToolStripMenuItem.Name = "firmPageToolStripMenuItem";
            firmPageToolStripMenuItem.Size = new Size(157, 22);
            firmPageToolStripMenuItem.Text = "Firm Page";
            firmPageToolStripMenuItem.Click += firmPageToolStripMenuItem_Click;
            // 
            // tripPageToolStripMenuItem
            // 
            tripPageToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            tripPageToolStripMenuItem.Name = "tripPageToolStripMenuItem";
            tripPageToolStripMenuItem.Size = new Size(157, 22);
            tripPageToolStripMenuItem.Text = "Trip Page";
            tripPageToolStripMenuItem.Click += tripPageToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 600);
            Controls.Add(panelChildForm);
            Controls.Add(panel1);
            Controls.Add(panelSideMenu);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1000, 600);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenu";
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            rjDropdownMenu1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSideMenu;
        private Panel panelLogo;
        private Panel panel1;
        private Panel panelChildForm;
        private PictureBox pictureLogo;
        private FontAwesome.Sharp.IconButton btnSideMenu;
        private FontAwesome.Sharp.IconButton btnAdministration;
        private FontAwesome.Sharp.IconButton ıconButton9;
        private FontAwesome.Sharp.IconButton btnFerry;
        private FontAwesome.Sharp.IconButton btnPlane;
        private FontAwesome.Sharp.IconButton btnBus;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private CustomControls.CircularPictureBox circularPictureBox1;
        private Label labelNameSurname;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnMapButton;
        private CustomControls.RJDropdownMenu rjDropdownMenu1;
        private ToolStripMenuItem vehiclePageToolStripMenuItem;
        private ToolStripMenuItem brandPageToolStripMenuItem;
        private ToolStripMenuItem modelPageToolStripMenuItem;
        private ToolStripMenuItem firmPageToolStripMenuItem;
        private ToolStripMenuItem tripPageToolStripMenuItem;
    }
}