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
            this.MessagesTextBox.Location = new System.Drawing.Point(48, 179);
            this.MessagesTextBox.Multiline = true;
            this.MessagesTextBox.Name = "MessagesTextBox";
            this.MessagesTextBox.Size = new System.Drawing.Size(426, 209);
            this.MessagesTextBox.TabIndex = 1;
            this.MessagesTextBox.TextChanged += new System.EventHandler(this.MessagesTextBox_TextChanged);
            // 
            // StatusMessageTextbox
            // 
            this.StatusMessageTextbox.Location = new System.Drawing.Point(36, 412);
            this.StatusMessageTextbox.Name = "StatusMessageTextbox";
            this.StatusMessageTextbox.Size = new System.Drawing.Size(438, 26);
            this.StatusMessageTextbox.TabIndex = 2;
            // 
            // FormSmpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusMessageTextbox);
            this.Controls.Add(this.MessagesTextBox);
            this.Controls.Add(this.StartServerButton);
            this.Name = "FormSmpServer";
            this.Text = "SMP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.TextBox MessagesTextBox;
        private System.Windows.Forms.TextBox StatusMessageTextbox;
    }
}

