namespace ExternalEmailWarning
{
    partial class SecureEmailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstEmailAddresses = new System.Windows.Forms.ListBox();
            this.btnSendSecure = new System.Windows.Forms.Button();
            this.btnSendNormal = new System.Windows.Forms.Button();
            this.btnDoNotSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "This email is not configured to be sent securely and will be sent outside of the " +
    "company to:";
            // 
            // lstEmailAddresses
            // 
            this.lstEmailAddresses.FormattingEnabled = true;
            this.lstEmailAddresses.Location = new System.Drawing.Point(18, 46);
            this.lstEmailAddresses.Name = "lstEmailAddresses";
            this.lstEmailAddresses.Size = new System.Drawing.Size(348, 82);
            this.lstEmailAddresses.TabIndex = 1;
            // 
            // btnSendSecure
            // 
            this.btnSendSecure.Location = new System.Drawing.Point(18, 164);
            this.btnSendSecure.Name = "btnSendSecure";
            this.btnSendSecure.Size = new System.Drawing.Size(112, 43);
            this.btnSendSecure.TabIndex = 2;
            this.btnSendSecure.Text = "Send Secure";
            this.btnSendSecure.UseVisualStyleBackColor = true;
            this.btnSendSecure.Click += new System.EventHandler(this.btnSendSecure_Click);
            // 
            // btnSendNormal
            // 
            this.btnSendNormal.Location = new System.Drawing.Point(136, 164);
            this.btnSendNormal.Name = "btnSendNormal";
            this.btnSendNormal.Size = new System.Drawing.Size(112, 43);
            this.btnSendNormal.TabIndex = 3;
            this.btnSendNormal.Text = "Send Normal";
            this.btnSendNormal.UseVisualStyleBackColor = true;
            this.btnSendNormal.Click += new System.EventHandler(this.btnSendNormal_Click);
            // 
            // btnDoNotSend
            // 
            this.btnDoNotSend.Location = new System.Drawing.Point(254, 164);
            this.btnDoNotSend.Name = "btnDoNotSend";
            this.btnDoNotSend.Size = new System.Drawing.Size(112, 43);
            this.btnDoNotSend.TabIndex = 4;
            this.btnDoNotSend.Text = "Do Not Send";
            this.btnDoNotSend.UseVisualStyleBackColor = true;
            this.btnDoNotSend.Click += new System.EventHandler(this.btnDoNotSend_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "How do you wish to proceed?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecureEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoNotSend);
            this.Controls.Add(this.btnSendNormal);
            this.Controls.Add(this.btnSendSecure);
            this.Controls.Add(this.lstEmailAddresses);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SecureEmailForm";
            this.Text = "Secure Email Warning";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEmailAddresses;
        private System.Windows.Forms.Button btnSendSecure;
        private System.Windows.Forms.Button btnSendNormal;
        private System.Windows.Forms.Button btnDoNotSend;
        private System.Windows.Forms.Label label2;
    }
}