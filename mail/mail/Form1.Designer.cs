namespace mail
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
            this.btnSend = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.labelSmtp = new System.Windows.Forms.Label();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.txtCC = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(479, 56);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(106, 26);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.chkSSL);
            this.Setting.Controls.Add(this.labelSmtp);
            this.Setting.Controls.Add(this.txtSmtp);
            this.Setting.Controls.Add(this.labelPort);
            this.Setting.Controls.Add(this.txtPort);
            this.Setting.Controls.Add(this.btnSend);
            this.Setting.Controls.Add(this.txtUsername);
            this.Setting.Controls.Add(this.label1);
            this.Setting.Controls.Add(this.label3);
            this.Setting.Controls.Add(this.txtPassword);
            this.Setting.Location = new System.Drawing.Point(39, 332);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(599, 164);
            this.Setting.TabIndex = 2;
            this.Setting.TabStop = false;
            this.Setting.Text = "Settings";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(115, 13);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(327, 29);
            this.txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "User name : ";
            // 
            // txtTo
            // 
            this.txtTo.AutoSize = true;
            this.txtTo.Location = new System.Drawing.Point(52, 26);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(45, 21);
            this.txtTo.TabIndex = 0;
            this.txtTo.Text = "To : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(466, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(327, 29);
            this.txtPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Message : ";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(158, 189);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(466, 137);
            this.txtMessage.TabIndex = 3;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(9, 91);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(56, 21);
            this.labelPort.TabIndex = 10;
            this.labelPort.Text = "Port : ";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(115, 88);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(92, 29);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "508";
            // 
            // labelSmtp
            // 
            this.labelSmtp.AutoSize = true;
            this.labelSmtp.Location = new System.Drawing.Point(258, 91);
            this.labelSmtp.Name = "labelSmtp";
            this.labelSmtp.Size = new System.Drawing.Size(64, 21);
            this.labelSmtp.TabIndex = 12;
            this.labelSmtp.Text = "Smtp : ";
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(350, 88);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(235, 29);
            this.txtSmtp.TabIndex = 6;
            this.txtSmtp.Text = "smtp.gmail.com";
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(479, 15);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(62, 25);
            this.chkSSL.TabIndex = 13;
            this.chkSSL.Text = "SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // txtCC
            // 
            this.txtCC.AutoSize = true;
            this.txtCC.Location = new System.Drawing.Point(52, 63);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(50, 21);
            this.txtCC.TabIndex = 11;
            this.txtCC.Text = "CC : ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(158, 18);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(466, 29);
            this.textBox7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Subject : ";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(158, 90);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(466, 29);
            this.txtSubject.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 518);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Setting);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Sending";
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label labelSmtp;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.Label txtCC;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubject;
    }
}

