using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace WTRDragAssistant
{
    public class BlueToothConnection
    {
        private string portName;
        private SerialPort connection;
        private string incomingData;
        private IOnDataReceivedListener listener;

        public BlueToothConnection()
        {

        }

        public BlueToothConnection(string portName)
        {
            this.portName = portName;
        }

        public BlueToothConnection(string portName, IOnDataReceivedListener listener)
        {
            this.portName = portName;
            this.listener = listener;
        }

        public bool Connect()
        {
            try
            {
                connection = new SerialPort(portName, (9600));
                connection.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting(); 
            incomingData = indata;
            listener.OnDataReceived(indata);
        }

        public bool IsConnected()
        {
            return connection.IsOpen;
        }

        public void Disconnect()
        {
            connection.Close();
        }

        public void Test()
        {
            string str = "0,117;14,756;0,243;14,381";
            listener.OnDataReceived(str);
        }
    }
}
