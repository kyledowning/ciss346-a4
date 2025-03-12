using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmpServer
{
    public partial class FormSmpServer : Form
    {
        public string IPAddress = "127.0.0.1";
        public int Port = 50444;

        private string clientMessage;
        public FormSmpServer()
        {
            InitializeComponent();
        }

        public void RecordClientMessage(string clientMessage)
        {
            try
            {
                this.clientMessage = clientMessage;

                Invoke(new MethodInvoker(RecordClientMessage));
            }
            catch (Exception)
            {

            }
        }
        private void RecordClientMessage()
        {
            MessagesTextBox.AppendText(clientMessage + Environment.NewLine);

            StatusMessageTextbox.Text = "Message received: " + DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Server.Stop();
        }

        private void MessagesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessagesButton_Click(object sender, EventArgs e)
        {

        }

        private void StatusMessageTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
