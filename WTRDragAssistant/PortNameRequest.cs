using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTRDragAssistant
{
    public partial class PortNameRequest : Form
    {
        private StringBuilder portName;

        public PortNameRequest(StringBuilder portName)
        {
            InitializeComponent();
            this.portName = portName;
        }

        private void labelPortName_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPortName.Text.Length == 0)
            { 
                MessageBox.Show("Input Port name!");
            }
            else
            {
                portName.Insert(0, textBoxPortName.Text);
                textBoxPortName.Clear();
                Hide();
            }
        }

        private void PortNameRequest_Load(object sender, EventArgs e)
        {

        }

        private void PortNameRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }

        private void PortNameRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOK.PerformClick();
            }
        }
    }
}
