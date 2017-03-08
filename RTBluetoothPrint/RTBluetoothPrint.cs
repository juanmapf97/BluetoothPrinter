using System;

using Xamarin.Forms;
using BluetoothLE.Core;

namespace RTBluetoothPrint
{
	public class App : Application
	{
		private static readonly IAdapter _bluetoothAdapter;
		public static IAdapter BluetoothAdapter { get { return _bluetoothAdapter; } }

		static App()
		{
			// The root page of your application
			_bluetoothAdapter = DependencyService.Get<IAdapter>();

			_bluetoothAdapter.ScanTimeout = TimeSpan.FromSeconds(10);
			_bluetoothAdapter.ConnectionTimeout = TimeSpan.FromSeconds(10);

		}

		public App()
		{
			MainPage = new NavigationPage(new DeviceListPage())
			{
				Title = "Bluetooth Explorer"
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
