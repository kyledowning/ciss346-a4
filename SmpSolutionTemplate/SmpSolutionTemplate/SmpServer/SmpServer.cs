using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmpServer
{
    public partial class FormSmpServer : Form
    {
        // Filepath to the message store text file.
        private string messageStorePath = "serverMessageStore.txt";
        // Stores the active state of the server.
        public bool isActive = false;
        
        public string IPAddress = "127.0.0.1";
        public int Port = 50444;

        private string clientMessage;
        private int radio;

        // Called from Program.cs. Initalizes the Server form.
        public FormSmpServer()
        {
            InitializeComponent();
        }

        // Called from Server.cs to handle client requests.
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

        // Called from RecoreClientMessage.
        private void RecordClientMessage()
        {
            MessagesTextBox.AppendText(clientMessage + Environment.NewLine);
            StatusMessageTextbox.Text = "Message received: " + DateTime.Now;
        }

        // Button1 is 'Start Server'. Calls Server.start().
        private void StartServerButton_Click(object sender, EventArgs e)
        {
            if (!isActive) {
                Server.Start(this);
                isActive = true;
            }
        }

        // Close the server is it is currenlty active. Should be called when exiting the application.
        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isActive) {
                Server.Stop();
                isActive = false;
            }
        }


        // Show messages currently in the message store. Message store is FIFO.
        private void MessagesButton_Click(object sender, EventArgs e)
        {
            // Open a file stream to the file for reading or writing. Create is file DNE.

            if (!File.Exists(messageStorePath)) {
                File.Create(messageStorePath);
            }

            StreamReader sr = new StreamReader(messageStorePath);
            string response = "";
            string line = sr.ReadLine();
            
            while (line != null) {
                // Each line in the Message store that is of the correct priority.
                if (radio == 3 || Int32.Parse(line.Split(' ')[0]) == radio) {
                    response += line;
                }
                line = sr.ReadLine();
            }
            this.MessagesTextBox.Text = response;
        }


        // TODO: MessageTextBox -->> MessageTextBox. Unsure which UI element this relates to.
        private void MessagesTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        // TODO: StatusMessageTextBox -->> StatusMessageTextbox. Unsure which UI element this relates to.
        private void StatusMessageTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        // TODO: TextBox_1 -->> PriorityTextbox.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // Radio Button Listeners should record radio button changes in Radio variable.
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radio = 3;
        }

    }
}
