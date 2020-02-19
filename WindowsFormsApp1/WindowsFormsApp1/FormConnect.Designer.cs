﻿namespace SocketCommunicationToPython
{
    partial class SocketPythonKommunikation
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Connect = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.SendText = new System.Windows.Forms.TextBox();
            this.StatusGroup = new System.Windows.Forms.GroupBox();
            this.Ip = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.IpLable = new System.Windows.Forms.Label();
            this.PortLable = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StatusGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(11, 115);
            this.Connect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(112, 35);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(133, 115);
            this.Disconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(112, 35);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(254, 115);
            this.Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(112, 35);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send Text";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // SendText
            // 
            this.SendText.Location = new System.Drawing.Point(375, 119);
            this.SendText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(373, 26);
            this.SendText.TabIndex = 3;
            // 
            // StatusGroup
            // 
            this.StatusGroup.Controls.Add(this.Status);
            this.StatusGroup.Location = new System.Drawing.Point(11, 160);
            this.StatusGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusGroup.Name = "StatusGroup";
            this.StatusGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusGroup.Size = new System.Drawing.Size(750, 214);
            this.StatusGroup.TabIndex = 5;
            this.StatusGroup.TabStop = false;
            this.StatusGroup.Text = "Status";
            // 
            // Ip
            // 
            this.Ip.Location = new System.Drawing.Point(11, 60);
            this.Ip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(234, 26);
            this.Ip.TabIndex = 6;
            this.Ip.Text = "127.0.0.1";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(254, 60);
            this.Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(120, 26);
            this.Port.TabIndex = 7;
            this.Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Port.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // IpLable
            // 
            this.IpLable.AutoSize = true;
            this.IpLable.Location = new System.Drawing.Point(11, 32);
            this.IpLable.Name = "IpLable";
            this.IpLable.Size = new System.Drawing.Size(24, 20);
            this.IpLable.TabIndex = 8;
            this.IpLable.Text = "IP";
            // 
            // PortLable
            // 
            this.PortLable.AutoSize = true;
            this.PortLable.Location = new System.Drawing.Point(254, 32);
            this.PortLable.Name = "PortLable";
            this.PortLable.Size = new System.Drawing.Size(38, 20);
            this.PortLable.TabIndex = 9;
            this.PortLable.Text = "Port";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(9, 46);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Status.Multiline = true;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(728, 149);
            this.Status.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SocketPythonKommunikation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 385);
            this.Controls.Add(this.PortLable);
            this.Controls.Add(this.IpLable);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Ip);
            this.Controls.Add(this.StatusGroup);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Connect);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SocketPythonKommunikation";
            this.Text = "Socket Communication to Python";
            this.StatusGroup.ResumeLayout(false);
            this.StatusGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox SendText;
        private System.Windows.Forms.GroupBox StatusGroup;
        private System.Windows.Forms.TextBox Ip;
        private System.Windows.Forms.NumericUpDown Port;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label IpLable;
        private System.Windows.Forms.Label PortLable;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

