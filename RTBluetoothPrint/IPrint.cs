using System;
namespace RTBluetoothPrint
{
	public interface IPrint
	{
		bool OpenPrinter(string macAddress); //Open printer connection
		void ClosePrinter(); //Close printer connection
		void Begin(); //Initialize printer
		void ImportData(byte[] data, int dataLen);
		void ImportData(string dataString);
		void LF();
		bool Execute(); //Send data and start to print
		void ClearData(); //Perform Execute() and clear buffer
	}
}
