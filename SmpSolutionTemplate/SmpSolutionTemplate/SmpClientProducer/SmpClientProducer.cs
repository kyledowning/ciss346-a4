/*
 * Names: Kyle Downing and Ethan Griffith. 
 * Date: 3/16/25
 * Desc: Event handelers for client producer GUI.
*/

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

        string IPAddress;
        int port;
        int radio = -1;

        string serverResponse;

        public FormSmpClientProducer()
        {
            InitializeComponent();
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

        private void RecordServerResponse() {
            this.ServerResponseTextbox.Text = serverResponse;
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {

            if (MessagesTextbox.Text.Length == 0)
            {
                MessageBox.Show("You cannot send an empty message to the server!!");
                return;
            }

            if (radio == -1)
            {
                MessageBox.Show("You must select a message priority");
                return;
            }

            try
            {
                this.IPAddress = ServerIPTextbox.Text;
                this.port = Int32.Parse(AppPortTextbox.Text);
                string message = "PUT " + radio + " " + MessagesTextbox.Text;
                ServerResponseTextbox.Clear();
                ClientProd.SendMessage(IPAddress, port, message, this);
                MessagesTextbox.Clear();
            }

            catch (Exception)
            {
                ServerIPTextbox.Clear();
                AppPortTextbox.Clear();
                MessageBox.Show("Error: Enter a valid IP address and port number for an active server.");
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
        private void ServerResponseTextbox_TextChanged(object sender, EventArgs e) {}
        private void ServerIPTextbox_TextChanged(object sender, EventArgs e) {}
        private void AppPortTextbox_TextChanged(object sender, EventArgs e) {}
    }
}
