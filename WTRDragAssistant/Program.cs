using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text;


namespace WTRDragAssistant
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] st;
            string str = "1;2;3;4";
            st = str.Split(';');

            StringBuilder portName = new StringBuilder();
            BlueToothConnection blueToothConnection;
            Races races = new Races("races.xml");

            PortNameRequest portNameRequest = new PortNameRequest(portName);
            portNameRequest.StartPosition = FormStartPosition.CenterScreen;

            do
            {
                portName.Clear();
                portNameRequest.KeyPreview = true;
                portNameRequest.ShowDialog();
                blueToothConnection = new BlueToothConnection(portName.ToString());
                if (!blueToothConnection.Connect())
                {
                    portNameRequest.KeyPreview = false;
                    MessageBox.Show("This port does not exist.");
                }
            }
            while (!blueToothConnection.IsConnected());

            portNameRequest.Dispose();
            blueToothConnection.Disconnect();
            blueToothConnection = null;

            WTRDragAssistantForm WTRDragAssistant = new WTRDragAssistantForm(races, portName.ToString());
            WTRDragAssistant.StartPosition = FormStartPosition.CenterScreen;
            WTRDragAssistant.ShowDialog();
        }
    }
}
