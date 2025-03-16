namespace SmpClientProducer
{
    partial class FormSmpClientProducer
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
            this.SettingsGroup = new System.Windows.Forms.GroupBox();
            this.ServerIPTextbox = new System.Windows.Forms.TextBox();
            this.AppPortTextbox = new System.Windows.Forms.TextBox();
            this.AppPortLabel = new System.Windows.Forms.Label();
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.MessageGroup = new System.Windows.Forms.GroupBox();
            this.PriorityGroup = new System.Windows.Forms.GroupBox();
            this.HighRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.LowRadioButton = new System.Windows.Forms.RadioButton();
            this.MessageContentLabel = new System.Windows.Forms.Label();
            this.MessagesTextbox = new System.Windows.Forms.TextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.ServerResponseLabel = new System.Windows.Forms.Label();
            this.ServerResponseTextbox = new System.Windows.Forms.TextBox();
            this.SettingsGroup.SuspendLayout();
            this.MessageGroup.SuspendLayout();
            this.PriorityGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsGroup
            // 
            this.SettingsGroup.Controls.Add(this.ServerIPTextbox);
            this.SettingsGroup.Controls.Add(this.AppPortTextbox);
            this.SettingsGroup.Controls.Add(this.AppPortLabel);
            this.SettingsGroup.Controls.Add(this.ServerIPLabel);
            this.SettingsGroup.Location = new System.Drawing.Point(19, 21);
            this.SettingsGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingsGroup.Name = "SettingsGroup";
            this.SettingsGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingsGroup.Size = new System.Drawing.Size(457, 54);
            this.SettingsGroup.TabIndex = 3;
            this.SettingsGroup.TabStop = false;
            this.SettingsGroup.Text = "Settings";
            // 
            // ServerIPTextbox
            // 
            this.ServerIPTextbox.Location = new System.Drawing.Point(100, 20);
            this.ServerIPTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServerIPTextbox.Name = "ServerIPTextbox";
            this.ServerIPTextbox.Size = new System.Drawing.Size(113, 20);
            this.ServerIPTextbox.TabIndex = 3;
            this.ServerIPTextbox.Text = "127.0.0.1";
            this.ServerIPTextbox.TextChanged += new System.EventHandler(this.ServerIPTextbox_TextChanged);
            // 
            // AppPortTextbox
            // 
            this.AppPortTextbox.Location = new System.Drawing.Point(340, 20);
            this.AppPortTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AppPortTextbox.Name = "AppPortTextbox";
            this.AppPortTextbox.Size = new System.Drawing.Size(91, 20);
            this.AppPortTextbox.TabIndex = 2;
            this.AppPortTextbox.Text = "50444";
            this.AppPortTextbox.TextChanged += new System.EventHandler(this.AppPortTextbox_TextChanged);
            // 
            // AppPortLabel
            // 
            this.AppPortLabel.AutoSize = true;
            this.AppPortLabel.Location = new System.Drawing.Point(215, 20);
            this.AppPortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppPortLabel.Name = "AppPortLabel";
            this.AppPortLabel.Size = new System.Drawing.Size(121, 13);
            this.AppPortLabel.TabIndex = 1;
            this.AppPortLabel.Text = "Application Port Number";
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(4, 20);
            this.ServerIPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(92, 13);
            this.ServerIPLabel.TabIndex = 0;
            this.ServerIPLabel.Text = "Server IP Address";
            // 
            // MessageGroup
            // 
            this.MessageGroup.Controls.Add(this.PriorityGroup);
            this.MessageGroup.Controls.Add(this.MessageContentLabel);
            this.MessageGroup.Controls.Add(this.MessagesTextbox);
            this.MessageGroup.Controls.Add(this.SendMessageButton);
            this.MessageGroup.Location = new System.Drawing.Point(19, 132);
            this.MessageGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MessageGroup.Name = "MessageGroup";
            this.MessageGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MessageGroup.Size = new System.Drawing.Size(457, 203);
            this.MessageGroup.TabIndex = 4;
            this.MessageGroup.TabStop = false;
            this.MessageGroup.Text = "Message";
            // 
            // PriorityGroup
            // 
            this.PriorityGroup.Controls.Add(this.HighRadioButton);
            this.PriorityGroup.Controls.Add(this.MediumRadioButton);
            this.PriorityGroup.Controls.Add(this.LowRadioButton);
            this.PriorityGroup.Location = new System.Drawing.Point(15, 32);
            this.PriorityGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriorityGroup.Name = "PriorityGroup";
            this.PriorityGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriorityGroup.Size = new System.Drawing.Size(100, 146);
            this.PriorityGroup.TabIndex = 3;
            this.PriorityGroup.TabStop = false;
            this.PriorityGroup.Text = "Priority";
            // 
            // HighRadioButton
            // 
            this.HighRadioButton.AutoSize = true;
            this.HighRadioButton.Location = new System.Drawing.Point(8, 110);
            this.HighRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.MediumRadioButton.Location = new System.Drawing.Point(8, 69);
            this.MediumRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.LowRadioButton.Location = new System.Drawing.Point(8, 31);
            this.LowRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LowRadioButton.Name = "LowRadioButton";
            this.LowRadioButton.Size = new System.Drawing.Size(45, 17);
            this.LowRadioButton.TabIndex = 0;
            this.LowRadioButton.TabStop = true;
            this.LowRadioButton.Text = "Low";
            this.LowRadioButton.UseVisualStyleBackColor = true;
            this.LowRadioButton.CheckedChanged += new System.EventHandler(this.LowRadioButton_CheckedChanged);
            // 
            // MessageContentLabel
            // 
            this.MessageContentLabel.AutoSize = true;
            this.MessageContentLabel.Location = new System.Drawing.Point(140, 14);
            this.MessageContentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageContentLabel.Name = "MessageContentLabel";
            this.MessageContentLabel.Size = new System.Drawing.Size(90, 13);
            this.MessageContentLabel.TabIndex = 2;
            this.MessageContentLabel.Text = "Message Content";
            // 
            // MessagesTextbox
            // 
            this.MessagesTextbox.Location = new System.Drawing.Point(143, 43);
            this.MessagesTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MessagesTextbox.Multiline = true;
            this.MessagesTextbox.Name = "MessagesTextbox";
            this.MessagesTextbox.Size = new System.Drawing.Size(298, 116);
            this.MessagesTextbox.TabIndex = 1;
            this.MessagesTextbox.TextChanged += new System.EventHandler(this.MessagesTextbox_TextChanged);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(143, 170);
            this.SendMessageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(297, 23);
            this.SendMessageButton.TabIndex = 0;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // ServerResponseLabel
            // 
            this.ServerResponseLabel.AutoSize = true;
            this.ServerResponseLabel.Location = new System.Drawing.Point(16, 99);
            this.ServerResponseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServerResponseLabel.Name = "ServerResponseLabel";
            this.ServerResponseLabel.Size = new System.Drawing.Size(86, 13);
            this.ServerResponseLabel.TabIndex = 5;
            this.ServerResponseLabel.Text = "ServerResponse";
            // 
            // ServerResponseTextbox
            // 
            this.ServerResponseTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServerResponseTextbox.Enabled = false;
            this.ServerResponseTextbox.Location = new System.Drawing.Point(119, 99);
            this.ServerResponseTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServerResponseTextbox.Name = "ServerResponseTextbox";
            this.ServerResponseTextbox.ReadOnly = true;
            this.ServerResponseTextbox.Size = new System.Drawing.Size(358, 20);
            this.ServerResponseTextbox.TabIndex = 6;
            this.ServerResponseTextbox.TextChanged += new System.EventHandler(this.ServerResponseTextbox_TextChanged);
            // 
            // FormSmpClientProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 343);
            this.Controls.Add(this.ServerResponseTextbox);
            this.Controls.Add(this.ServerResponseLabel);
            this.Controls.Add(this.MessageGroup);
            this.Controls.Add(this.SettingsGroup);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSmpClientProducer";
            this.Text = "SMP Client Producer";
            this.SettingsGroup.ResumeLayout(false);
            this.SettingsGroup.PerformLayout();
            this.MessageGroup.ResumeLayout(false);
            this.MessageGroup.PerformLayout();
            this.PriorityGroup.ResumeLayout(false);
            this.PriorityGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingsGroup;
        private System.Windows.Forms.TextBox ServerIPTextbox;
        private System.Windows.Forms.TextBox AppPortTextbox;
        private System.Windows.Forms.Label AppPortLabel;
        private System.Windows.Forms.Label ServerIPLabel;
        private System.Windows.Forms.GroupBox MessageGroup;
        private System.Windows.Forms.GroupBox PriorityGroup;
        private System.Windows.Forms.RadioButton HighRadioButton;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton LowRadioButton;
        private System.Windows.Forms.Label MessageContentLabel;
        private System.Windows.Forms.TextBox MessagesTextbox;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Label ServerResponseLabel;
        private System.Windows.Forms.TextBox ServerResponseTextbox;
    }
}

