namespace SmpServer
{
    partial class FormSmpServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartServerButton = new System.Windows.Forms.Button();
            this.MessagesTextBox = new System.Windows.Forms.TextBox();
            this.MessagesButton = new System.Windows.Forms.Button();
            this.MessagesGroup = new System.Windows.Forms.GroupBox();
            this.PriorityGroup = new System.Windows.Forms.GroupBox();
            this.AllRadioButton = new System.Windows.Forms.RadioButton();
            this.HighRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.LowRadioButton = new System.Windows.Forms.RadioButton();
            this.StatusMessageTextbox = new System.Windows.Forms.TextBox();
            this.LastRecievedMessageGroup = new System.Windows.Forms.GroupBox();
            this.TypeTextbox = new System.Windows.Forms.TextBox();
            this.PriorityTextbox = new System.Windows.Forms.TextBox();
            this.MessagePriorityTextbox = new System.Windows.Forms.Label();
            this.MessageTypeTextbox = new System.Windows.Forms.Label();
            this.SettingGroup = new System.Windows.Forms.GroupBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.PortTextbox = new System.Windows.Forms.TextBox();
            this.ServerIPTextbox = new System.Windows.Forms.TextBox();
            this.MessagesGroup.SuspendLayout();
            this.PriorityGroup.SuspendLayout();
            this.LastRecievedMessageGroup.SuspendLayout();
            this.SettingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(8, 8);
            this.StartServerButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(110, 79);
            this.StartServerButton.TabIndex = 0;
            this.StartServerButton.Text = "Start Server";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // MessagesTextBox
            // 
            this.MessagesTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessagesTextBox.Enabled = false;
            this.MessagesTextBox.Location = new System.Drawing.Point(125, 28);
            this.MessagesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MessagesTextBox.Multiline = true;
            this.MessagesTextBox.Name = "MessagesTextBox";
            this.MessagesTextBox.ReadOnly = true;
            this.MessagesTextBox.Size = new System.Drawing.Size(237, 150);
            this.MessagesTextBox.TabIndex = 1;
            this.MessagesTextBox.TextChanged += new System.EventHandler(this.MessagesTextBox_TextChanged);
            // 
            // MessagesButton
            // 
            this.MessagesButton.Location = new System.Drawing.Point(215, 203);
            this.MessagesButton.Margin = new System.Windows.Forms.Padding(2);
            this.MessagesButton.Name = "MessagesButton";
            this.MessagesButton.Size = new System.Drawing.Size(111, 27);
            this.MessagesButton.TabIndex = 3;
            this.MessagesButton.Text = "Show Messages";
            this.MessagesButton.UseVisualStyleBackColor = true;
            this.MessagesButton.Click += new System.EventHandler(this.MessagesButton_Click);
            // 
            // MessagesGroup
            // 
            this.MessagesGroup.Controls.Add(this.PriorityGroup);
            this.MessagesGroup.Controls.Add(this.MessagesTextBox);
            this.MessagesGroup.Controls.Add(this.StatusMessageTextbox);
            this.MessagesGroup.Controls.Add(this.MessagesButton);
            this.MessagesGroup.Location = new System.Drawing.Point(8, 154);
            this.MessagesGroup.Margin = new System.Windows.Forms.Padding(2);
            this.MessagesGroup.Name = "MessagesGroup";
            this.MessagesGroup.Padding = new System.Windows.Forms.Padding(2);
            this.MessagesGroup.Size = new System.Drawing.Size(379, 244);
            this.MessagesGroup.TabIndex = 4;
            this.MessagesGroup.TabStop = false;
            this.MessagesGroup.Text = "Messages";
            // 
            // PriorityGroup
            // 
            this.PriorityGroup.Controls.Add(this.AllRadioButton);
            this.PriorityGroup.Controls.Add(this.HighRadioButton);
            this.PriorityGroup.Controls.Add(this.MediumRadioButton);
            this.PriorityGroup.Controls.Add(this.LowRadioButton);
            this.PriorityGroup.Location = new System.Drawing.Point(11, 28);
            this.PriorityGroup.Margin = new System.Windows.Forms.Padding(2);
            this.PriorityGroup.Name = "PriorityGroup";
            this.PriorityGroup.Padding = new System.Windows.Forms.Padding(2);
            this.PriorityGroup.Size = new System.Drawing.Size(99, 165);
            this.PriorityGroup.TabIndex = 4;
            this.PriorityGroup.TabStop = false;
            this.PriorityGroup.Text = "Priority";
            // 
            // AllRadioButton
            // 
            this.AllRadioButton.AutoSize = true;
            this.AllRadioButton.Location = new System.Drawing.Point(7, 133);
            this.AllRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.AllRadioButton.Name = "AllRadioButton";
            this.AllRadioButton.Size = new System.Drawing.Size(36, 17);
            this.AllRadioButton.TabIndex = 3;
            this.AllRadioButton.TabStop = true;
            this.AllRadioButton.Text = "All";
            this.AllRadioButton.UseVisualStyleBackColor = true;
            this.AllRadioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // HighRadioButton
            // 
            this.HighRadioButton.AutoSize = true;
            this.HighRadioButton.Location = new System.Drawing.Point(7, 101);
            this.HighRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.HighRadioButton.Name = "HighRadioButton";
            this.HighRadioButton.Size = new System.Drawing.Size(47, 17);
            this.HighRadioButton.TabIndex = 2;
            this.HighRadioButton.TabStop = true;
            this.HighRadioButton.Text = "High";
            this.HighRadioButton.UseVisualStyleBackColor = true;
            this.HighRadioButton.CheckedChanged += new System.EventHandler(this.HighRadioButton_CheckedChanged);
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(7, 66);
            this.MediumRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.MediumRadioButton.TabIndex = 1;
            this.MediumRadioButton.TabStop = true;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            this.MediumRadioButton.CheckedChanged += new System.EventHandler(this.MediumRadioButton_CheckedChanged);
            // 
            // LowRadioButton
            // 
            this.LowRadioButton.AutoSize = true;
            this.LowRadioButton.Location = new System.Drawing.Point(7, 35);
            this.LowRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.LowRadioButton.Name = "LowRadioButton";
            this.LowRadioButton.Size = new System.Drawing.Size(45, 17);
            this.LowRadioButton.TabIndex = 0;
            this.LowRadioButton.TabStop = true;
            this.LowRadioButton.Text = "Low";
            this.LowRadioButton.UseVisualStyleBackColor = true;
            this.LowRadioButton.CheckedChanged += new System.EventHandler(this.LowRadioButton_CheckedChanged);
            // 
            // StatusMessageTextbox
            // 
            this.StatusMessageTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StatusMessageTextbox.Enabled = false;
            this.StatusMessageTextbox.Location = new System.Drawing.Point(4, 213);
            this.StatusMessageTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.StatusMessageTextbox.Name = "StatusMessageTextbox";
            this.StatusMessageTextbox.ReadOnly = true;
            this.StatusMessageTextbox.Size = new System.Drawing.Size(160, 20);
            this.StatusMessageTextbox.TabIndex = 2;
            this.StatusMessageTextbox.TextChanged += new System.EventHandler(this.StatusMessageTextbox_TextChanged);
            // 
            // LastRecievedMessageGroup
            // 
            this.LastRecievedMessageGroup.Controls.Add(this.TypeTextbox);
            this.LastRecievedMessageGroup.Controls.Add(this.PriorityTextbox);
            this.LastRecievedMessageGroup.Controls.Add(this.MessagePriorityTextbox);
            this.LastRecievedMessageGroup.Controls.Add(this.MessageTypeTextbox);
            this.LastRecievedMessageGroup.Location = new System.Drawing.Point(12, 91);
            this.LastRecievedMessageGroup.Margin = new System.Windows.Forms.Padding(2);
            this.LastRecievedMessageGroup.Name = "LastRecievedMessageGroup";
            this.LastRecievedMessageGroup.Padding = new System.Windows.Forms.Padding(2);
            this.LastRecievedMessageGroup.Size = new System.Drawing.Size(375, 59);
            this.LastRecievedMessageGroup.TabIndex = 5;
            this.LastRecievedMessageGroup.TabStop = false;
            this.LastRecievedMessageGroup.Text = "Last Recieved Message";
            // 
            // TypeTextbox
            // 
            this.TypeTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TypeTextbox.Enabled = false;
            this.TypeTextbox.Location = new System.Drawing.Point(92, 26);
            this.TypeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.TypeTextbox.Name = "TypeTextbox";
            this.TypeTextbox.ReadOnly = true;
            this.TypeTextbox.Size = new System.Drawing.Size(83, 20);
            this.TypeTextbox.TabIndex = 6;
            this.TypeTextbox.TextChanged += new System.EventHandler(this.TypeTextbox_TextChanged);
            // 
            // PriorityTextbox
            // 
            this.PriorityTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriorityTextbox.Enabled = false;
            this.PriorityTextbox.Location = new System.Drawing.Point(265, 26);
            this.PriorityTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.PriorityTextbox.Name = "PriorityTextbox";
            this.PriorityTextbox.ReadOnly = true;
            this.PriorityTextbox.Size = new System.Drawing.Size(93, 20);
            this.PriorityTextbox.TabIndex = 5;
            this.PriorityTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MessagePriorityTextbox
            // 
            this.MessagePriorityTextbox.AutoSize = true;
            this.MessagePriorityTextbox.Location = new System.Drawing.Point(178, 28);
            this.MessagePriorityTextbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessagePriorityTextbox.Name = "MessagePriorityTextbox";
            this.MessagePriorityTextbox.Size = new System.Drawing.Size(84, 13);
            this.MessagePriorityTextbox.TabIndex = 4;
            this.MessagePriorityTextbox.Text = "Message Priority";
            // 
            // MessageTypeTextbox
            // 
            this.MessageTypeTextbox.AutoSize = true;
            this.MessageTypeTextbox.Location = new System.Drawing.Point(5, 28);
            this.MessageTypeTextbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageTypeTextbox.Name = "MessageTypeTextbox";
            this.MessageTypeTextbox.Size = new System.Drawing.Size(77, 13);
            this.MessageTypeTextbox.TabIndex = 3;
            this.MessageTypeTextbox.Text = "Message Type";
            // 
            // SettingGroup
            // 
            this.SettingGroup.Controls.Add(this.PortLabel);
            this.SettingGroup.Controls.Add(this.ServerIPLabel);
            this.SettingGroup.Controls.Add(this.PortTextbox);
            this.SettingGroup.Controls.Add(this.ServerIPTextbox);
            this.SettingGroup.Location = new System.Drawing.Point(133, 8);
            this.SettingGroup.Margin = new System.Windows.Forms.Padding(2);
            this.SettingGroup.Name = "SettingGroup";
            this.SettingGroup.Padding = new System.Windows.Forms.Padding(2);
            this.SettingGroup.Size = new System.Drawing.Size(254, 79);
            this.SettingGroup.TabIndex = 6;
            this.SettingGroup.TabStop = false;
            this.SettingGroup.Text = "Settings";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(4, 54);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(66, 13);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port Number";
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(4, 24);
            this.ServerIPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(92, 13);
            this.ServerIPLabel.TabIndex = 2;
            this.ServerIPLabel.Text = "Server IP Address";
            // 
            // PortTextbox
            // 
            this.PortTextbox.Location = new System.Drawing.Point(105, 52);
            this.PortTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.PortTextbox.Name = "PortTextbox";
            this.PortTextbox.Size = new System.Drawing.Size(132, 20);
            this.PortTextbox.TabIndex = 1;
            this.PortTextbox.Text = "50444";
            this.PortTextbox.TextChanged += new System.EventHandler(this.PortTextbox_TextChanged);
            // 
            // ServerIPTextbox
            // 
            this.ServerIPTextbox.Location = new System.Drawing.Point(105, 24);
            this.ServerIPTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.ServerIPTextbox.Name = "ServerIPTextbox";
            this.ServerIPTextbox.Size = new System.Drawing.Size(132, 20);
            this.ServerIPTextbox.TabIndex = 0;
            this.ServerIPTextbox.Text = "127.0.0.1";
            this.ServerIPTextbox.TextChanged += new System.EventHandler(this.ServerIPTextbox_TextChanged);
            // 
            // FormSmpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 406);
            this.Controls.Add(this.SettingGroup);
            this.Controls.Add(this.LastRecievedMessageGroup);
            this.Controls.Add(this.MessagesGroup);
            this.Controls.Add(this.StartServerButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSmpServer";
            this.Text = "SMP Server";
            this.MessagesGroup.ResumeLayout(false);
            this.MessagesGroup.PerformLayout();
            this.PriorityGroup.ResumeLayout(false);
            this.PriorityGroup.PerformLayout();
            this.LastRecievedMessageGroup.ResumeLayout(false);
            this.LastRecievedMessageGroup.PerformLayout();
            this.SettingGroup.ResumeLayout(false);
            this.SettingGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.TextBox MessagesTextBox;
        private System.Windows.Forms.Button MessagesButton;
        private System.Windows.Forms.GroupBox MessagesGroup;
        private System.Windows.Forms.GroupBox PriorityGroup;
        private System.Windows.Forms.GroupBox LastRecievedMessageGroup;
        private System.Windows.Forms.GroupBox SettingGroup;
        private System.Windows.Forms.RadioButton AllRadioButton;
        private System.Windows.Forms.RadioButton HighRadioButton;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton LowRadioButton;
        private System.Windows.Forms.TextBox TypeTextbox;
        private System.Windows.Forms.TextBox PriorityTextbox;
        private System.Windows.Forms.Label MessagePriorityTextbox;
        private System.Windows.Forms.Label MessageTypeTextbox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label ServerIPLabel;
        private System.Windows.Forms.TextBox PortTextbox;
        private System.Windows.Forms.TextBox ServerIPTextbox;
        private System.Windows.Forms.TextBox StatusMessageTextbox;
    }
}

