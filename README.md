# 🚗 Road Trip Planner

**Road Trip Planner** is a WPF desktop application designed to simplify road trip planning. It calculates trip costs, fetches real-world distances using the Google Maps Distance Matrix API, and provides personalized stop suggestions such as **"Rishabh's Diner"** for an enjoyable journey.

Developed by **Rishabh Karnani**.

---

## 📒 Table of Contents

- [Project Overview](#overview)
- [Setup Instructions](#setup)
- [How to Use](#usage)
- [Code Structure](#structure)
- [Key Methods](#methods)
- [Screenshots](#screenshots)
- [Dependencies](#dependencies)
- [License](#license)
- [Next Steps](#next)

---

## ✏️ Project Overview <a class="anchor" id="overview"></a>

Road Trip Planner is a user-friendly application for calculating travel costs and planning trips. It uses the **Google Maps API** to fetch real-time distances and provides dynamic stop suggestions based on the journey's length. Designed with a modern UI, it offers a seamless experience for users.

---

## 🛠️ Setup Instructions <a class="anchor" id="setup"></a>

### Prerequisites

1. **Visual Studio**:
   - Install [Visual Studio](https://visualstudio.microsoft.com/) with the `.NET Desktop Development` workload.
2. **Newtonsoft.Json**:
   - Install this library for JSON handling:
     - Go to `Tools > NuGet Package Manager > Manage NuGet Packages for Solution`.
     - Search for **Newtonsoft.Json** and click **Install**.
3. **Google Maps API Key**:
   - Visit [Google Cloud Console](https://console.cloud.google.com/).
   - Enable the **Distance Matrix API**.
   - Generate an API key and replace `YOUR_API_KEY` in the code.

### Steps to Run

1. Clone the repository:
   ```bash
   git clone <repository-link>
2. Open the project in Visual Studio:
3. Load the RoadTripPlanner.sln file.
4. Replace YOUR_API_KEY in the GoogleMapsService.cs file with your Google Maps API Key.
5. Build and run the project.

## 🚀 How to Use <a class="anchor" id="usage"></a>

1. Launch the application.
2. Enter the following trip details:
- Starting Point: Your trip's starting location.
- Destination: Your trip's destination.
- Mileage (km/L): Your vehicle's fuel efficiency.
- Fuel Price ($/L): The current fuel price per liter.
3. Click Calculate: The app displays the estimated trip cost and personalized stops.
4. Click Open Google Maps to view the route in your browser.
