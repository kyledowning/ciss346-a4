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
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.MessagesTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(72, 36);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(206, 106);
            this.SendMessageButton.TabIndex = 0;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // MessagesTextbox
            // 
            this.MessagesTextbox.Location = new System.Drawing.Point(72, 218);
            this.MessagesTextbox.Multiline = true;
            this.MessagesTextbox.Name = "MessagesTextbox";
            this.MessagesTextbox.Size = new System.Drawing.Size(253, 154);
            this.MessagesTextbox.TabIndex = 1;
            this.MessagesTextbox.TextChanged += new System.EventHandler(this.MessagesTextbox_TextChanged);
            // 
            // FormSmpClientConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.MessagesTextbox);
            this.Controls.Add(this.SendMessageButton);
            this.Name = "FormSmpClientConsumer";
            this.Text = "SMP Client Consumer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.TextBox MessagesTextbox;
    }
}

