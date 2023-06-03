using GMap.NET.MapProviders;
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
using Ticket_Reservation_System.Repositories;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Forms
{
    public partial class AddTrip : Form
    {
        AppDbContext db;
        List<Models.Location> _locations;
        Models.Location _selectedLocation;
        Models.Location _selectedListBoxLocation;
        String _selectedType;

        Trip _trip;

        Vehicle _selectedVehicle;
        Firm _selectedFirm;

        TripRepository _tripRepository;
        VehicleRepository _vehicleRepository;
        FirmRepository _firmRepository;


        public AddTrip()
        {
            InitializeComponent();
            db = new AppDbContext();
            _locations = new List<Models.Location>();
            _selectedLocation = new Models.Location();
            _selectedListBoxLocation = new Models.Location();
            _tripRepository = new TripRepository();
            _vehicleRepository = new VehicleRepository();
            _firmRepository = new FirmRepository();
            _trip = new Trip();
            comboBoxTrip.DropDownStyle = ComboBoxStyle.DropDownList;
            listBoxTrip.DisplayMember = "Name";

            fillLocationType();
            getFirms();

            comboBoxFirm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVehicle.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            loadMap();
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

        private void fillLocationType()
        {
            cmbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxType.Items.Add("Otobüs terminali");
            cmbxType.Items.Add("Havalimanı");
            cmbxType.Items.Add("İskele");

            cmbxType.SelectedIndex = 0;
        }

        private void cmbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            map_form.Overlays.Clear();
            listBoxTrip.Items.Clear();
            var curItem = (String) cmbxType.SelectedItem;
            _selectedType = curItem;
            _locations = new List<Models.Location>();

            foreach (var location in db.Locations.ToList())
            {
                if (location.Type == curItem)
                {
                    _locations.Add(location);
                }
            }
            labelTrip.Visible = true;
            comboBoxTrip.Visible = true;
            btnTripAdd.Visible = true;
            comboBoxTrip.DataSource = _locations;
            comboBoxTrip.DisplayMember = "Name";
            getOverlays();
            
        }

        private void getOverlays()
        {
            map_form.Overlays.Clear();
            var markers = new GMapOverlay("markers");
            foreach (var location in _locations)
            {
                PointLatLng point = new PointLatLng();
                point.Lat = location.lat;
                point.Lng = location.lng;

                var marker = new GMarkerGoogle(point, typeBitmap(location.Type));

                marker.ToolTipText = location.Name;
                var toolTip = new GMapToolTip(marker)
                {
                    Fill = new SolidBrush(Color.AliceBlue),
                    Foreground = new SolidBrush(Color.Black),
                    Offset = new Point(100, -50),
                    Stroke = new Pen(new SolidBrush(Color.DarkGray))
                };
                marker.ToolTip = toolTip;
                markers.Markers.Add(marker);
            }
            map_form.Overlays.Add(markers);
            map_form.Refresh();
            

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

        private PointLatLng convertPointLatLng(double lat, double lng)
        {

            PointLatLng point = new PointLatLng();
            point.Lat = lat;
            point.Lng = lng;
            return point;
        }

        private void getRoute()
        {
            List<Models.Location> locations = listBoxTrip.Items.Cast<Models.Location>().ToList();

            while (true)
            {
                GMapOverlay routeOverlay = map_form.Overlays.FirstOrDefault(o => o.Id == "routes");
                if (routeOverlay != null)
                {
                    map_form.Overlays.Remove(routeOverlay);
                }
                else
                {
                    break;
                }
            }

            if (locations.Count > 1)
            {

                for (int i = 1; i < locations.Count; i++)
                {
                    
                    var route = GoogleMapProvider.Instance
                        .GetRoute(convertPointLatLng(locations[i - 1].lat, locations[i - 1].lng), convertPointLatLng(locations[i].lat, locations[i].lng), false, false, 14);

                    var r = new GMapRoute(route.Points, "My Route")
                    {
                        Stroke = new Pen(Color.Red, 5)
                    };

                    if (_selectedType != "Otobüs terminali")
                    {
                        r = new GMapRoute(new List<PointLatLng>() { convertPointLatLng(locations[i - 1].lat, locations[i - 1].lng), convertPointLatLng(locations[i].lat, locations[i].lng) }, "My Route")
                        {
                            Stroke = new Pen(Color.Red, 5)
                        };
                    }

                    var routes = new GMapOverlay("routes");
                    routes.Routes.Add(r);
                    map_form.Overlays.Add(routes);
                }
            }
        }

        private void comboBoxTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedLocation = (Models.Location)comboBoxTrip.SelectedItem;
        }

        private void btnTripAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxTrip.Items.Cast<Models.Location>().ToList().Count != 0)
            {
                listBoxTrip.Items.Add(_selectedLocation);
            List<Models.Location> locations = new List<Models.Location>();
            foreach (var item in _locations)
            {
                if(listBoxTrip.Items.Cast<Models.Location>().ToList().Find(lstbox => lstbox == item) == null)
                locations.Add(item);
            }
            comboBoxTrip.DataSource = locations;

            getRoute();
            }

        }

        private void listBoxTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedListBoxLocation = (Models.Location) listBoxTrip.SelectedItem;
        }

        private void deleteLocation_Click(object sender, EventArgs e)
        {
            listBoxTrip.Items.Remove(_selectedListBoxLocation);
            _selectedListBoxLocation = new Models.Location();

            List<Models.Location> locations = new List<Models.Location>();
            foreach (var item in _locations)
            {
                if (listBoxTrip.Items.Cast<Models.Location>().ToList().Find(lstbox => lstbox == item) == null)
                    locations.Add(item);
            }
            comboBoxTrip.DataSource = locations;


            getRoute();
        }

        private void btnSaveTrip_Click(object sender, EventArgs e)
        {
            if (formController())
            {
                _trip.VehicleId = _selectedVehicle.Id;
                _trip.StartingPointId = _locations[0].Id;
                _trip.DestinationPointId = _locations[_locations.Count-1].Id;
                _trip.Duration =  Convert.ToDateTime(dateTimePickerStart.Text);
                _trip.Description = textBoxDescription.Text;
                _tripRepository.AddTrip(_trip);
                _trip = new Trip();
                MessageBox.Show("Kaydedildi.");
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz.");
            }
        }

        private bool formController()
        {
            if (_locations.Count > 1 && comboBoxFirm.SelectedItem != null && comboBoxVehicle.SelectedItem != null && dateTimePickerStart.Text != "")
            {
                return true;
            }
            return false;
        }

        private void comboBoxFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFirm = (Firm) comboBoxFirm.SelectedItem;
            getVehicleByFirm();
        }

        private void comboBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedVehicle = (Vehicle) comboBoxVehicle.SelectedItem;
        }

        private void getVehicleByFirm()
        {
            var _vehicles = _vehicleRepository.GetVehiclesByFirmId(_selectedFirm.Id);
            comboBoxVehicle.DataSource = _vehicles;
            comboBoxVehicle.DisplayMember = "Plate";
        }
        private void getFirms()
        {
            var _firms = _firmRepository.GetAllFirms();
            comboBoxFirm.DataSource = _firms;
            comboBoxFirm.DisplayMember = "Name";
        }
    }
}
