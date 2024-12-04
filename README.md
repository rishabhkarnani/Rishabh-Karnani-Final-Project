# 🚗 Road Trip Planner

**Road Trip Planner** is a WPF desktop application designed to simplify road trip planning. It calculates trip costs, fetches real-world distances using the Google Maps Distance Matrix API, and provides personalized stop suggestions such as **"Rishabh's Diner"** for an enjoyable journey.

Developed by **Rishabh Karnani**.

---

## 📒 Table of Contents

- [Project Overview](#overview)
- [Setup Instructions](#setup)
- [How to Use](#usage)
- [Code Structure](#structure)
- [Commit History](#commit-history)
- [Key Methods](#key-methods)
- [Screenshots](#screenshots)
- [Dependencies](#dependencies)
- [License](#license)

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

## 📂 Code Structure <a name="structure"></a>

| File/Folder                   | Description                                                                 |
|-------------------------------|-----------------------------------------------------------------------------|
| **RoadTripPlanner.sln**        | Solution file for the Visual Studio project.                              |
| **App.xaml**                   | Defines application-level resources and configuration.                   |
| **App.xaml.cs**                | Contains startup logic for the application.                              |
| **MainWindow.xaml**            | UI design for the main window.                                            |
| **MainWindow.xaml.cs**         | Handles UI logic and API integrations.                                   |
| **Models/TripDetails.cs**      | Model class for storing trip-related details.                            |
| **Services/GoogleMapsService.cs** | Manages Google Maps API integration for distance calculation.          |
| **Utils/StopSuggestions.cs**   | Provides dynamic stop suggestions based on distance.                     |
| **Resources/**                 | Contains static assets like icons or images.                             |
| **screenshots/**               | Contains screenshots for documentation.                                  |


## 🗂️ Commit History <a name="commit-history"></a>


| Commit Hash | Author          | Date       | Message                       |
|-------------|-----------------|------------|-------------------------------|
| a7f3c21     | Rishabh Karnani | 2024-11-15 | Add trip cost calculation     |
| d9b4e17     | Rishabh Karnani | 2024-11-21 | Update README with screenshots|
| 4c3b5ab     | Rishabh Karnani | 2024-11-26 | Fix bug in Google Maps API call|
| 8a2c91d     | Rishabh Karnani | 2024-12-01 | Add dynamic stop suggestions  |


## 📄 Key Methods <a name="key-methods"></a>

### `GetDistanceAsync()`

- **Purpose**: Fetches accurate distances between locations using the Google Maps Distance Matrix API.
- **Details**:
  - Accepts starting and destination locations as input.
  - Returns the distance in kilometers.

### `GetSuggestedStops()`

- **Purpose**: Recommends stops dynamically based on the trip distance.
- **Details**:
  - Includes personalized stop names like **"Rishabh's View Point"**.


## 🖼️ Screenshots <a name="screenshots"></a>

### Main Interface
![Main UI](screenshots/ui_main.png)

### Trip Calculation Results
![Trip Results](screenshots/trip_results.png)


## 🔧 Dependencies <a name="dependencies"></a>

- **.NET Framework**: Comes pre-installed with Visual Studio.
- **Newtonsoft.Json**: Library for handling JSON responses.
- **Google Maps API Key**: For fetching real-world distances.


## 📜 License <a name="license"></a>

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

You are free to use, modify, and distribute this application as per the license terms.


## 👥 Contributors <a name="contributors"></a>

- **Rishabh Karnani** - Developer and Designer of the Road Trip Planner Application.






