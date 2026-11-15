using SaveSmart.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SaveSmart.Views
{
	public partial class DeviceDetailPage : ContentPage
	{
		public DeviceDetailPage()
		{
			InitializeComponent();
			BindingContext = new DeviceDetailViewModel();
		}
	}
}