# 🚗 Road Trip Planner

**Road Trip Planner** is a WPF desktop application designed to simplify trip planning by calculating the estimated cost of travel and providing tailored stop suggestions. Using the **Google Maps Distance Matrix API**, it fetches real-world distances between your chosen locations and offers dynamic stops inspired by Rishabh's personalized branding.

---

## 🌟 Key Features
- **Real Distance Calculation**: Fetches accurate distances between your starting point and destination using the Google Maps API.
- **Trip Cost Estimation**: Calculates the total fuel cost based on your vehicle's mileage and current fuel price.
- **Dynamic Stops Suggestions**: Personalized stops such as "Rishabh's Diner" and "Rishabh's Rest Plaza" are shown based on trip distance.
- **Google Maps Integration**: Opens the route in Google Maps for easy navigation.
- **User-Friendly Interface**: A clean, modern UI with clear inputs, action buttons, and output display.

---

## 🛠️ Setup Instructions

### Prerequisites
1. **Visual Studio**:
   - Download and install [Visual Studio](https://visualstudio.microsoft.com/) with the following workloads:
     - **.NET Desktop Development**
2. **NuGet Package**:
   - Install the `Newtonsoft.Json` package:
     - Go to `Tools > NuGet Package Manager > Manage NuGet Packages for Solution`.
     - Search for **Newtonsoft.Json** and install it for your project.

3. **Google Maps API Key**:
   - Obtain a **Google Maps API Key**:
     - Visit [Google Cloud Console](https://console.cloud.google.com/).
     - Enable the **Distance Matrix API**.
     - Generate an API Key and add it to the `GetDistanceAsync` method in the code.

---

## 🚀 How to Run

### Steps to Run Locally
1. **Clone the Repository**:
   ```bash
   git clone <repository-link>
