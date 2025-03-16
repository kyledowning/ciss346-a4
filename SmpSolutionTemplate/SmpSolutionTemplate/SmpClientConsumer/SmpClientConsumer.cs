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
        string IPAddress;
        int port;
        int radio = -1;
        string serverResponse;

        public FormSmpClientConsumer()
        {
            InitializeComponent();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {

            if (radio == -1)
            {
                MessageBox.Show("You must select a message priority");
                return;
            }

            try
            {
                this.IPAddress = ServerIPTextbox.Text;
                this.port = Int32.Parse(AppPortTextbox.Text);
                string message = "CONSUME " + radio;
                MessagesTextbox.Clear();
                ClientConsum.SendMessage(IPAddress, port, message, this);
            }

            catch (Exception)
            {
                ServerIPTextbox.Clear();
                AppPortTextbox.Clear();
                MessageBox.Show("Error: Enter a valid IP address and port number for an active server.");
            }

        }

        private void RecordServerResponse() {
            this.MessagesTextbox.Text = serverResponse;
        }

        public void RecordServerResponse(string serverResponse)
        {
            try
            {
                this.serverResponse = serverResponse;

                Invoke(new MethodInvoker(RecordServerResponse));
            }
            catch (Exception)
            {

            }
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
        
        private void MessagesTextbox_TextChanged(object sender, EventArgs e) {}
        private void AppPortLabel_Click(object sender, EventArgs e) {}
    }
}
