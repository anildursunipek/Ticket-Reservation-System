namespace Ticket_Reservation_System.Forms
{
    partial class AddTrip
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
            this.map_form = new GMap.NET.WindowsForms.GMapControl();
            this.cmbxType = new System.Windows.Forms.ComboBox();
            this.listBoxTrip = new System.Windows.Forms.ListBox();
            this.comboBoxTrip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTrip = new System.Windows.Forms.Label();
            this.btnTripAdd = new System.Windows.Forms.Button();
            this.deleteLocation = new System.Windows.Forms.Button();
            this.comboBoxFirm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxVehicle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveTrip = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // map_form
            // 
            this.map_form.Bearing = 0F;
            this.map_form.CanDragMap = true;
            this.map_form.EmptyTileColor = System.Drawing.Color.Navy;
            this.map_form.GrayScaleMode = false;
            this.map_form.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map_form.LevelsKeepInMemory = 5;
            this.map_form.Location = new System.Drawing.Point(12, 12);
            this.map_form.MarkersEnabled = true;
            this.map_form.MaxZoom = 2;
            this.map_form.MinZoom = 2;
            this.map_form.MouseWheelZoomEnabled = true;
            this.map_form.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map_form.Name = "map_form";
            this.map_form.NegativeMode = false;
            this.map_form.PolygonsEnabled = true;
            this.map_form.RetryLoadTile = 0;
            this.map_form.RoutesEnabled = true;
            this.map_form.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map_form.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map_form.ShowTileGridLines = false;
            this.map_form.Size = new System.Drawing.Size(571, 426);
            this.map_form.TabIndex = 0;
            this.map_form.Zoom = 0D;
            this.map_form.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // cmbxType
            // 
            this.cmbxType.FormattingEnabled = true;
            this.cmbxType.Location = new System.Drawing.Point(604, 37);
            this.cmbxType.Name = "cmbxType";
            this.cmbxType.Size = new System.Drawing.Size(184, 23);
            this.cmbxType.TabIndex = 1;
            this.cmbxType.SelectedIndexChanged += new System.EventHandler(this.cmbxType_SelectedIndexChanged);
            // 
            // listBoxTrip
            // 
            this.listBoxTrip.FormattingEnabled = true;
            this.listBoxTrip.ItemHeight = 15;
            this.listBoxTrip.Location = new System.Drawing.Point(608, 250);
            this.listBoxTrip.Name = "listBoxTrip";
            this.listBoxTrip.Size = new System.Drawing.Size(184, 154);
            this.listBoxTrip.TabIndex = 2;
            this.listBoxTrip.SelectedIndexChanged += new System.EventHandler(this.listBoxTrip_SelectedIndexChanged);
            // 
            // comboBoxTrip
            // 
            this.comboBoxTrip.FormattingEnabled = true;
            this.comboBoxTrip.Location = new System.Drawing.Point(604, 95);
            this.comboBoxTrip.Name = "comboBoxTrip";
            this.comboBoxTrip.Size = new System.Drawing.Size(184, 23);
            this.comboBoxTrip.TabIndex = 1;
            this.comboBoxTrip.Visible = false;
            this.comboBoxTrip.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrip_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yolculuk Tipi";
            // 
            // labelTrip
            // 
            this.labelTrip.AutoSize = true;
            this.labelTrip.Location = new System.Drawing.Point(604, 76);
            this.labelTrip.Name = "labelTrip";
            this.labelTrip.Size = new System.Drawing.Size(55, 15);
            this.labelTrip.TabIndex = 3;
            this.labelTrip.Text = "Rota ekle";
            this.labelTrip.Visible = false;
            // 
            // btnTripAdd
            // 
            this.btnTripAdd.Location = new System.Drawing.Point(604, 136);
            this.btnTripAdd.Name = "btnTripAdd";
            this.btnTripAdd.Size = new System.Drawing.Size(184, 28);
            this.btnTripAdd.TabIndex = 4;
            this.btnTripAdd.Text = "Ekle";
            this.btnTripAdd.UseVisualStyleBackColor = true;
            this.btnTripAdd.Visible = false;
            this.btnTripAdd.Click += new System.EventHandler(this.btnTripAdd_Click);
            // 
            // deleteLocation
            // 
            this.deleteLocation.Location = new System.Drawing.Point(608, 410);
            this.deleteLocation.Name = "deleteLocation";
            this.deleteLocation.Size = new System.Drawing.Size(184, 28);
            this.deleteLocation.TabIndex = 4;
            this.deleteLocation.Text = "Sil";
            this.deleteLocation.UseVisualStyleBackColor = true;
            this.deleteLocation.Click += new System.EventHandler(this.deleteLocation_Click);
            // 
            // comboBoxFirm
            // 
            this.comboBoxFirm.FormattingEnabled = true;
            this.comboBoxFirm.Location = new System.Drawing.Point(860, 37);
            this.comboBoxFirm.Name = "comboBoxFirm";
            this.comboBoxFirm.Size = new System.Drawing.Size(179, 23);
            this.comboBoxFirm.TabIndex = 5;
            this.comboBoxFirm.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(858, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Firma";
            // 
            // comboBoxVehicle
            // 
            this.comboBoxVehicle.FormattingEnabled = true;
            this.comboBoxVehicle.Location = new System.Drawing.Point(860, 95);
            this.comboBoxVehicle.Name = "comboBoxVehicle";
            this.comboBoxVehicle.Size = new System.Drawing.Size(179, 23);
            this.comboBoxVehicle.TabIndex = 5;
            this.comboBoxVehicle.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehicle_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(858, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Araç";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(856, 207);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(181, 23);
            this.dateTimePickerStart.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(858, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Başlangıç tarihi";
            // 
            // btnSaveTrip
            // 
            this.btnSaveTrip.Location = new System.Drawing.Point(858, 250);
            this.btnSaveTrip.Name = "btnSaveTrip";
            this.btnSaveTrip.Size = new System.Drawing.Size(179, 32);
            this.btnSaveTrip.TabIndex = 8;
            this.btnSaveTrip.Text = "Kaydet";
            this.btnSaveTrip.UseVisualStyleBackColor = true;
            this.btnSaveTrip.Click += new System.EventHandler(this.btnSaveTrip_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(860, 155);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(177, 23);
            this.textBoxDescription.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(862, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Açıklama";
            // 
            // AddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 448);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.btnSaveTrip);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxVehicle);
            this.Controls.Add(this.comboBoxFirm);
            this.Controls.Add(this.deleteLocation);
            this.Controls.Add(this.btnTripAdd);
            this.Controls.Add(this.labelTrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTrip);
            this.Controls.Add(this.comboBoxTrip);
            this.Controls.Add(this.cmbxType);
            this.Controls.Add(this.map_form);
            this.Name = "AddTrip";
            this.Text = "AddTrip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map_form;
        private ComboBox cmbxType;
        private ListBox listBoxTrip;
        private ComboBox comboBoxTrip;
        private Label label1;
        private Label labelTrip;
        private Button btnTripAdd;
        private Button deleteLocation;
        private ComboBox comboBoxFirm;
        private Label label2;
        private ComboBox comboBoxVehicle;
        private Label label3;
        private DateTimePicker dateTimePickerStart;
        private Label label4;
        private Button btnSaveTrip;
        private TextBox textBoxDescription;
        private Label label5;
    }
}