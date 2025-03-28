﻿/*
 * Names: Kyle Downing and Ethan Griffith. 
 * Date: 3/16/25
 * Desc: Event handelers for server GUI.
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
using System.IO;
using System.Threading;
using System.Collections;

namespace SmpServer
{
    public partial class FormSmpServer : Form
    {
        private string messageStorePath = "MS.txt";
        public bool isActive = false;
        
        public string IPAddress = "127.0.0.1";
        public int Port = 50444;

        private string clientMessage;
        private int radio = -1;

        int lastMessagePriority;
        string lastMessageType;
        string consumedMessage;

        public FormSmpServer()
        {
            InitializeComponent();
        }

        public string RecordClientMessage(string clientMessage)
        {
            try
            {
                Console.WriteLine("Recieved Client Message: " + clientMessage);

                this.clientMessage = clientMessage;

                Invoke(new MethodInvoker(RecordClientMessage));

                if (this.clientMessage.Split(' ')[0] == "GET")
                {
                    return consumedMessage.Substring(2);
                } else if (this.clientMessage.Split(' ')[0] == "PUT")
                {
                    return "Received message: \"" + clientMessage.Substring(11) + "\": " + DateTime.Now;
                }
                return "Received message: " + DateTime.Now;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void RecordClientMessage()
        {
            TypeTextbox.Clear();
            lastMessageType = clientMessage.Split(' ')[0];
            PriorityTextbox.Clear();
            lastMessagePriority = Int32.Parse(clientMessage.Split(' ')[1]);
            PriorityTextbox.Text = IntToPriority(lastMessagePriority);
            TypeTextbox.Text = lastMessageType;
            if (lastMessageType == "GET")
            {
                ArrayList contents = new ArrayList();
                bool isConsumed = false;
                consumedMessage = "";
                using (StreamReader sr = new StreamReader(messageStorePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Length > 0)
                        {
                            if (Int32.Parse(line.Split(' ')[0]) != lastMessagePriority)
                            {
                                contents.Add(line);
                            }
                            else if (!isConsumed)
                            {
                                consumedMessage = line;
                                isConsumed = true;
                            }
                            else
                            {
                                contents.Add(line);
                            }
                        }
                    }
                    if (consumedMessage.Length == 0)
                    {
                        consumedMessage = "   <No messages with " + IntToPriority(lastMessagePriority) + " priority.>";
                    }
                }
                using (StreamWriter sw = new StreamWriter(messageStorePath))
                {
                    for (int i = 0; i < contents.Count; i++)
                    {
                        sw.WriteLine(contents[i].ToString());
                    }
                }
            } 
            else
            {
                string contents = clientMessage.Substring(10);
                using (StreamWriter sw = File.AppendText(messageStorePath))
                {
                    sw.WriteLine(lastMessagePriority + " " +  contents + Environment.NewLine);
                }
            }
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isActive) {
                    this.IPAddress = ServerIPTextbox.Text;
                    this.Port = Int32.Parse(PortTextbox.Text);
                    Console.WriteLine("Starting Server...");
                    ThreadPool.QueueUserWorkItem(Server.Start, this);
                    isActive = true;
                }
                else
                {
                    MessageBox.Show("Server is already active.");
                }
            } 
            catch
            {
                MessageBox.Show("Server start error...", "Server Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isActive) {
                Console.WriteLine("Ending Server");
                Server.Stop();
                isActive = false;
            }
        }

        private void MessagesButton_Click(object sender, EventArgs e)
        {
            if (radio == -1)
            {
                MessageBox.Show("Select a Priority option");
                return;
            }

            if (!File.Exists(messageStorePath)) {
                Console.WriteLine("Creating a new file...");
                var newFile = File.Create(messageStorePath);
                newFile.Close();
            }

            // Write all messages to the textbox that match the specified priority.
            string res = "";
            using (StreamReader sr = new StreamReader(messageStorePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null) {
                    if (line.Length > 0)
                    {
                        Console.WriteLine(line.Split(' ')[0].Trim());
                        int messagePriority = Int32.Parse(line.Split(' ')[0].Trim());

                        if (radio == messagePriority || radio == 3)
                        {
                            res = res + IntToPriority(messagePriority) + ": " + line.Substring(1) + Environment.NewLine;
                        }
                    }
                }
            }
            Console.WriteLine(res);
            MessagesTextBox.Text = res;
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radio = 3;
        }

        private void MessagesTextBox_TextChanged(object sender, EventArgs e) {
        }
        private void StatusMessageTextbox_TextChanged(object sender, EventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void ServerIPTextbox_TextChanged(object sender, EventArgs e) {}
        private void TypeTextbox_TextChanged(object sender, EventArgs e) {}

        private string IntToPriority(int value)
        {
            switch (value) {
                case 0:
                    return "Low";
                case 1:
                    return "Medium";
                case 2:
                    return "High";
                default:
                    return "None";
            }
        }

        private void PortTextbox_TextChanged(object sender, EventArgs e) { }
    }
}
