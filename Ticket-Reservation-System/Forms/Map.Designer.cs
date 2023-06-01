namespace Ticket_Reservation_System.Forms
{
    partial class Map
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
            this.deleteLocation = new System.Windows.Forms.Button();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxType = new System.Windows.Forms.ComboBox();
            this.listBoxLocation = new System.Windows.Forms.ListBox();
            this.save = new System.Windows.Forms.Button();
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
            this.map_form.Size = new System.Drawing.Size(564, 426);
            this.map_form.TabIndex = 0;
            this.map_form.Zoom = 0D;
            this.map_form.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_form_MouseClick);
            // 
            // deleteLocation
            // 
            this.deleteLocation.Location = new System.Drawing.Point(600, 421);
            this.deleteLocation.Name = "deleteLocation";
            this.deleteLocation.Size = new System.Drawing.Size(167, 28);
            this.deleteLocation.TabIndex = 1;
            this.deleteLocation.Text = "Sil";
            this.deleteLocation.UseVisualStyleBackColor = true;
            this.deleteLocation.Visible = false;
            this.deleteLocation.Click += new System.EventHandler(this.deleteLocation_Click);
            // 
            // txtLng
            // 
            this.txtLng.Location = new System.Drawing.Point(689, 166);
            this.txtLng.Name = "txtLng";
            this.txtLng.ReadOnly = true;
            this.txtLng.Size = new System.Drawing.Size(79, 23);
            this.txtLng.TabIndex = 2;
            // 
            // txtLat
            // 
            this.txtLat.HideSelection = false;
            this.txtLat.Location = new System.Drawing.Point(601, 166);
            this.txtLat.Name = "txtLat";
            this.txtLat.ReadOnly = true;
            this.txtLat.Size = new System.Drawing.Size(80, 23);
            this.txtLat.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(601, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 23);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // cmbxType
            // 
            this.cmbxType.FormattingEnabled = true;
            this.cmbxType.Location = new System.Drawing.Point(601, 113);
            this.cmbxType.Name = "cmbxType";
            this.cmbxType.Size = new System.Drawing.Size(167, 23);
            this.cmbxType.TabIndex = 4;
            // 
            // listBoxLocation
            // 
            this.listBoxLocation.FormattingEnabled = true;
            this.listBoxLocation.ItemHeight = 15;
            this.listBoxLocation.Location = new System.Drawing.Point(601, 246);
            this.listBoxLocation.Name = "listBoxLocation";
            this.listBoxLocation.Size = new System.Drawing.Size(167, 169);
            this.listBoxLocation.TabIndex = 5;
            this.listBoxLocation.SelectedIndexChanged += new System.EventHandler(this.listBoxLocation_SelectedIndexChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(600, 199);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(167, 28);
            this.save.TabIndex = 1;
            this.save.Text = "Kaydet";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxLocation);
            this.Controls.Add(this.cmbxType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtLng);
            this.Controls.Add(this.save);
            this.Controls.Add(this.deleteLocation);
            this.Controls.Add(this.map_form);
            this.Name = "Map";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Map_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map_form;
        private Button deleteLocation;
        private TextBox txtLng;
        private TextBox txtLat;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbxType;
        private ListBox listBoxLocation;
        private Button save;
    }
}