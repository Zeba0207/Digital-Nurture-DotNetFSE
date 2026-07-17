namespace KafkaChatClient
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            rtbMessages = new RichTextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();

            // rtbMessages
            rtbMessages.Location = new Point(12, 12);
            rtbMessages.Name = "rtbMessages";
            rtbMessages.Size = new Size(560, 300);
            rtbMessages.TabIndex = 0;
            rtbMessages.Text = "";

            // txtMessage
            txtMessage.Location = new Point(12, 325);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(450, 27);
            txtMessage.TabIndex = 1;

            // btnSend
            btnSend.Location = new Point(480, 323);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(92, 29);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 380);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(rtbMessages);
            Name = "Form1";
            Text = "Kafka Chat Client";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbMessages;
        private TextBox txtMessage;
        private Button btnSend;
    }
}