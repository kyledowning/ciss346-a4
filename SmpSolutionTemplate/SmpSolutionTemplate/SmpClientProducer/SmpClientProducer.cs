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

        string IPAddress = "127.0.0.1";
        int port = 50444;
        int radio;


        public FormSmpClientProducer()
        {
            InitializeComponent();
        }

        // TODO: Add event listeners to handle UI events.
        // Send messages to server over TCP connection.
        // Retrieve a response that confirms the message production operation successful.

        private void RecordServerResponse() {
            // TODO: Record server acknoledgement
            this.MessagesTextbox.Text = "something";
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            // Need helper file here for network connection.
        }

        private void MessagesTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServerResponseTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServerIPTextbox_TextChanged(object sender, EventArgs e)
        {
            IPAddress = this.ServerIPTextbox.Text;
        }

        private void AppPortTextbox_TextChanged(object sender, EventArgs e)
        {
            port = Int32.Parse(this.AppPortTextbox.Text);
        }

        private void LowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            radio = 0;
        }

        private void MediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            radio = 1;
        }

        private void HighRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            radio = 2;
        }
    }
}
