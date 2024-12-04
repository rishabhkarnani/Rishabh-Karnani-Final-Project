# 🚗 Road Trip Planner

**Road Trip Planner** is a desktop application built with WPF (Windows Presentation Foundation) to help users plan their road trips effectively. It calculates the estimated travel cost, fetches real-world distances using the Google Maps API, and suggests personalized stops like **"Rishabh's Diner"** for a delightful journey.

---

## 🌟 Key Features

- **Real Distance Calculation**: Fetches exact distances between locations using Google Maps API.
- **Trip Cost Estimation**: Calculates total fuel costs based on mileage and fuel price.
- **Personalized Stop Suggestions**: Offers dynamic stops with custom branding like "Rishabh's View Point."
- **Google Maps Integration**: Opens the trip route directly in Google Maps.
- **User-Friendly Interface**: Modern design with clear inputs and outputs.

---

## 🛠️ Setup Instructions

### Prerequisites
1. **Visual Studio**: Install [Visual Studio](https://visualstudio.microsoft.com/) with the `.NET Desktop Development` workload.
2. **Newtonsoft.Json**: Install this package to handle JSON responses.
   - In Visual Studio, go to `Tools > NuGet Package Manager > Manage NuGet Packages for Solution`.
   - Search for **Newtonsoft.Json** and install it.
3. **Google Maps API Key**:
   - Go to [Google Cloud Console](https://console.cloud.google.com/).
   - Enable the **Distance Matrix API**.
   - Create an API key and add it to the `GetDistanceAsync()` method in the code.

---

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone <repository-link>
