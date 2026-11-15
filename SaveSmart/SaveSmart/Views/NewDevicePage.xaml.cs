using SaveSmart.Models;
using SaveSmart.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaveSmart.Views
{
	public partial class NewDevicePage : ContentPage
	{
		public Dev Device { get; set; }

		public NewDevicePage()
		{
			InitializeComponent();
			BindingContext = new NewDeviceViewModel();
		}
	}
}