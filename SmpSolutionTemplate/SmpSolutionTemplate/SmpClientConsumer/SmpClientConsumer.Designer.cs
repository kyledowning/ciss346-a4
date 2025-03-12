namespace SmpClientConsumer
{
    partial class FormSmpClientConsumer
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
            this.GetMessageButton = new System.Windows.Forms.Button();
            this.MessagesTextbox = new System.Windows.Forms.TextBox();
            this.SettingsGroup = new System.Windows.Forms.GroupBox();
            this.MessageGroup = new System.Windows.Forms.GroupBox();
            this.MessageContentLabel = new System.Windows.Forms.Label();
            this.PriorityGroup = new System.Windows.Forms.GroupBox();
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.AppPortLabel = new System.Windows.Forms.Label();
            this.AppPortTextbox = new System.Windows.Forms.TextBox();
            this.ServerIPTextbox = new System.Windows.Forms.TextBox();
            this.LowRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.HighRadioButton = new System.Windows.Forms.RadioButton();
            this.SettingsGroup.SuspendLayout();
            this.MessageGroup.SuspendLayout();
            this.PriorityGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetMessageButton
            // 
            this.GetMessageButton.Location = new System.Drawing.Point(214, 262);
            this.GetMessageButton.Name = "GetMessageButton";
            this.GetMessageButton.Size = new System.Drawing.Size(445, 35);
            this.GetMessageButton.TabIndex = 0;
            this.GetMessageButton.Text = "Get Message";
            this.GetMessageButton.UseVisualStyleBackColor = true;
            this.GetMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // MessagesTextbox
            // 
            this.MessagesTextbox.Location = new System.Drawing.Point(214, 66);
            this.MessagesTextbox.Multiline = true;
            this.MessagesTextbox.Name = "MessagesTextbox";
            this.MessagesTextbox.Size = new System.Drawing.Size(445, 177);
            this.MessagesTextbox.TabIndex = 1;
            this.MessagesTextbox.TextChanged += new System.EventHandler(this.MessagesTextbox_TextChanged);
            // 
            // SettingsGroup
            // 
            this.SettingsGroup.Controls.Add(this.ServerIPTextbox);
            this.SettingsGroup.Controls.Add(this.AppPortTextbox);
            this.SettingsGroup.Controls.Add(this.AppPortLabel);
            this.SettingsGroup.Controls.Add(this.ServerIPLabel);
            this.SettingsGroup.Location = new System.Drawing.Point(33, 24);
            this.SettingsGroup.Name = "SettingsGroup";
            this.SettingsGroup.Size = new System.Drawing.Size(685, 83);
            this.SettingsGroup.TabIndex = 2;
            this.SettingsGroup.TabStop = false;
            this.SettingsGroup.Text = "Settings";
            // 
            // MessageGroup
            // 
            this.MessageGroup.Controls.Add(this.PriorityGroup);
            this.MessageGroup.Controls.Add(this.MessageContentLabel);
            this.MessageGroup.Controls.Add(this.MessagesTextbox);
            this.MessageGroup.Controls.Add(this.GetMessageButton);
            this.MessageGroup.Location = new System.Drawing.Point(33, 126);
            this.MessageGroup.Name = "MessageGroup";
            this.MessageGroup.Size = new System.Drawing.Size(685, 313);
            this.MessageGroup.TabIndex = 3;
            this.MessageGroup.TabStop = false;
            this.MessageGroup.Text = "Message";
            // 
            // MessageContentLabel
            // 
            this.MessageContentLabel.AutoSize = true;
            this.MessageContentLabel.Location = new System.Drawing.Point(210, 22);
            this.MessageContentLabel.Name = "MessageContentLabel";
            this.MessageContentLabel.Size = new System.Drawing.Size(135, 20);
            this.MessageContentLabel.TabIndex = 2;
            this.MessageContentLabel.Text = "Message Content";
            // 
            // PriorityGroup
            // 
            this.PriorityGroup.Controls.Add(this.HighRadioButton);
            this.PriorityGroup.Controls.Add(this.MediumRadioButton);
            this.PriorityGroup.Controls.Add(this.LowRadioButton);
            this.PriorityGroup.Location = new System.Drawing.Point(22, 50);
            this.PriorityGroup.Name = "PriorityGroup";
            this.PriorityGroup.Size = new System.Drawing.Size(150, 237);
            this.PriorityGroup.TabIndex = 3;
            this.PriorityGroup.TabStop = false;
            this.PriorityGroup.Text = "Priority";
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(6, 31);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(137, 20);
            this.ServerIPLabel.TabIndex = 0;
            this.ServerIPLabel.Text = "Server IP Address";
            // 
            // AppPortLabel
            // 
            this.AppPortLabel.AutoSize = true;
            this.AppPortLabel.Location = new System.Drawing.Point(323, 31);
            this.AppPortLabel.Name = "AppPortLabel";
            this.AppPortLabel.Size = new System.Drawing.Size(180, 20);
            this.AppPortLabel.TabIndex = 1;
            this.AppPortLabel.Text = "Application Port Number";
            this.AppPortLabel.Click += new System.EventHandler(this.AppPortLabel_Click);
            // 
            // AppPortTextbox
            // 
            this.AppPortTextbox.Location = new System.Drawing.Point(510, 31);
            this.AppPortTextbox.Name = "AppPortTextbox";
            this.AppPortTextbox.Size = new System.Drawing.Size(134, 26);
            this.AppPortTextbox.TabIndex = 2;
            // 
            // ServerIPTextbox
            // 
            this.ServerIPTextbox.Location = new System.Drawing.Point(150, 30);
            this.ServerIPTextbox.Name = "ServerIPTextbox";
            this.ServerIPTextbox.Size = new System.Drawing.Size(167, 26);
            this.ServerIPTextbox.TabIndex = 3;
            // 
            // LowRadioButton
            // 
            this.LowRadioButton.AutoSize = true;
            this.LowRadioButton.Location = new System.Drawing.Point(12, 47);
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
            this.MediumRadioButton.Location = new System.Drawing.Point(12, 106);
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
            this.HighRadioButton.Location = new System.Drawing.Point(12, 169);
            this.HighRadioButton.Name = "HighRadioButton";
            this.HighRadioButton.Size = new System.Drawing.Size(67, 24);
            this.HighRadioButton.TabIndex = 2;
            this.HighRadioButton.TabStop = true;
            this.HighRadioButton.Text = "High";
            this.HighRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormSmpClientConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 470);
            this.Controls.Add(this.MessageGroup);
            this.Controls.Add(this.SettingsGroup);
            this.Name = "FormSmpClientConsumer";
            this.Text = "SMP Client Consumer";
            this.SettingsGroup.ResumeLayout(false);
            this.SettingsGroup.PerformLayout();
            this.MessageGroup.ResumeLayout(false);
            this.MessageGroup.PerformLayout();
            this.PriorityGroup.ResumeLayout(false);
            this.PriorityGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetMessageButton;
        private System.Windows.Forms.TextBox MessagesTextbox;
        private System.Windows.Forms.GroupBox SettingsGroup;
        private System.Windows.Forms.GroupBox MessageGroup;
        private System.Windows.Forms.Label MessageContentLabel;
        private System.Windows.Forms.Label AppPortLabel;
        private System.Windows.Forms.Label ServerIPLabel;
        private System.Windows.Forms.GroupBox PriorityGroup;
        private System.Windows.Forms.TextBox ServerIPTextbox;
        private System.Windows.Forms.TextBox AppPortTextbox;
        private System.Windows.Forms.RadioButton HighRadioButton;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton LowRadioButton;
    }
}

