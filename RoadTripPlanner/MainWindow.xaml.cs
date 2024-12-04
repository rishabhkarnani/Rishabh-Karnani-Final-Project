using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace RoadTripPlanner
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Check inputs
                if (string.IsNullOrWhiteSpace(StartPointTextBox.Text) || string.IsNullOrWhiteSpace(DestinationTextBox.Text))
                {
                    MessageBox.Show("Enter Starting Point and Destination.");
                    return;
                }

                // Check mileage
                if (!double.TryParse(MileageTextBox.Text, out double mileage) || mileage <= 0)
                {
                    MessageBox.Show("Enter valid Mileage.");
                    return;
                }

                // Check fuel price
                if (!double.TryParse(FuelPriceTextBox.Text, out double fuelPrice) || fuelPrice <= 0)
                {
                    MessageBox.Show("Enter valid Fuel Price.");
                    return;
                }

                // Get distance
                double distance = await GetDistanceAsync(StartPointTextBox.Text, DestinationTextBox.Text);

                // Calculate cost
                double fuelRequired = distance / mileage;
                double cost = fuelRequired * fuelPrice;

                // Show cost
                CostTextBlock.Text = $"${cost:F2} for {distance:F2} km";

                // Show stops
                string[] stops = GetSuggestedStops(distance);
                StopsListBox.Items.Clear();
                foreach (var stop in stops)
                {
                    StopsListBox.Items.Add(stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task<double> GetDistanceAsync(string origin, string destination)
        {
            // Google API key
            string apiKey = "AIzaSyDJCqGs5qgIy0KkOCwd7MUqQXilDzr4bM4";
            string url = $"https://maps.googleapis.com/maps/api/distancematrix/json?origins={Uri.EscapeDataString(origin)}&destinations={Uri.EscapeDataString(destination)}&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                // Fetch data
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(jsonResponse);

                    if (data.rows[0].elements[0].status == "OK")
                    {
                        // Convert meters to kilometers
                        double distanceInMeters = data.rows[0].elements[0].distance.value;
                        return distanceInMeters / 1000.0;
                    }
                    else
                    {
                        throw new Exception("Error: " + data.rows[0].elements[0].status);
                    }
                }
                else
                {
                    throw new Exception("Failed to fetch distance.");
                }
            }
        }

        private void OpenGoogleMapsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get points
                string startPoint = StartPointTextBox.Text;
                string destination = DestinationTextBox.Text;

                if (string.IsNullOrWhiteSpace(startPoint) || string.IsNullOrWhiteSpace(destination))
                {
                    MessageBox.Show("Enter Starting Point and Destination.");
                    return;
                }

                // Open Google Maps
                string mapsUrl = $"https://www.google.com/maps/dir/?api=1&origin={Uri.EscapeDataString(startPoint)}&destination={Uri.EscapeDataString(destination)}";

                Process.Start(new ProcessStartInfo
                {
                    FileName = mapsUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string[] GetSuggestedStops(double distance)
        {
            // Stops for short trips
            if (distance < 200)
                return new string[] { "No stops needed" };

            // Stops for medium trips
            else if (distance < 500)
                return new string[]
                {
                    "Rishabh's Diner - Great Breakfast Spot",
                    "Rishabh's View Point - Enjoy the Scenery"
                };

            // Stops for long trips
            else if (distance < 800)
                return new string[]
                {
                    "Rishabh's Diner - Great Breakfast Spot",
                    "Rishabh's View Point - Enjoy the Scenery",
                    "Rishabh's Rest Plaza - Rest and Refuel"
                };

            // Stops for very long trips
            else
                return new string[]
                {
                    "Rishabh's Diner - Great Breakfast Spot",
                    "Rishabh's View Point - Enjoy the Scenery",
                    "Rishabh's Rest Plaza - Rest and Refuel",
                    "Rishabh City Lookout - Perfect for Photos",
                    "Rishabh's Relaxation Area - Recharge Yourself"
                };
        }
    }
}
