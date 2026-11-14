# SaveSmart

> **Project:** Senior Design Project (team) · BSc Computer Engineering, Khalifa University · 2nd place in energy efficiency, Solar Decathlon Middle East

Mobile application for monitoring appliance energy usage in the Khalifa University smart home.

SaveSmart was planned as a monitoring and recommendation system for the KU smart home at the Solar Decathlon Middle East competition site. This repository is an early prototype of the mobile app.

## What I built

A Xamarin.Forms app prototype (Android, iOS, UWP) with a device list, on/off switches for appliances, a local device database and a Recommendations tab.

## Features

- **Home tab**: the KU team logo and a short description of SaveSmart.
- **Devices tab**: a list of smart plugs, each with an on/off switch. Pull down to refresh the list. Tap a plug to open its details, or use **Add** to create a new device with a name and description.
- **Recommendations tab**: a page for appliance-scheduling recommendations.
- **Device storage**: a SQLite database class (sqlite-net) for storing devices on the phone, plus a sample data store with six smart plugs.
- **Smart plug support**: uses the `tplink-smartdevices` library for TP-Link plug discovery.

## Project structure

```
SDP App.sln                  Visual Studio solution
SDP App/
  SDP App/                   Shared .NET Standard 2.0 project
    AppShell.xaml            Tab bar: Home, Devices, Recommendations
    Views/                   Home, Devices, DeviceDetail, NewDevice, Recommendations, Login pages
    ViewModels/              MVVM view models for each page
    Services/                IDataStore interface and MockDataStore (sample devices)
    Database/                SQLite database and table class
    Models/                  Device model and database initialisation
  SDP App.Android/           Android head project
  SDP App.iOS/               iOS head project
  SDP App.UWP/               Universal Windows head project
```

## Getting started

1. Install Visual Studio 2019 with the **Mobile development with .NET** (Xamarin) workload. The solution was created with Visual Studio 16.
2. Open `SDP App.sln`. NuGet restores the packages: Xamarin.Forms 5.0.0.2196, Xamarin.Essentials 1.7.0, sqlite-net-pcl 1.8.116 and tplink-smartdevices 2.0.0.
3. Set `SDP App.Android` (or the iOS or UWP project) as the startup project and run it on an emulator or a device.

## Tech

C#, Xamarin.Forms (Shell, MVVM), Xamarin.Essentials, sqlite-net-pcl, tplink-smartdevices.

## Related

- [SaveSmart-AI](https://github.com/MariamAlz/SaveSmart-AI) (forecasting models)
- [SaveSmart-App](https://github.com/MariamAlz/SaveSmart-App) (team's final system)

## Credits

Started from Visual Studio's Xamarin.Forms Shell app template (see `GettingStarted.txt`).
