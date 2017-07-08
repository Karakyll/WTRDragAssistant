using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace WTRDragAssistant
{
    public partial class WTRDragAssistantForm : Form, IOnDataReceivedListener
    {
        private Races races = new Races();
        private BlueToothConnection blueToothConnection;

        public WTRDragAssistantForm(Races races, string portName)
        {
            InitializeComponent();
            this.races = races;
            this.blueToothConnection = new BlueToothConnection(portName, this);
            this.blueToothConnection.Connect();
        }

        private void WTRDragAssistantForm_Load(object sender, EventArgs e)
        {
            
        }

        private void WTRDragAssistantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            blueToothConnection.Disconnect();
            races.Serialize();
        }

        private void buttonStartChekIn_Click(object sender, EventArgs e)
        {
            if (textBoxLeftCarNumber.Text.Length == 0 || textBoxRightCarNumber.Text.Length == 0)
            {
                MessageBox.Show("Input cars plate number!");
            }
            else
            {
                textBoxLeftCarNumber.ReadOnly = true;
                textBoxRightCarNumber.ReadOnly = true;
                buttonCancel.Visible = true;
                buttonStartChekIn.Enabled = false;
                blueToothConnection.Test();
            }      
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxLeftCarNumber.ReadOnly = false;
            textBoxRightCarNumber.ReadOnly = false;
            buttonCancel.Visible = false;
            buttonStartChekIn.Enabled = true;
        }

        public void OnDataReceived(string data)
        {
            string[] strs = data.Split(';');

            if (strs != null)
            {
                labelLeftReactionTime.Text = strs[0];
                labelLeftElapsedTime.Text = strs[1];
                labelRightReactionTime.Text = strs[2];
                labelRightElapsedTime.Text = strs[3];

                double leftRT = 0, leftET = 0, rightRT = 0, rightET = 0;
                if (double.TryParse(strs[0], out leftRT) && double.TryParse(strs[1], out leftET))
                {
                    labelLeftETplusRT.Text = (leftRT + leftET).ToString();
                }
                if (double.TryParse(strs[2], out rightRT) && double.TryParse(strs[3], out rightET))
                {
                    labelRightETplusRT.Text = (rightRT + rightET).ToString();
                }
                if ((leftET + leftRT) < (rightET + rightRT))
                {
                    this.labelLeftCarWin.Visible = true;
                }
                else
                {
                    this.labelRightCarWin.Visible = true;
                }

                if (!buttonStartChekIn.Enabled)
                {
                    races.AddNewChekIn(
                    new CheckIn(
                        DateTime.Now,
                        new Result(textBoxLeftCarNumber.Text, leftRT, leftET),
                        new Result(textBoxRightCarNumber.Text, rightRT, rightET)));
                }
                
                textBoxLeftCarNumber.ReadOnly = false;
                textBoxRightCarNumber.ReadOnly = false;
                buttonCancel.Visible = false;
                buttonStartChekIn.Enabled = true;
            }
            
        }
    }
}
