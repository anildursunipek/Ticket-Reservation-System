using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Forms
{
    public partial class Map : Form
    {
        Models.Location _location;
        Models.Location _selectedLocation;
        List<Models.Location> _locations;
        AppDbContext db;
        public Map()
        {
            InitializeComponent();
            _location = new Models.Location();
            _selectedLocation = new Models.Location();
            _locations = new List<Models.Location>();
            db = new AppDbContext();
        }


        private void Map_Load(object sender, EventArgs e)
        {
            getOverlays();
            loadMap();
            fillLocationType();
        }

        private void fillLocationType()
        {
            cmbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxType.Items.Add("Otobüs terminali");
            cmbxType.Items.Add("Havalimanı");
            cmbxType.Items.Add("İskele");

            cmbxType.SelectedIndex = 0;
        }

        private void getOverlays()
        {
            _locations = db.Locations.ToList();
            map_form.Overlays.Clear();


            foreach (var location in _locations)
            {
                PointLatLng point = new PointLatLng();
                point.Lat = location.lat;
                point.Lng = location.lng;
                var markers =  new GMapOverlay("markers" + location.Name);               

                var marker = new GMarkerGoogle(point, typeBitmap(location.Type));

                markers.Markers.Add(marker);

                marker.ToolTipText = location.Name;
                var toolTip = new GMapToolTip(marker)
                {
                    Fill = new SolidBrush(Color.AliceBlue),
                    Foreground = new SolidBrush(Color.Black),
                    Offset = new Point(100, -50),
                    Stroke = new Pen(new SolidBrush(Color.DarkGray))
                };
                marker.ToolTip = toolTip;
                map_form.Overlays.Add(markers);
                _selectedLocation = location;

            }
            listBoxLocation.DataSource = _locations;
            listBoxLocation.DisplayMember = "Name";

        }
        private Bitmap typeBitmap(String type)
        {
            var bmpMarker = (Bitmap)Image.FromFile("../../../../assets/busterminal.png");

            if (type == "Otobüs terminali")
            {
                bmpMarker = (Bitmap)Image.FromFile("../../../../assets/busterminal.png");
            }
            else if (type == "Havalimanı")
            {
                bmpMarker = (Bitmap)Image.FromFile("../../../../assets/airport.png");
            }
            else if (type == "İskele")
            {
                bmpMarker = (Bitmap)Image.FromFile("../../../../assets/dock.png");
            }
            Bitmap resized = new Bitmap(bmpMarker, new Size(36, 36));
            return resized;
        }


        private void loadMap()
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBN50-5kdt6jH2eu30jV5dWoaIdjA47X20";
            map_form.DragButton = MouseButtons.Left;
            map_form.MapProvider = GMapProviders.GoogleMap;
            map_form.ShowCenter = false;
            map_form.MinZoom = 5;
            map_form.MaxZoom = 100;
            map_form.Zoom = 10;
            map_form.SetPositionByKeywords("Bursa");
        }

        private bool formControl()
        {
            if (txtName.Text != "" && cmbxType.Text != "" && txtLat.Text != "" && txtLng.Text != "")
            {
                return true;
            }
            return false;
        }

        private void formClear()
        {
            txtName.Text = "";
            cmbxType.Text = "";
            txtLat.Text = "";
            txtLng.Text = "";

        }

        private void map_form_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var point = map_form.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                txtLat.Text = lat.ToString();
                txtLng.Text = lng.ToString();
                LoadMap(point);
                AddMarker(point);
            }
        }

        private void LoadMap(PointLatLng point)
        {
            map_form.Position = point;
        }

        private void AddMarker(PointLatLng point, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {

            GMapOverlay markerOverlay = map_form.Overlays.FirstOrDefault(o => o.Id == "clickMarker");

            if (markerOverlay != null)
            {
                markerOverlay.Markers[0].Position = point;
                map_form.Refresh();
            }
            else
            {
                var markers = new GMapOverlay("clickMarker");
                var marker = new GMarkerGoogle(point, markerType);
                markers.Markers.Add(marker);
                map_form.Overlays.Add(markers);
            }

        }

        private void listBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Location curItem = (Models.Location) listBoxLocation.SelectedItem;
            _selectedLocation = _locations.Find(location => location.Name.ToLower() == curItem.Name.ToLower());
            LoadMap(new PointLatLng(_selectedLocation.lat, _selectedLocation.lng));

            deleteLocation.Visible = true;
        }

        private void deleteLocation_Click(object sender, EventArgs e)
        {
           db.Locations.Remove(_selectedLocation);
            db.SaveChanges();
            MessageBox.Show("Silindi.");
            deleteLocation.Visible = false;
            getOverlays();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (formControl())
            {
                _location = new Models.Location();
                _location.Name = txtName.Text;
                _location.Type = cmbxType.Text;
                _location.lat = Convert.ToDouble(txtLat.Text);
                _location.lng = Convert.ToDouble(txtLng.Text);

                db.Locations.Add(_location);
                db.SaveChanges();
                getOverlays();
                MessageBox.Show("Kaydedildi.");
                _location = new Models.Location();
                formClear();
            }
            else
            {
                MessageBox.Show("Boş alanları doldurnuz.");
            }
        }
    }
}