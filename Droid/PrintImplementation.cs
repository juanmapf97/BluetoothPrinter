using System;
using Com.RT_Printer.BluetoothPrinter.BLUETOOTH;
using RTBluetoothPrint.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(PrintImplementation))]
namespace RTBluetoothPrint.Droid
{
	public class PrintImplementation
	{
		public bool OpenPrinter(string macAddress)
		{
			return BluetoothPrintDriver.OpenPrinter(macAddress);
		}

		public void ClosePrinter()
		{
			BluetoothPrintDriver.Close();
		}

		public void Begin()
		{
			BluetoothPrintDriver.Begin();
		}

		public void ImportData(byte[] data, int dataLen)
		{
			BluetoothPrintDriver.ImportData(data, dataLen);
		}

		public void ImportData(string data)
		{
			BluetoothPrintDriver.ImportData(data);
		}

		public void LF()
		{
			BluetoothPrintDriver.LF();
		}

		public bool Execute()
		{
			return BluetoothPrintDriver.Excute();
		}

		public void ClearData()
		{
			BluetoothPrintDriver.ClearData();
		}
	}
}
