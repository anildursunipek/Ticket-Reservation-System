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
            panelLeft = new Panel();
            panelLogo = new Panel();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            lblClose = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panelChildForm = new Panel();
            ıconButton2 = new FontAwesome.Sharp.IconButton();
            ıconButton3 = new FontAwesome.Sharp.IconButton();
            ıconButton4 = new FontAwesome.Sharp.IconButton();
            ıconButton5 = new FontAwesome.Sharp.IconButton();
            ıconButton9 = new FontAwesome.Sharp.IconButton();
            ıconButton7 = new FontAwesome.Sharp.IconButton();
            ıconButton8 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            panelLeft.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.AutoScroll = true;
            panelLeft.BackColor = Color.FromArgb(98, 102, 244);
            panelLeft.Controls.Add(ıconButton8);
            panelLeft.Controls.Add(ıconButton7);
            panelLeft.Controls.Add(ıconButton9);
            panelLeft.Controls.Add(ıconButton5);
            panelLeft.Controls.Add(ıconButton4);
            panelLeft.Controls.Add(ıconButton3);
            panelLeft.Controls.Add(ıconButton2);
            panelLeft.Controls.Add(panelLogo);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(230, 600);
            panelLeft.TabIndex = 1;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(98, 102, 244);
            panelLogo.Controls.Add(ıconButton1);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(230, 80);
            panelLogo.TabIndex = 0;
            // 
            // ıconButton1
            // 
            ıconButton1.CausesValidation = false;
            ıconButton1.Cursor = Cursors.Hand;
            ıconButton1.FlatAppearance.BorderSize = 0;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.ForeColor = Color.Transparent;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            ıconButton1.IconColor = Color.White;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 35;
            ıconButton1.Location = new Point(167, 25);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(43, 23);
            ıconButton1.TabIndex = 1;
            ıconButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.easy_ticket_logo;
            pictureBox1.Location = new Point(-1, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.BackColor = Color.Transparent;
            lblClose.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblClose.ForeColor = Color.WhiteSmoke;
            lblClose.Location = new Point(839, 2);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(27, 30);
            lblClose.TabIndex = 25;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 134, 138);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(230, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 80);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(803, 2);
            label1.Name = "label1";
            label1.Size = new Size(37, 30);
            label1.TabIndex = 26;
            label1.Text = "---";
            // 
            // panelChildForm
            // 
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(230, 80);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(770, 520);
            panelChildForm.TabIndex = 27;
            // 
            // ıconButton2
            // 
            ıconButton2.Dock = DockStyle.Top;
            ıconButton2.FlatAppearance.BorderSize = 0;
            ıconButton2.FlatStyle = FlatStyle.Flat;
            ıconButton2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ıconButton2.ForeColor = Color.White;
            ıconButton2.IconChar = FontAwesome.Sharp.IconChar.BusAlt;
            ıconButton2.IconColor = Color.White;
            ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton2.IconSize = 30;
            ıconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton2.Location = new Point(0, 80);
            ıconButton2.Name = "ıconButton2";
            ıconButton2.Padding = new Padding(10, 0, 0, 0);
            ıconButton2.Size = new Size(230, 45);
            ıconButton2.TabIndex = 1;
            ıconButton2.Text = "  Bus";
            ıconButton2.TextAlign = ContentAlignment.MiddleLeft;
            ıconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton2.UseVisualStyleBackColor = true;
            // 
            // ıconButton3
            // 
            ıconButton3.Dock = DockStyle.Top;
            ıconButton3.FlatAppearance.BorderSize = 0;
            ıconButton3.FlatStyle = FlatStyle.Flat;
            ıconButton3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ıconButton3.ForeColor = Color.White;
            ıconButton3.IconChar = FontAwesome.Sharp.IconChar.PlaneUp;
            ıconButton3.IconColor = Color.White;
            ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton3.IconSize = 30;
            ıconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton3.Location = new Point(0, 125);
            ıconButton3.Name = "ıconButton3";
            ıconButton3.Padding = new Padding(10, 0, 0, 0);
            ıconButton3.Size = new Size(230, 45);
            ıconButton3.TabIndex = 2;
            ıconButton3.Text = "  Plane";
            ıconButton3.TextAlign = ContentAlignment.MiddleLeft;
            ıconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton3.UseVisualStyleBackColor = true;
            // 
            // ıconButton4
            // 
            ıconButton4.Dock = DockStyle.Top;
            ıconButton4.FlatAppearance.BorderSize = 0;
            ıconButton4.FlatStyle = FlatStyle.Flat;
            ıconButton4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ıconButton4.ForeColor = Color.White;
            ıconButton4.IconChar = FontAwesome.Sharp.IconChar.Ship;
            ıconButton4.IconColor = Color.White;
            ıconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton4.IconSize = 30;
            ıconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton4.Location = new Point(0, 170);
            ıconButton4.Name = "ıconButton4";
            ıconButton4.Padding = new Padding(10, 0, 0, 0);
            ıconButton4.Size = new Size(230, 45);
            ıconButton4.TabIndex = 3;
            ıconButton4.Text = "  Ferry";
            ıconButton4.TextAlign = ContentAlignment.MiddleLeft;
            ıconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton4.UseVisualStyleBackColor = true;
            // 
            // ıconButton5
            // 
            ıconButton5.Dock = DockStyle.Top;
            ıconButton5.FlatAppearance.BorderSize = 0;
            ıconButton5.FlatStyle = FlatStyle.Flat;
            ıconButton5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ıconButton5.ForeColor = Color.White;
            ıconButton5.IconChar = FontAwesome.Sharp.IconChar.S;
            ıconButton5.IconColor = Color.White;
            ıconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton5.IconSize = 30;
            ıconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton5.Location = new Point(0, 215);
            ıconButton5.Name = "ıconButton5";
            ıconButton5.Padding = new Padding(10, 0, 0, 0);
            ıconButton5.Size = new Size(230, 45);
            ıconButton5.TabIndex = 4;
            ıconButton5.Text = "  Help";
            ıconButton5.TextAlign = ContentAlignment.MiddleLeft;
            ıconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton5.UseVisualStyleBackColor = true;
            // 
            // ıconButton9
            // 
            ıconButton9.Dock = DockStyle.Bottom;
            ıconButton9.FlatAppearance.BorderSize = 0;
            ıconButton9.FlatStyle = FlatStyle.Flat;
            ıconButton9.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            ıconButton9.Text = "  Exit";
            ıconButton9.TextAlign = ContentAlignment.MiddleLeft;
            ıconButton9.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton9.UseVisualStyleBackColor = true;
            // 
            // ıconButton7
            // 
            ıconButton7.Dock = DockStyle.Top;
            ıconButton7.FlatAppearance.BorderSize = 0;
            ıconButton7.FlatStyle = FlatStyle.Flat;
            ıconButton7.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ıconButton7.ForeColor = Color.White;
            ıconButton7.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            ıconButton7.IconColor = Color.White;
            ıconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton7.IconSize = 30;
            ıconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton7.Location = new Point(0, 260);
            ıconButton7.Name = "ıconButton7";
            ıconButton7.Padding = new Padding(10, 0, 0, 0);
            ıconButton7.Size = new Size(230, 45);
            ıconButton7.TabIndex = 10;
            ıconButton7.Text = "  Administration";
            ıconButton7.TextAlign = ContentAlignment.MiddleLeft;
            ıconButton7.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton7.UseVisualStyleBackColor = true;
            // 
            // ıconButton8
            // 
            ıconButton8.Dock = DockStyle.Top;
            ıconButton8.FlatAppearance.BorderSize = 0;
            ıconButton8.FlatStyle = FlatStyle.Flat;
            ıconButton8.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ıconButton8.ForeColor = Color.White;
            ıconButton8.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            ıconButton8.IconColor = Color.White;
            ıconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton8.IconSize = 30;
            ıconButton8.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton8.Location = new Point(0, 305);
            ıconButton8.Name = "ıconButton8";
            ıconButton8.Padding = new Padding(10, 0, 0, 0);
            ıconButton8.Size = new Size(230, 45);
            ıconButton8.TabIndex = 11;
            ıconButton8.Text = "  Firm Settings";
            ıconButton8.TextAlign = ContentAlignment.MiddleLeft;
            ıconButton8.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 134, 138);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(351, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 39);
            textBox1.TabIndex = 27;
            textBox1.Text = "Page Name";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 600);
            Controls.Add(panelChildForm);
            Controls.Add(panel1);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1000, 500);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenu";
            panelLeft.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelLeft;
        private Panel panelLogo;
        private Label lblClose;
        private Panel panel1;
        private Label label1;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton ıconButton8;
        private FontAwesome.Sharp.IconButton ıconButton7;
        private FontAwesome.Sharp.IconButton ıconButton9;
        private FontAwesome.Sharp.IconButton ıconButton5;
        private FontAwesome.Sharp.IconButton ıconButton4;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private TextBox textBox1;
    }
}