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
            // AddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}