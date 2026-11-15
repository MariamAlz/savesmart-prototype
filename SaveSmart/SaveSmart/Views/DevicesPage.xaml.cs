using SaveSmart.Models;
using SaveSmart.ViewModels;
using SaveSmart.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaveSmart.Views
{
	public partial class DevicesPage : ContentPage
	{
		DevicesViewModel _viewModel;

		public DevicesPage()
		{
			InitializeComponent();

			BindingContext = _viewModel = new DevicesViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			_viewModel.OnAppearing();
		}
		void OnToggled(object sender, ToggledEventArgs e)
		{
			// Perform an action after examining e.Value
		}
	}
}