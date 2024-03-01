namespace ShadowerCP
{
    partial class ShadowerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShadowerForm));
            this.leftpanel = new System.Windows.Forms.Panel();
            this.lbllogo = new System.Windows.Forms.Label();
            this.btnMisc = new System.Windows.Forms.Button();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.btnC2ServerSettings = new System.Windows.Forms.Button();
            this.btnAgentbuilder = new System.Windows.Forms.Button();
            this.btnControlPanel = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.btnFormClose = new System.Windows.Forms.Button();
            this.ChildFormHolderPanel = new System.Windows.Forms.Panel();
            this.mainarearightpanel = new System.Windows.Forms.Panel();
            this.mainareabottompanel = new System.Windows.Forms.Panel();
            this.leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.Transparent;
            this.leftpanel.Controls.Add(this.lbllogo);
            this.leftpanel.Controls.Add(this.btnMisc);
            this.leftpanel.Controls.Add(this.piclogo);
            this.leftpanel.Controls.Add(this.btnC2ServerSettings);
            this.leftpanel.Controls.Add(this.btnAgentbuilder);
            this.leftpanel.Controls.Add(this.btnControlPanel);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.ForeColor = System.Drawing.Color.OrangeRed;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(149, 1000);
            this.leftpanel.TabIndex = 0;
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.BackColor = System.Drawing.Color.Transparent;
            this.lbllogo.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.ForeColor = System.Drawing.Color.White;
            this.lbllogo.Location = new System.Drawing.Point(6, 70);
            this.lbllogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(126, 25);
            this.lbllogo.TabIndex = 14;
            this.lbllogo.Text = "Shadow3r";
            // 
            // btnMisc
            // 
            this.btnMisc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMisc.BackgroundImage")));
            this.btnMisc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMisc.FlatAppearance.BorderSize = 0;
            this.btnMisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisc.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold);
            this.btnMisc.ForeColor = System.Drawing.Color.White;
            this.btnMisc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMisc.Location = new System.Drawing.Point(4, 586);
            this.btnMisc.Margin = new System.Windows.Forms.Padding(2);
            this.btnMisc.Name = "btnMisc";
            this.btnMisc.Size = new System.Drawing.Size(128, 108);
            this.btnMisc.TabIndex = 26;
            this.btnMisc.Text = "Misc";
            this.btnMisc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMisc.UseVisualStyleBackColor = true;
            this.btnMisc.Click += new System.EventHandler(this.btnMisc_Click);
            this.btnMisc.Leave += new System.EventHandler(this.btnCommon_Leave);
            // 
            // piclogo
            // 
            this.piclogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("piclogo.BackgroundImage")));
            this.piclogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.piclogo.Location = new System.Drawing.Point(14, 14);
            this.piclogo.Margin = new System.Windows.Forms.Padding(2);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(111, 65);
            this.piclogo.TabIndex = 25;
            this.piclogo.TabStop = false;
            // 
            // btnC2ServerSettings
            // 
            this.btnC2ServerSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnC2ServerSettings.BackgroundImage")));
            this.btnC2ServerSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnC2ServerSettings.FlatAppearance.BorderSize = 0;
            this.btnC2ServerSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC2ServerSettings.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold);
            this.btnC2ServerSettings.ForeColor = System.Drawing.Color.White;
            this.btnC2ServerSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnC2ServerSettings.Location = new System.Drawing.Point(0, 223);
            this.btnC2ServerSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnC2ServerSettings.Name = "btnC2ServerSettings";
            this.btnC2ServerSettings.Size = new System.Drawing.Size(130, 96);
            this.btnC2ServerSettings.TabIndex = 24;
            this.btnC2ServerSettings.Text = "Config C2";
            this.btnC2ServerSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnC2ServerSettings.UseVisualStyleBackColor = true;
            this.btnC2ServerSettings.Click += new System.EventHandler(this.btnServerSettings_Click);
            this.btnC2ServerSettings.Leave += new System.EventHandler(this.btnCommon_Leave);
            // 
            // btnAgentbuilder
            // 
            this.btnAgentbuilder.BackColor = System.Drawing.Color.Transparent;
            this.btnAgentbuilder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgentbuilder.BackgroundImage")));
            this.btnAgentbuilder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgentbuilder.Enabled = false;
            this.btnAgentbuilder.FlatAppearance.BorderSize = 0;
            this.btnAgentbuilder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgentbuilder.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold);
            this.btnAgentbuilder.ForeColor = System.Drawing.Color.White;
            this.btnAgentbuilder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgentbuilder.Location = new System.Drawing.Point(0, 287);
            this.btnAgentbuilder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgentbuilder.Name = "btnAgentbuilder";
            this.btnAgentbuilder.Size = new System.Drawing.Size(130, 156);
            this.btnAgentbuilder.TabIndex = 22;
            this.btnAgentbuilder.Text = "Build Agent";
            this.btnAgentbuilder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgentbuilder.UseVisualStyleBackColor = false;
            this.btnAgentbuilder.Click += new System.EventHandler(this.btnAgentbuilder_Click);
            this.btnAgentbuilder.Leave += new System.EventHandler(this.btnCommon_Leave);
            // 
            // btnControlPanel
            // 
            this.btnControlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnControlPanel.BackgroundImage")));
            this.btnControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnControlPanel.Enabled = false;
            this.btnControlPanel.FlatAppearance.BorderSize = 0;
            this.btnControlPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlPanel.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold);
            this.btnControlPanel.ForeColor = System.Drawing.Color.White;
            this.btnControlPanel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnControlPanel.Location = new System.Drawing.Point(4, 444);
            this.btnControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.btnControlPanel.Name = "btnControlPanel";
            this.btnControlPanel.Size = new System.Drawing.Size(126, 135);
            this.btnControlPanel.TabIndex = 23;
            this.btnControlPanel.Text = "Control Panel";
            this.btnControlPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnControlPanel.UseVisualStyleBackColor = true;
            this.btnControlPanel.Click += new System.EventHandler(this.btnControlPanel_Click);
            this.btnControlPanel.Leave += new System.EventHandler(this.btnCommon_Leave);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.Transparent;
            this.toppanel.Controls.Add(this.btnFormClose);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(149, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1501, 41);
            this.toppanel.TabIndex = 1;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChildFormHolderPanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChildFormHolderPanel_MouseMove);
            this.toppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChildFormHolderPanel_MouseUp);
            // 
            // btnFormClose
            // 
            this.btnFormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormClose.BackgroundImage")));
            this.btnFormClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFormClose.FlatAppearance.BorderSize = 0;
            this.btnFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormClose.Location = new System.Drawing.Point(1462, 8);
            this.btnFormClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Size = new System.Drawing.Size(28, 31);
            this.btnFormClose.TabIndex = 5;
            this.btnFormClose.UseVisualStyleBackColor = true;
            this.btnFormClose.Click += new System.EventHandler(this.btnFormClose_Click);
            this.btnFormClose.Enter += new System.EventHandler(this.btnFormClose_Enter);
            // 
            // ChildFormHolderPanel
            // 
            this.ChildFormHolderPanel.BackColor = System.Drawing.Color.Transparent;
            this.ChildFormHolderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChildFormHolderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormHolderPanel.Location = new System.Drawing.Point(149, 41);
            this.ChildFormHolderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ChildFormHolderPanel.Name = "ChildFormHolderPanel";
            this.ChildFormHolderPanel.Size = new System.Drawing.Size(1460, 959);
            this.ChildFormHolderPanel.TabIndex = 12;
            this.ChildFormHolderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChildFormHolderPanel_MouseDown);
            this.ChildFormHolderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChildFormHolderPanel_MouseMove);
            this.ChildFormHolderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChildFormHolderPanel_MouseUp);
            // 
            // mainarearightpanel
            // 
            this.mainarearightpanel.BackColor = System.Drawing.Color.Transparent;
            this.mainarearightpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainarearightpanel.Location = new System.Drawing.Point(1609, 41);
            this.mainarearightpanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainarearightpanel.Name = "mainarearightpanel";
            this.mainarearightpanel.Size = new System.Drawing.Size(41, 959);
            this.mainarearightpanel.TabIndex = 14;
            // 
            // mainareabottompanel
            // 
            this.mainareabottompanel.BackColor = System.Drawing.Color.Transparent;
            this.mainareabottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainareabottompanel.Location = new System.Drawing.Point(149, 959);
            this.mainareabottompanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainareabottompanel.Name = "mainareabottompanel";
            this.mainareabottompanel.Size = new System.Drawing.Size(1460, 41);
            this.mainareabottompanel.TabIndex = 13;
            // 
            // ShadowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1650, 1000);
            this.Controls.Add(this.mainareabottompanel);
            this.Controls.Add(this.ChildFormHolderPanel);
            this.Controls.Add(this.mainarearightpanel);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.leftpanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(1650, 1000);
            this.MinimumSize = new System.Drawing.Size(1650, 1000);
            this.Name = "ShadowerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShadowerForm";
            this.Load += new System.EventHandler(this.ShadowerForm_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.toppanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftpanel;
        public System.Windows.Forms.Button btnAgentbuilder;
        private System.Windows.Forms.Panel toppanel;
        public System.Windows.Forms.Button btnControlPanel;
        private System.Windows.Forms.Button btnC2ServerSettings;
        private System.Windows.Forms.Button btnFormClose;
        private System.Windows.Forms.Panel ChildFormHolderPanel;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Panel mainareabottompanel;
        private System.Windows.Forms.Panel mainarearightpanel;
        private System.Windows.Forms.Button btnMisc;
        private System.Windows.Forms.Label lbllogo;
    }
}