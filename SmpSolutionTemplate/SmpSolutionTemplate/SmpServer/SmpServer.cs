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
        // Filepath to the message store text file.
        private string messageStorePath = "serverMessageStore.txt";
        // Stores the active state of the server.
        public boolean isActive = false;
        
        public string IPAddress = "127.0.0.1";
        public int Port = 50444;
        private string clientMessage;

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
                Server.Start();
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

        // TODO: MessageTextBox -->> MessageTextBox. Unsure which UI element this relates to.
        private void MessagesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Show messages currently in the message store. Message store is FIFO.
        private void MessagesButton_Click(object sender, EventArgs e)
        {
            // Open a file stream to the file for reading or writing. Create is file DNE.
            FileStream file = new FileStream(messageStorePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // Read Radio button priority from form to filter message store entries.
            // TODO

            // Clear the textbox that will display the message store.
            StatusMessageTextbox.Text.Clear();

            // Read the file line by line and write to the StatusMessageTextbox.
            string line;
            while ((line = file.ReadLine()) != null) {
                // TODO: Filter message store entries based on matching priorities.
                StatusMessageTextbox.Text.AppendLine(line);
            }
        }

        // TODO: StatusMessageTextBox -->> StatusMessageTextbox. Unsure which UI element this relates to.
        private void StatusMessageTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        // TODO: RadioButton4 -->> 'all' option. What action triggers this?
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        // TODO: TextBox_1 -->> PriorityTextbox.
        private void textBox1_TextChanged(object sender, EventArgs e)
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
