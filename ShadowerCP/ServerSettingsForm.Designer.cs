namespace ShadowerCP
{
    partial class ServerSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSettingsForm));
            this.btnSubmitC2Settings = new System.Windows.Forms.Button();
            this.btnServerSettingClose = new System.Windows.Forms.Button();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.bottompanel = new System.Windows.Forms.Panel();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.lblSelectedFormHeader = new System.Windows.Forms.Label();
            this.grpAPIEndPoint = new System.Windows.Forms.GroupBox();
            this.rightpanel.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.grpAPIEndPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitC2Settings
            // 
            this.btnSubmitC2Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.btnSubmitC2Settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSubmitC2Settings.FlatAppearance.BorderSize = 0;
            this.btnSubmitC2Settings.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSubmitC2Settings.Location = new System.Drawing.Point(605, 28);
            this.btnSubmitC2Settings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitC2Settings.Name = "btnSubmitC2Settings";
            this.btnSubmitC2Settings.Size = new System.Drawing.Size(100, 33);
            this.btnSubmitC2Settings.TabIndex = 5;
            this.btnSubmitC2Settings.Text = "Submit";
            this.btnSubmitC2Settings.UseVisualStyleBackColor = false;
            this.btnSubmitC2Settings.Click += new System.EventHandler(this.btnSetServerSettings_Click);
            // 
            // btnServerSettingClose
            // 
            this.btnServerSettingClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServerSettingClose.BackgroundImage")));
            this.btnServerSettingClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnServerSettingClose.FlatAppearance.BorderSize = 0;
            this.btnServerSettingClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerSettingClose.Location = new System.Drawing.Point(14, 2);
            this.btnServerSettingClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnServerSettingClose.Name = "btnServerSettingClose";
            this.btnServerSettingClose.Size = new System.Drawing.Size(28, 31);
            this.btnServerSettingClose.TabIndex = 4;
            this.btnServerSettingClose.UseVisualStyleBackColor = true;
            this.btnServerSettingClose.Click += new System.EventHandler(this.btnServerSettingClose_Click);
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(12, 30);
            this.txtEndPoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(578, 31);
            this.txtEndPoint.TabIndex = 2;
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(0, 508);
            this.bottompanel.Margin = new System.Windows.Forms.Padding(2);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(1335, 226);
            this.bottompanel.TabIndex = 15;
            // 
            // rightpanel
            // 
            this.rightpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.rightpanel.Controls.Add(this.btnServerSettingClose);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightpanel.Location = new System.Drawing.Point(1283, 0);
            this.rightpanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(52, 508);
            this.rightpanel.TabIndex = 16;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.mainpanel.Controls.Add(this.lblSelectedFormHeader);
            this.mainpanel.Controls.Add(this.grpAPIEndPoint);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1283, 508);
            this.mainpanel.TabIndex = 0;
            // 
            // lblSelectedFormHeader
            // 
            this.lblSelectedFormHeader.AutoSize = true;
            this.lblSelectedFormHeader.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFormHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSelectedFormHeader.Location = new System.Drawing.Point(490, 5);
            this.lblSelectedFormHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedFormHeader.Name = "lblSelectedFormHeader";
            this.lblSelectedFormHeader.Size = new System.Drawing.Size(243, 25);
            this.lblSelectedFormHeader.TabIndex = 19;
            this.lblSelectedFormHeader.Text = "Shadower C2 Config";
            // 
            // grpAPIEndPoint
            // 
            this.grpAPIEndPoint.Controls.Add(this.txtEndPoint);
            this.grpAPIEndPoint.Controls.Add(this.btnSubmitC2Settings);
            this.grpAPIEndPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpAPIEndPoint.ForeColor = System.Drawing.Color.AliceBlue;
            this.grpAPIEndPoint.Location = new System.Drawing.Point(28, 55);
            this.grpAPIEndPoint.Margin = new System.Windows.Forms.Padding(2);
            this.grpAPIEndPoint.Name = "grpAPIEndPoint";
            this.grpAPIEndPoint.Padding = new System.Windows.Forms.Padding(2);
            this.grpAPIEndPoint.Size = new System.Drawing.Size(724, 78);
            this.grpAPIEndPoint.TabIndex = 6;
            this.grpAPIEndPoint.TabStop = false;
            this.grpAPIEndPoint.Text = "C2 ";
            // 
            // ServerSettingsForm
            // 
            this.AcceptButton = this.btnSubmitC2Settings;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1335, 734);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.bottompanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ServerSettingsForm";
            this.Text = "Shadower Server Settings";
            this.rightpanel.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.grpAPIEndPoint.ResumeLayout(false);
            this.grpAPIEndPoint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubmitC2Settings;
        private System.Windows.Forms.Button btnServerSettingClose;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.Panel rightpanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.GroupBox grpAPIEndPoint;
        private System.Windows.Forms.Label lblSelectedFormHeader;
    }
}