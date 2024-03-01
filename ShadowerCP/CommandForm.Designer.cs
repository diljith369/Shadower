namespace ShadowerCP
{
    partial class CommandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandForm));
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnSendandReceive = new System.Windows.Forms.Button();
            this.rtResult = new System.Windows.Forms.RichTextBox();
            this.picScreen = new System.Windows.Forms.PictureBox();
            this.btnControllerPanel = new System.Windows.Forms.Button();
            this.holderpaneltop = new System.Windows.Forms.Panel();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.toppanel = new System.Windows.Forms.Panel();
            this.bottompanel = new System.Windows.Forms.Panel();
            this.mainleftpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).BeginInit();
            this.holderpaneltop.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.toppanel.SuspendLayout();
            this.bottompanel.SuspendLayout();
            this.mainleftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommand.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.ForeColor = System.Drawing.Color.Black;
            this.txtCommand.Location = new System.Drawing.Point(32, 6);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(1158, 24);
            this.txtCommand.TabIndex = 0;
            // 
            // btnSendandReceive
            // 
            this.btnSendandReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.btnSendandReceive.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSendandReceive.FlatAppearance.BorderSize = 0;
            this.btnSendandReceive.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendandReceive.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSendandReceive.Location = new System.Drawing.Point(49, 1);
            this.btnSendandReceive.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendandReceive.Name = "btnSendandReceive";
            this.btnSendandReceive.Size = new System.Drawing.Size(146, 36);
            this.btnSendandReceive.TabIndex = 1;
            this.btnSendandReceive.Text = "Get Result";
            this.btnSendandReceive.UseVisualStyleBackColor = false;
            this.btnSendandReceive.Click += new System.EventHandler(this.btnSendandReceive_Click);
            // 
            // rtResult
            // 
            this.rtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtResult.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtResult.ForeColor = System.Drawing.Color.AliceBlue;
            this.rtResult.Location = new System.Drawing.Point(0, 0);
            this.rtResult.Margin = new System.Windows.Forms.Padding(4);
            this.rtResult.Name = "rtResult";
            this.rtResult.Size = new System.Drawing.Size(1204, 591);
            this.rtResult.TabIndex = 0;
            this.rtResult.Text = "";
            // 
            // picScreen
            // 
            this.picScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picScreen.Location = new System.Drawing.Point(0, 0);
            this.picScreen.Margin = new System.Windows.Forms.Padding(0);
            this.picScreen.Name = "picScreen";
            this.picScreen.Size = new System.Drawing.Size(1204, 591);
            this.picScreen.TabIndex = 9;
            this.picScreen.TabStop = false;
            this.picScreen.Visible = false;
            // 
            // btnControllerPanel
            // 
            this.btnControllerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnControllerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnControllerPanel.BackgroundImage")));
            this.btnControllerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnControllerPanel.FlatAppearance.BorderSize = 0;
            this.btnControllerPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControllerPanel.Location = new System.Drawing.Point(256, 4);
            this.btnControllerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.btnControllerPanel.Name = "btnControllerPanel";
            this.btnControllerPanel.Size = new System.Drawing.Size(28, 30);
            this.btnControllerPanel.TabIndex = 11;
            this.btnControllerPanel.UseVisualStyleBackColor = true;
            this.btnControllerPanel.Click += new System.EventHandler(this.btnControllerPanel_Click);
            // 
            // holderpaneltop
            // 
            this.holderpaneltop.Controls.Add(this.rightpanel);
            this.holderpaneltop.Dock = System.Windows.Forms.DockStyle.Right;
            this.holderpaneltop.Location = new System.Drawing.Point(1168, 0);
            this.holderpaneltop.Margin = new System.Windows.Forms.Padding(2);
            this.holderpaneltop.Name = "holderpaneltop";
            this.holderpaneltop.Size = new System.Drawing.Size(332, 628);
            this.holderpaneltop.TabIndex = 12;
            // 
            // rightpanel
            // 
            this.rightpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rightpanel.Controls.Add(this.btnSendandReceive);
            this.rightpanel.Controls.Add(this.btnControllerPanel);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightpanel.Location = new System.Drawing.Point(38, 0);
            this.rightpanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(294, 628);
            this.rightpanel.TabIndex = 0;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toppanel.Controls.Add(this.txtCommand);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(8);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1202, 39);
            this.toppanel.TabIndex = 13;
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.DimGray;
            this.bottompanel.Controls.Add(this.rtResult);
            this.bottompanel.Controls.Add(this.picScreen);
            this.bottompanel.Location = new System.Drawing.Point(0, 35);
            this.bottompanel.Margin = new System.Windows.Forms.Padding(2);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(1204, 591);
            this.bottompanel.TabIndex = 14;
            // 
            // mainleftpanel
            // 
            this.mainleftpanel.BackColor = System.Drawing.Color.DimGray;
            this.mainleftpanel.Controls.Add(this.toppanel);
            this.mainleftpanel.Controls.Add(this.bottompanel);
            this.mainleftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainleftpanel.Location = new System.Drawing.Point(0, 0);
            this.mainleftpanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainleftpanel.Name = "mainleftpanel";
            this.mainleftpanel.Size = new System.Drawing.Size(1202, 628);
            this.mainleftpanel.TabIndex = 15;
            // 
            // CommandForm
            // 
            this.AcceptButton = this.btnSendandReceive;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1500, 628);
            this.Controls.Add(this.mainleftpanel);
            this.Controls.Add(this.holderpaneltop);
            this.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "CommandForm";
            this.Text = "Command Center";
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).EndInit();
            this.holderpaneltop.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.bottompanel.ResumeLayout(false);
            this.mainleftpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnSendandReceive;
        private System.Windows.Forms.RichTextBox rtResult;
        private System.Windows.Forms.PictureBox picScreen;
        private System.Windows.Forms.Button btnControllerPanel;
        private System.Windows.Forms.Panel holderpaneltop;
        private System.Windows.Forms.Panel rightpanel;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.Panel mainleftpanel;
    }
}

