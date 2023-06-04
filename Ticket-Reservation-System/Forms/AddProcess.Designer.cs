namespace Ticket_Reservation_System.Forms
{
    partial class AddProcess
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
            this.comboBoxFirm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVehicle = new System.Windows.Forms.ComboBox();
            this.Araç = new System.Windows.Forms.Label();
            this.comboBoxTrip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.labelWorker = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.labelFirm = new System.Windows.Forms.Label();
            this.labelVehicle = new System.Windows.Forms.Label();
            this.labelTrip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxFirm
            // 
            this.comboBoxFirm.FormattingEnabled = true;
            this.comboBoxFirm.Location = new System.Drawing.Point(28, 44);
            this.comboBoxFirm.Name = "comboBoxFirm";
            this.comboBoxFirm.Size = new System.Drawing.Size(194, 23);
            this.comboBoxFirm.TabIndex = 0;
            this.comboBoxFirm.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firma";
            // 
            // comboBoxVehicle
            // 
            this.comboBoxVehicle.FormattingEnabled = true;
            this.comboBoxVehicle.Location = new System.Drawing.Point(28, 105);
            this.comboBoxVehicle.Name = "comboBoxVehicle";
            this.comboBoxVehicle.Size = new System.Drawing.Size(194, 23);
            this.comboBoxVehicle.TabIndex = 0;
            this.comboBoxVehicle.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehicle_SelectedIndexChanged);
            // 
            // Araç
            // 
            this.Araç.AutoSize = true;
            this.Araç.Location = new System.Drawing.Point(28, 87);
            this.Araç.Name = "Araç";
            this.Araç.Size = new System.Drawing.Size(31, 15);
            this.Araç.TabIndex = 1;
            this.Araç.Text = "Araç";
            // 
            // comboBoxTrip
            // 
            this.comboBoxTrip.FormattingEnabled = true;
            this.comboBoxTrip.Location = new System.Drawing.Point(28, 171);
            this.comboBoxTrip.Name = "comboBoxTrip";
            this.comboBoxTrip.Size = new System.Drawing.Size(194, 23);
            this.comboBoxTrip.TabIndex = 0;
            this.comboBoxTrip.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrip_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rota";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "";
            this.dateTimePickerDate.Location = new System.Drawing.Point(28, 299);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(194, 23);
            this.dateTimePickerDate.TabIndex = 2;
            this.dateTimePickerDate.Value = new System.DateTime(2023, 6, 4, 15, 22, 39, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Saat";
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(28, 238);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(194, 23);
            this.comboBoxWorker.TabIndex = 0;
            this.comboBoxWorker.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorker_SelectedIndexChanged);
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(259, 98);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(38, 15);
            this.labelWorker.TabIndex = 1;
            this.labelWorker.Text = "Şoför:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(28, 402);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(194, 34);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(259, 152);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(483, 284);
            this.panel.TabIndex = 4;
            // 
            // labelFirm
            // 
            this.labelFirm.AutoSize = true;
            this.labelFirm.Location = new System.Drawing.Point(259, 49);
            this.labelFirm.Name = "labelFirm";
            this.labelFirm.Size = new System.Drawing.Size(40, 15);
            this.labelFirm.TabIndex = 1;
            this.labelFirm.Text = "Firma:";
            // 
            // labelVehicle
            // 
            this.labelVehicle.AutoSize = true;
            this.labelVehicle.Location = new System.Drawing.Point(259, 73);
            this.labelVehicle.Name = "labelVehicle";
            this.labelVehicle.Size = new System.Drawing.Size(34, 15);
            this.labelVehicle.TabIndex = 1;
            this.labelVehicle.Text = "Araç:";
            // 
            // labelTrip
            // 
            this.labelTrip.AutoSize = true;
            this.labelTrip.Location = new System.Drawing.Point(259, 120);
            this.labelTrip.Name = "labelTrip";
            this.labelTrip.Size = new System.Drawing.Size(34, 15);
            this.labelTrip.TabIndex = 1;
            this.labelTrip.Text = "Rota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şoför";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(63, 353);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(159, 23);
            this.textBoxTime.TabIndex = 5;
            this.textBoxTime.Text = "13:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yolculuk Tarih";
            // 
            // AddProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 491);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWorker);
            this.Controls.Add(this.labelTrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelVehicle);
            this.Controls.Add(this.Araç);
            this.Controls.Add(this.labelFirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWorker);
            this.Controls.Add(this.comboBoxTrip);
            this.Controls.Add(this.comboBoxVehicle);
            this.Controls.Add(this.comboBoxFirm);
            this.Name = "AddProcess";
            this.Text = "AddProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxFirm;
        private Label label1;
        private ComboBox comboBoxVehicle;
        private Label Araç;
        private ComboBox comboBoxTrip;
        private Label label3;
        private DateTimePicker dateTimePickerDate;
        private Label label4;
        private ComboBox comboBoxWorker;
        private Label labelWorker;
        private Button buttonSave;
        private Panel panel;
        private Label labelFirm;
        private Label labelVehicle;
        private Label labelTrip;
        private Label label2;
        private TextBox textBoxTime;
        private Label label5;
    }
}