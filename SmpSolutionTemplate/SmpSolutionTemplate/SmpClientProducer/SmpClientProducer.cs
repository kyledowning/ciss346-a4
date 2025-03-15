using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmpClientProducer
{
    public partial class FormSmpClientProducer : Form
    {
        public FormSmpClientProducer()
        {
            InitializeComponent();
        }

        // TODO: Add event listeners to handle UI events.
        // Send messages to server over TCP connection.
        // Retrieve a response that confirms the message production operation successful.

        private void RecordServerResponse() {
            // TODO: Record server acknoledgement.
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {

        }

        private void MessagesTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServerResponseTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServerIPTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppPortTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LowRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HighRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
