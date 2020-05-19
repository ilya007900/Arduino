namespace Arduino
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
            this.IRLed1OnButton = new System.Windows.Forms.Button();
            this.BlueLed1OnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PortsComboBox = new System.Windows.Forms.ComboBox();
            this.RefreshPortsButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.IRLed1OffButton = new System.Windows.Forms.Button();
            this.BlueLed1OffButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceivedCommandsList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SentCommandsList = new System.Windows.Forms.ListBox();
            this.PWMTextBox = new System.Windows.Forms.TextBox();
            this.SendPWMButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IRLed1OnButton
            // 
            this.IRLed1OnButton.Location = new System.Drawing.Point(25, 100);
            this.IRLed1OnButton.Name = "IRLed1OnButton";
            this.IRLed1OnButton.Size = new System.Drawing.Size(130, 50);
            this.IRLed1OnButton.TabIndex = 3;
            this.IRLed1OnButton.Text = "IRLed1On";
            this.IRLed1OnButton.UseVisualStyleBackColor = true;
            this.IRLed1OnButton.Click += new System.EventHandler(this.IRLed1OnButton_Click);
            // 
            // BlueLed1OnButton
            // 
            this.BlueLed1OnButton.Location = new System.Drawing.Point(25, 170);
            this.BlueLed1OnButton.Name = "BlueLed1OnButton";
            this.BlueLed1OnButton.Size = new System.Drawing.Size(130, 50);
            this.BlueLed1OnButton.TabIndex = 5;
            this.BlueLed1OnButton.Text = "BlueLed1On";
            this.BlueLed1OnButton.UseVisualStyleBackColor = true;
            this.BlueLed1OnButton.Click += new System.EventHandler(this.BlueLed1OnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ports:";
            // 
            // PortsComboBox
            // 
            this.PortsComboBox.FormattingEnabled = true;
            this.PortsComboBox.Location = new System.Drawing.Point(122, 22);
            this.PortsComboBox.Name = "PortsComboBox";
            this.PortsComboBox.Size = new System.Drawing.Size(161, 28);
            this.PortsComboBox.TabIndex = 3;
            // 
            // RefreshPortsButton
            // 
            this.RefreshPortsButton.Location = new System.Drawing.Point(600, 22);
            this.RefreshPortsButton.Name = "RefreshPortsButton";
            this.RefreshPortsButton.Size = new System.Drawing.Size(105, 40);
            this.RefreshPortsButton.TabIndex = 2;
            this.RefreshPortsButton.Text = "Refresh";
            this.RefreshPortsButton.UseVisualStyleBackColor = true;
            this.RefreshPortsButton.Click += new System.EventHandler(this.RefreshPortsButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(304, 22);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(128, 40);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.Location = new System.Drawing.Point(450, 22);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(128, 40);
            this.DisconnectButton.TabIndex = 1;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // IRLed1OffButton
            // 
            this.IRLed1OffButton.Location = new System.Drawing.Point(177, 100);
            this.IRLed1OffButton.Name = "IRLed1OffButton";
            this.IRLed1OffButton.Size = new System.Drawing.Size(130, 50);
            this.IRLed1OffButton.TabIndex = 7;
            this.IRLed1OffButton.Text = "IRLed1Off";
            this.IRLed1OffButton.UseVisualStyleBackColor = true;
            this.IRLed1OffButton.Click += new System.EventHandler(this.IRLed1OffButton_Click);
            // 
            // BlueLed1OffButton
            // 
            this.BlueLed1OffButton.Location = new System.Drawing.Point(177, 170);
            this.BlueLed1OffButton.Name = "BlueLed1OffButton";
            this.BlueLed1OffButton.Size = new System.Drawing.Size(130, 50);
            this.BlueLed1OffButton.TabIndex = 8;
            this.BlueLed1OffButton.Text = "BlueLed1Off";
            this.BlueLed1OffButton.UseVisualStyleBackColor = true;
            this.BlueLed1OffButton.Click += new System.EventHandler(this.BlueLed1OffButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Received commands:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // ReceivedCommandsList
            // 
            this.ReceivedCommandsList.FormattingEnabled = true;
            this.ReceivedCommandsList.ItemHeight = 20;
            this.ReceivedCommandsList.Location = new System.Drawing.Point(612, 354);
            this.ReceivedCommandsList.Name = "ReceivedCommandsList";
            this.ReceivedCommandsList.Size = new System.Drawing.Size(176, 84);
            this.ReceivedCommandsList.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sent commands:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // SentCommandsList
            // 
            this.SentCommandsList.FormattingEnabled = true;
            this.SentCommandsList.ItemHeight = 20;
            this.SentCommandsList.Location = new System.Drawing.Point(612, 214);
            this.SentCommandsList.Name = "SentCommandsList";
            this.SentCommandsList.Size = new System.Drawing.Size(176, 84);
            this.SentCommandsList.TabIndex = 12;
            // 
            // PWMTextBox
            // 
            this.PWMTextBox.Location = new System.Drawing.Point(25, 395);
            this.PWMTextBox.Name = "PWMTextBox";
            this.PWMTextBox.Size = new System.Drawing.Size(121, 26);
            this.PWMTextBox.TabIndex = 13;
            // 
            // SendPWMButton
            // 
            this.SendPWMButton.Location = new System.Drawing.Point(152, 395);
            this.SendPWMButton.Name = "SendPWMButton";
            this.SendPWMButton.Size = new System.Drawing.Size(113, 39);
            this.SendPWMButton.TabIndex = 14;
            this.SendPWMButton.Text = "SendPWM";
            this.SendPWMButton.UseVisualStyleBackColor = true;
            this.SendPWMButton.Click += new System.EventHandler(this.SendPWMButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendPWMButton);
            this.Controls.Add(this.PWMTextBox);
            this.Controls.Add(this.SentCommandsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReceivedCommandsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BlueLed1OffButton);
            this.Controls.Add(this.IRLed1OffButton);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.RefreshPortsButton);
            this.Controls.Add(this.PortsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlueLed1OnButton);
            this.Controls.Add(this.IRLed1OnButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IRLed1OnButton;
        private System.Windows.Forms.Button BlueLed1OnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PortsComboBox;
        private System.Windows.Forms.Button RefreshPortsButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button IRLed1OffButton;
        private System.Windows.Forms.Button BlueLed1OffButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ReceivedCommandsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox SentCommandsList;
        private System.Windows.Forms.TextBox PWMTextBox;
        private System.Windows.Forms.Button SendPWMButton;
    }
}

