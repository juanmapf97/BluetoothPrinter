using System;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using BluetoothLE.Core;

namespace RTBluetoothPrint
{
	public class PrintController : ContentPage
	{
		public PrintController(IDevice Device)
		{
			DependencyService.Get<IPrint>().OpenPrinter(Device.Id.ToString());

			Content = new StackLayout
			{
				Children = {
					new Button { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

