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
            this.StatusMessageTextbox = new System.Windows.Forms.TextBox();
            this.MessagesButton = new System.Windows.Forms.Button();
            this.MessagesGroup = new System.Windows.Forms.GroupBox();
            this.LastRecievedMessageGroup = new System.Windows.Forms.GroupBox();
            this.SettingGroup = new System.Windows.Forms.GroupBox();
            this.PriorityGroup = new System.Windows.Forms.GroupBox();
            this.LowRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.HighRadioButton = new System.Windows.Forms.RadioButton();
            this.AllRadioButton = new System.Windows.Forms.RadioButton();
            this.ServerIPTextbox = new System.Windows.Forms.TextBox();
            this.PortTextbox = new System.Windows.Forms.TextBox();
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.MessageTypeTextbox = new System.Windows.Forms.Label();
            this.MessagePriorityTextbox = new System.Windows.Forms.Label();
            this.PriorityTextbox = new System.Windows.Forms.TextBox();
            this.TypeTextbox = new System.Windows.Forms.TextBox();
            this.MessagesGroup.SuspendLayout();
            this.LastRecievedMessageGroup.SuspendLayout();
            this.SettingGroup.SuspendLayout();
            this.PriorityGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(12, 12);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(165, 121);
            this.StartServerButton.TabIndex = 0;
            this.StartServerButton.Text = "Start Server";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessagesTextBox
            // 
            this.MessagesTextBox.Location = new System.Drawing.Point(187, 43);
            this.MessagesTextBox.Multiline = true;
            this.MessagesTextBox.Name = "MessagesTextBox";
            this.MessagesTextBox.Size = new System.Drawing.Size(354, 229);
            this.MessagesTextBox.TabIndex = 1;
            this.MessagesTextBox.TextChanged += new System.EventHandler(this.MessagesTextBox_TextChanged);
            // 
            // StatusMessageTextbox
            // 
            this.StatusMessageTextbox.Location = new System.Drawing.Point(6, 328);
            this.StatusMessageTextbox.Name = "StatusMessageTextbox";
            this.StatusMessageTextbox.Size = new System.Drawing.Size(238, 26);
            this.StatusMessageTextbox.TabIndex = 2;
            this.StatusMessageTextbox.TextChanged += new System.EventHandler(this.StatusMessageTextbox_TextChanged);
            // 
            // MessagesButton
            // 
            this.MessagesButton.Location = new System.Drawing.Point(323, 312);
            this.MessagesButton.Name = "MessagesButton";
            this.MessagesButton.Size = new System.Drawing.Size(166, 42);
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
            this.MessagesGroup.Location = new System.Drawing.Point(12, 237);
            this.MessagesGroup.Name = "MessagesGroup";
            this.MessagesGroup.Size = new System.Drawing.Size(568, 375);
            this.MessagesGroup.TabIndex = 4;
            this.MessagesGroup.TabStop = false;
            this.MessagesGroup.Text = "Messages";
            // 
            // LastRecievedMessageGroup
            // 
            this.LastRecievedMessageGroup.Controls.Add(this.TypeTextbox);
            this.LastRecievedMessageGroup.Controls.Add(this.PriorityTextbox);
            this.LastRecievedMessageGroup.Controls.Add(this.MessagePriorityTextbox);
            this.LastRecievedMessageGroup.Controls.Add(this.MessageTypeTextbox);
            this.LastRecievedMessageGroup.Location = new System.Drawing.Point(18, 140);
            this.LastRecievedMessageGroup.Name = "LastRecievedMessageGroup";
            this.LastRecievedMessageGroup.Size = new System.Drawing.Size(562, 91);
            this.LastRecievedMessageGroup.TabIndex = 5;
            this.LastRecievedMessageGroup.TabStop = false;
            this.LastRecievedMessageGroup.Text = "Last Recieved Message";
            // 
            // SettingGroup
            // 
            this.SettingGroup.Controls.Add(this.PortLabel);
            this.SettingGroup.Controls.Add(this.ServerIPLabel);
            this.SettingGroup.Controls.Add(this.PortTextbox);
            this.SettingGroup.Controls.Add(this.ServerIPTextbox);
            this.SettingGroup.Location = new System.Drawing.Point(199, 13);
            this.SettingGroup.Name = "SettingGroup";
            this.SettingGroup.Size = new System.Drawing.Size(381, 121);
            this.SettingGroup.TabIndex = 6;
            this.SettingGroup.TabStop = false;
            this.SettingGroup.Text = "Settings";
            // 
            // PriorityGroup
            // 
            this.PriorityGroup.Controls.Add(this.AllRadioButton);
            this.PriorityGroup.Controls.Add(this.HighRadioButton);
            this.PriorityGroup.Controls.Add(this.MediumRadioButton);
            this.PriorityGroup.Controls.Add(this.LowRadioButton);
            this.PriorityGroup.Location = new System.Drawing.Point(17, 43);
            this.PriorityGroup.Name = "PriorityGroup";
            this.PriorityGroup.Size = new System.Drawing.Size(148, 254);
            this.PriorityGroup.TabIndex = 4;
            this.PriorityGroup.TabStop = false;
            this.PriorityGroup.Text = "Priority";
            // 
            // LowRadioButton
            // 
            this.LowRadioButton.AutoSize = true;
            this.LowRadioButton.Location = new System.Drawing.Point(11, 54);
            this.LowRadioButton.Name = "LowRadioButton";
            this.LowRadioButton.Size = new System.Drawing.Size(63, 24);
            this.LowRadioButton.TabIndex = 0;
            this.LowRadioButton.TabStop = true;
            this.LowRadioButton.Text = "Low";
            this.LowRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(11, 102);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(90, 24);
            this.MediumRadioButton.TabIndex = 1;
            this.MediumRadioButton.TabStop = true;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // HighRadioButton
            // 
            this.HighRadioButton.AutoSize = true;
            this.HighRadioButton.Location = new System.Drawing.Point(11, 155);
            this.HighRadioButton.Name = "HighRadioButton";
            this.HighRadioButton.Size = new System.Drawing.Size(67, 24);
            this.HighRadioButton.TabIndex = 2;
            this.HighRadioButton.TabStop = true;
            this.HighRadioButton.Text = "High";
            this.HighRadioButton.UseVisualStyleBackColor = true;
            // 
            // AllRadioButton
            // 
            this.AllRadioButton.AutoSize = true;
            this.AllRadioButton.Location = new System.Drawing.Point(11, 205);
            this.AllRadioButton.Name = "AllRadioButton";
            this.AllRadioButton.Size = new System.Drawing.Size(51, 24);
            this.AllRadioButton.TabIndex = 3;
            this.AllRadioButton.TabStop = true;
            this.AllRadioButton.Text = "All";
            this.AllRadioButton.UseVisualStyleBackColor = true;
            this.AllRadioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // ServerIPTextbox
            // 
            this.ServerIPTextbox.Location = new System.Drawing.Point(158, 37);
            this.ServerIPTextbox.Name = "ServerIPTextbox";
            this.ServerIPTextbox.Size = new System.Drawing.Size(196, 26);
            this.ServerIPTextbox.TabIndex = 0;
            // 
            // PortTextbox
            // 
            this.PortTextbox.Location = new System.Drawing.Point(158, 80);
            this.PortTextbox.Name = "PortTextbox";
            this.PortTextbox.Size = new System.Drawing.Size(196, 26);
            this.PortTextbox.TabIndex = 1;
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(6, 37);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(137, 20);
            this.ServerIPLabel.TabIndex = 2;
            this.ServerIPLabel.Text = "Server IP Address";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(6, 83);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(98, 20);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port Number";
            // 
            // MessageTypeTextbox
            // 
            this.MessageTypeTextbox.AutoSize = true;
            this.MessageTypeTextbox.Location = new System.Drawing.Point(7, 43);
            this.MessageTypeTextbox.Name = "MessageTypeTextbox";
            this.MessageTypeTextbox.Size = new System.Drawing.Size(112, 20);
            this.MessageTypeTextbox.TabIndex = 3;
            this.MessageTypeTextbox.Text = "Message Type";
            // 
            // MessagePriorityTextbox
            // 
            this.MessagePriorityTextbox.AutoSize = true;
            this.MessagePriorityTextbox.Location = new System.Drawing.Point(267, 43);
            this.MessagePriorityTextbox.Name = "MessagePriorityTextbox";
            this.MessagePriorityTextbox.Size = new System.Drawing.Size(125, 20);
            this.MessagePriorityTextbox.TabIndex = 4;
            this.MessagePriorityTextbox.Text = "Message Priority";
            // 
            // PriorityTextbox
            // 
            this.PriorityTextbox.Location = new System.Drawing.Point(398, 40);
            this.PriorityTextbox.Name = "PriorityTextbox";
            this.PriorityTextbox.Size = new System.Drawing.Size(137, 26);
            this.PriorityTextbox.TabIndex = 5;
            this.PriorityTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TypeTextbox
            // 
            this.TypeTextbox.Location = new System.Drawing.Point(138, 40);
            this.TypeTextbox.Name = "TypeTextbox";
            this.TypeTextbox.Size = new System.Drawing.Size(123, 26);
            this.TypeTextbox.TabIndex = 6;
            // 
            // FormSmpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 624);
            this.Controls.Add(this.SettingGroup);
            this.Controls.Add(this.LastRecievedMessageGroup);
            this.Controls.Add(this.MessagesGroup);
            this.Controls.Add(this.StartServerButton);
            this.Name = "FormSmpServer";
            this.Text = "SMP Server";
            this.MessagesGroup.ResumeLayout(false);
            this.MessagesGroup.PerformLayout();
            this.LastRecievedMessageGroup.ResumeLayout(false);
            this.LastRecievedMessageGroup.PerformLayout();
            this.SettingGroup.ResumeLayout(false);
            this.SettingGroup.PerformLayout();
            this.PriorityGroup.ResumeLayout(false);
            this.PriorityGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.TextBox MessagesTextBox;
        private System.Windows.Forms.TextBox StatusMessageTextbox;
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
    }
}

