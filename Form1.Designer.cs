namespace Steam_Scam_Baiter
{
    partial class Form1
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
            this.webhookTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.payloadTextBox = new System.Windows.Forms.TextBox();
            this.sendPayload = new System.Windows.Forms.Button();
            this.generatePayload = new System.Windows.Forms.Button();
            this.nukeWebhook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webhookTextBox
            // 
            this.webhookTextBox.Location = new System.Drawing.Point(100, 6);
            this.webhookTextBox.Name = "webhookTextBox";
            this.webhookTextBox.Size = new System.Drawing.Size(301, 20);
            this.webhookTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Webhook URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payload:";
            // 
            // payloadTextBox
            // 
            this.payloadTextBox.Location = new System.Drawing.Point(66, 36);
            this.payloadTextBox.MaxLength = 1999;
            this.payloadTextBox.Multiline = true;
            this.payloadTextBox.Name = "payloadTextBox";
            this.payloadTextBox.Size = new System.Drawing.Size(335, 236);
            this.payloadTextBox.TabIndex = 3;
            // 
            // sendPayload
            // 
            this.sendPayload.Location = new System.Drawing.Point(326, 278);
            this.sendPayload.Name = "sendPayload";
            this.sendPayload.Size = new System.Drawing.Size(75, 48);
            this.sendPayload.TabIndex = 4;
            this.sendPayload.Text = "Send Payload";
            this.sendPayload.UseVisualStyleBackColor = true;
            this.sendPayload.Click += new System.EventHandler(this.sendPayload_Click);
            // 
            // generatePayload
            // 
            this.generatePayload.Location = new System.Drawing.Point(245, 278);
            this.generatePayload.Name = "generatePayload";
            this.generatePayload.Size = new System.Drawing.Size(75, 48);
            this.generatePayload.TabIndex = 5;
            this.generatePayload.Text = "Generate Payload";
            this.generatePayload.UseVisualStyleBackColor = true;
            this.generatePayload.Click += new System.EventHandler(this.generatePayload_Click);
            // 
            // nukeWebhook
            // 
            this.nukeWebhook.Location = new System.Drawing.Point(164, 278);
            this.nukeWebhook.Name = "nukeWebhook";
            this.nukeWebhook.Size = new System.Drawing.Size(75, 48);
            this.nukeWebhook.TabIndex = 6;
            this.nukeWebhook.Text = "Delete Webhook";
            this.nukeWebhook.UseVisualStyleBackColor = true;
            this.nukeWebhook.Click += new System.EventHandler(this.nukeWebhook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 335);
            this.Controls.Add(this.nukeWebhook);
            this.Controls.Add(this.generatePayload);
            this.Controls.Add(this.sendPayload);
            this.Controls.Add(this.payloadTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webhookTextBox);
            this.Name = "Form1";
            this.Text = "Steam Scam Baiter by KingsleydotDev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox webhookTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox payloadTextBox;
        private System.Windows.Forms.Button sendPayload;
        private System.Windows.Forms.Button generatePayload;
        private System.Windows.Forms.Button nukeWebhook;
    }
}

