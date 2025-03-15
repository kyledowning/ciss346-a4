using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmpClientConsumer
{
    public partial class FormSmpClientConsumer : Form
    {
        // Hardcoded IP and Port (for now).
        string IPAddress = "127.0.0.1";
        int Port = 50444;


        public FormSmpClientConsumer()
        {
            InitializeComponent();
        }

        // Send a CONSUME message to the server, with associated priority
        // Retrieve the server response and store in the MessageContent textbox.
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            FormSmpClientConsumer.SendMessage(IPAddress, Port, MessagesTextbox.Text, this);
        }

        // TODO:
        private void MessagesTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        // TODO:
        private void AppPortLabel_Click(object sender, EventArgs e)
        {

        }

        private void RecordServerResponse() {
            // TODO: Record the consumed message response from the server onto the form.

        }
    }
}
