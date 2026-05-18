# ARCore Geospatial Flood Simulation

![Unity](https://img.shields.io/badge/Engine-Unity-black?style=flat&logo=unity)
![Platform](https://img.shields.io/badge/Platform-Android-green?style=flat&logo=android)
![AR](https://img.shields.io/badge/AR-ARCore%20Geospatial-blue)
![API](https://img.shields.io/badge/Maps-Google%20Tiles%20API-red)

**ARCore Geospatial Flood Simulation** is an Android application developed to visualize potential flood scenarios and evacuation routes in real-world environments using **ARCore Geospatial API**.

This project focuses on simulating flood risks in the **Nakhon Pathom Factory area, Thailand**, allowing users to see water levels rising in their actual surroundings without the need for physical markers (markerless), anchored precisely using Global Localization (VPS).

> **Note:** This project serves as a Final Year Project (Tugas Akhir) at **Universitas Pendidikan Ganesha**, in collaboration with **KMUTT Geospatial Engineering and Innovation Center (KGEO)**, Thailand.

## 📖 Table of Contents
- [About the Project](#-about-the-project)
- [Key Features](#-key-features)
- [Tech Stack](#-tech-stack)
- [Prerequisites](#-prerequisites)
- [How to Try (Closed Beta)](#-how-to-try-closed-beta)
- [Installation (For Developers)](#-installation-for-developers)
- [How to Use](#-how-to-use)
- [Screenshots](#-screenshots)
- [Team](#-team)

## ℹ️ About the Project
Traditional flood maps can be difficult for the general public to interpret. This application bridges that gap by providing an immersive Augmented Reality experience. By utilizing **Google's Visual Positioning System (VPS)** and **Cesium for Unity**, the app overlays 3D flood animations directly onto the physical world with high geographic accuracy.

**Objectives:**
1. Visualize flood levels based on rainfall intensity (Low, Medium, High).
2. Provide real-time AR navigation (3D arrows) to the nearest designated shelter.
3. Increase disaster awareness and mitigation preparedness.

## 🌟 Key Features
* **Geospatial Localization:** Uses ARCore Geospatial API to detect the user's precise location (Latitude, Longitude, Altitude) without physical markers.
* **Real-time Flood Simulation:** Adjusts water levels dynamically based on user selection:
    * **Low Intensity:** Puddles/Minor flooding.
    * **Medium Intensity:** Moderate water rise.
    * **High Intensity:** Severe flooding.
* **Smart Navigation:** Displays 3D directional arrows guiding users to the nearest safe shelter (e.g., Wat Yord Phra Phimon School area).
* **Proximity Detection:** Automatically detects when a user enters a flood zone or a safe shelter zone.
* **3D Terrain Mapping:** Integrates **Cesium** to render realistic 3D terrain and building tiles of the location.

## 🛠 Tech Stack
* **Engine:** Unity 2021.3+ (LTS recommended).
* **AR SDK:** ARCore Extensions for Unity (Geospatial API).
* **Mapping:** Google Map Tiles API & Cesium for Unity.
* **3D Modeling:** Blender (for water assets and navigation markers).
* **Language:** C#.

## 📲 Prerequisites
To run or develop this application, you need a device that meets the following **minimum requirements**:

* **OS:** Android 11 (API Level 30) or newer.
* **RAM:** Minimum 6 GB.
* **Processor:** ARM64 based CPU.
* **Network:** Stable Internet Connection (Required for VPS & Tile loading).
* **Service:** Device must support [Google Play Services for AR](https://developers.google.com/ar/devices).

## 🚀 How to Try (Closed Beta)
If you want to experience the application directly on your device without setting up the Unity Editor, you can join the **Google Play Closed Beta Test**:

1. **Request Access:** Contact the developer via the social media links provided on my [GitHub Profile](https://github.com/IGDhananjaya).
2. **Provide Email:** Send your Google Play email address so you can be registered as a designated tester.
3. **Install:** Once added to the tester list, you will receive an exclusive link to download and install the app safely via the Google Play Store.

## 📥 Installation (For Developers)
If you want to explore the source code or build the project yourself:

1.  **Clone the Repo:**
    ```bash
    git clone [https://github.com/IGDhananjaya/AR_Geospatial_Flood.git](https://github.com/IGDhananjaya/AR_Geospatial_Flood.git)
    ```
2.  **Open in Unity:**
    Open the project folder using Unity Hub.
3.  **API Keys Configuration (Important):**
    * Go to `Edit > Project Settings > XR Plug-in Management > ARCore Extensions`.
    * Insert your **Google Cloud API Key** (must have ARCore API & Map Tiles API enabled).
    * Open the `CesiumGeoreference` object in the hierarchy and input your **Cesium Ion Token**.
4.  **Build to Android (APK):**
    * Go to `File > Build Settings`.
    * Switch platform to **Android**.
    * Click **Build** to generate the `.apk` file.
    * Transfer the generated `.apk` to your Android device, enable "Install from Unknown Sources", and install it.

## 🎮 How to Use
1.  **Launch the App:** Allow Camera and Location permissions (Precision Location is required).
2.  **Scan Surroundings:** Point your camera at buildings/streets to let the VPS localize your position.
3.  **Start Simulation:**
    * Tap **"Scan AR"**.
    * Once localized, the menu will appear.
4.  **Select Intensity:** Choose *Low*, *Medium*, or *High* from the dropdown to see the water rise.
5.  **Evacuation:** Follow the floating 3D arrows to find the path to the nearest shelter.

## 📸 Screenshots
<img src="ImageGithub/HomeScreen.jpeg" width="200" alt="Main Menu"> <img src="ImageGithub/GuideScreen.jpeg" width="200" alt="Guide Menu"> <img src="ImageGithub/Tampilan Utama Aplikasi 1.jpeg" width="200" alt="Scan Simulation"> 

> **Demo Video:** Watch the application in action [here]([https://youtube.com/shorts/tYUyucNBaCs?feature=share]).

## 👥 Team
**Developer**
* **I Gede Dhananjaya** - *D4 Teknologi Rekayasa Perangkat Lunak, UNDIKSHA*

**Supervisors**
* Kadek Yota Ernanda Aryanto, S.Kom., M.T., Ph.D. (UNDIKSHA)
* Dr. I Gede Partha Sindu, S.Pd., M.Pd. (UNDIKSHA)

---
*This project is submitted as a Final Year Project (Skripsi/TA) 2026.*
