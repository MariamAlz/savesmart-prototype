using SaveSmart.ViewModels;
using SaveSmart.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SaveSmart
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(DeviceDetailPage), typeof(DeviceDetailPage));
			Routing.RegisterRoute(nameof(NewDevicePage), typeof(NewDevicePage));
		}

	}
}
