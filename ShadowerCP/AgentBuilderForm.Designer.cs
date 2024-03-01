namespace ShadowerCP
{
    partial class AgentBuilderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentBuilderForm));
            this.rdbtnExe = new System.Windows.Forms.RadioButton();
            this.rdbtnDll = new System.Windows.Forms.RadioButton();
            this.grpAgentBinType = new System.Windows.Forms.GroupBox();
            this.grpEXEType = new System.Windows.Forms.GroupBox();
            this.cmbExeType = new System.Windows.Forms.ComboBox();
            this.btnFormClose = new System.Windows.Forms.Button();
            this.txtSaveAs = new System.Windows.Forms.TextBox();
            this.lblSaveAs = new System.Windows.Forms.Label();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnShowAgent = new System.Windows.Forms.Button();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.lblUserAgent = new System.Windows.Forms.Label();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.bottompnl = new System.Windows.Forms.Panel();
            this.mainpnl = new System.Windows.Forms.Panel();
            this.chkReflectLoader = new System.Windows.Forms.CheckBox();
            this.lblreflectloader = new System.Windows.Forms.Label();
            this.refelectloaderpath = new System.Windows.Forms.TextBox();
            this.lblProxy = new System.Windows.Forms.Label();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.grpAgentType = new System.Windows.Forms.GroupBox();
            this.cmbAgentType = new System.Windows.Forms.ComboBox();
            this.lblC2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelectedFormHeader = new System.Windows.Forms.Label();
            this.lblSaveAsRemoteAgent = new System.Windows.Forms.Label();
            this.txtRemoteAgentName = new System.Windows.Forms.TextBox();
            this.grpAgentBinType.SuspendLayout();
            this.grpEXEType.SuspendLayout();
            this.mainpnl.SuspendLayout();
            this.grpAgentType.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtnExe
            // 
            this.rdbtnExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnExe.AutoSize = true;
            this.rdbtnExe.Location = new System.Drawing.Point(18, 28);
            this.rdbtnExe.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnExe.Name = "rdbtnExe";
            this.rdbtnExe.Size = new System.Drawing.Size(73, 25);
            this.rdbtnExe.TabIndex = 1;
            this.rdbtnExe.TabStop = true;
            this.rdbtnExe.Text = "EXE";
            this.rdbtnExe.UseVisualStyleBackColor = true;
            this.rdbtnExe.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbtnDll
            // 
            this.rdbtnDll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnDll.AutoSize = true;
            this.rdbtnDll.Location = new System.Drawing.Point(120, 28);
            this.rdbtnDll.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnDll.Name = "rdbtnDll";
            this.rdbtnDll.Size = new System.Drawing.Size(69, 25);
            this.rdbtnDll.TabIndex = 2;
            this.rdbtnDll.TabStop = true;
            this.rdbtnDll.Text = "DLL";
            this.rdbtnDll.UseVisualStyleBackColor = true;
            this.rdbtnDll.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // grpAgentBinType
            // 
            this.grpAgentBinType.Controls.Add(this.rdbtnExe);
            this.grpAgentBinType.Controls.Add(this.rdbtnDll);
            this.grpAgentBinType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpAgentBinType.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgentBinType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpAgentBinType.Location = new System.Drawing.Point(320, 112);
            this.grpAgentBinType.Margin = new System.Windows.Forms.Padding(2);
            this.grpAgentBinType.Name = "grpAgentBinType";
            this.grpAgentBinType.Padding = new System.Windows.Forms.Padding(2);
            this.grpAgentBinType.Size = new System.Drawing.Size(208, 65);
            this.grpAgentBinType.TabIndex = 4;
            this.grpAgentBinType.TabStop = false;
            this.grpAgentBinType.Text = "Agent Binary Type";
            // 
            // grpEXEType
            // 
            this.grpEXEType.Controls.Add(this.cmbExeType);
            this.grpEXEType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpEXEType.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEXEType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpEXEType.Location = new System.Drawing.Point(546, 112);
            this.grpEXEType.Margin = new System.Windows.Forms.Padding(2);
            this.grpEXEType.Name = "grpEXEType";
            this.grpEXEType.Padding = new System.Windows.Forms.Padding(2);
            this.grpEXEType.Size = new System.Drawing.Size(208, 65);
            this.grpEXEType.TabIndex = 6;
            this.grpEXEType.TabStop = false;
            this.grpEXEType.Text = "EXE Type";
            this.grpEXEType.Visible = false;
            // 
            // cmbExeType
            // 
            this.cmbExeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExeType.FormattingEnabled = true;
            this.cmbExeType.Items.AddRange(new object[] {
            "Console",
            "No Console"});
            this.cmbExeType.Location = new System.Drawing.Point(13, 24);
            this.cmbExeType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbExeType.Name = "cmbExeType";
            this.cmbExeType.Size = new System.Drawing.Size(182, 28);
            this.cmbExeType.TabIndex = 0;
            // 
            // btnFormClose
            // 
            this.btnFormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormClose.BackgroundImage")));
            this.btnFormClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFormClose.FlatAppearance.BorderSize = 0;
            this.btnFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormClose.Location = new System.Drawing.Point(10, 2);
            this.btnFormClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Size = new System.Drawing.Size(28, 31);
            this.btnFormClose.TabIndex = 7;
            this.btnFormClose.UseVisualStyleBackColor = true;
            this.btnFormClose.Click += new System.EventHandler(this.btnFormClose_Click);
            // 
            // txtSaveAs
            // 
            this.txtSaveAs.Location = new System.Drawing.Point(322, 326);
            this.txtSaveAs.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaveAs.Name = "txtSaveAs";
            this.txtSaveAs.Size = new System.Drawing.Size(654, 30);
            this.txtSaveAs.TabIndex = 8;
            // 
            // lblSaveAs
            // 
            this.lblSaveAs.AutoSize = true;
            this.lblSaveAs.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveAs.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSaveAs.Location = new System.Drawing.Point(317, 301);
            this.lblSaveAs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaveAs.Name = "lblSaveAs";
            this.lblSaveAs.Size = new System.Drawing.Size(207, 21);
            this.lblSaveAs.TabIndex = 9;
            this.lblSaveAs.Text = "Save As (Local Agent)";
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.btnBuild.Location = new System.Drawing.Point(728, 522);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(116, 40);
            this.btnBuild.TabIndex = 10;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnShowAgent
            // 
            this.btnShowAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.btnShowAgent.Location = new System.Drawing.Point(862, 522);
            this.btnShowAgent.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAgent.Name = "btnShowAgent";
            this.btnShowAgent.Size = new System.Drawing.Size(116, 40);
            this.btnShowAgent.TabIndex = 11;
            this.btnShowAgent.Text = "Show";
            this.btnShowAgent.UseVisualStyleBackColor = false;
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(320, 61);
            this.txtEndPoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.ReadOnly = true;
            this.txtEndPoint.Size = new System.Drawing.Size(656, 30);
            this.txtEndPoint.TabIndex = 2;
            // 
            // lblUserAgent
            // 
            this.lblUserAgent.AutoSize = true;
            this.lblUserAgent.BackColor = System.Drawing.Color.Transparent;
            this.lblUserAgent.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblUserAgent.Location = new System.Drawing.Point(317, 240);
            this.lblUserAgent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserAgent.Name = "lblUserAgent";
            this.lblUserAgent.Size = new System.Drawing.Size(109, 21);
            this.lblUserAgent.TabIndex = 14;
            this.lblUserAgent.Text = "User Agent";
            // 
            // txtUserAgent
            // 
            this.txtUserAgent.Location = new System.Drawing.Point(320, 265);
            this.txtUserAgent.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.Size = new System.Drawing.Size(654, 30);
            this.txtUserAgent.TabIndex = 13;
            // 
            // bottompnl
            // 
            this.bottompnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompnl.Location = new System.Drawing.Point(0, 629);
            this.bottompnl.Margin = new System.Windows.Forms.Padding(4);
            this.bottompnl.Name = "bottompnl";
            this.bottompnl.Size = new System.Drawing.Size(1345, 171);
            this.bottompnl.TabIndex = 15;
            // 
            // mainpnl
            // 
            this.mainpnl.Controls.Add(this.lblSaveAsRemoteAgent);
            this.mainpnl.Controls.Add(this.txtRemoteAgentName);
            this.mainpnl.Controls.Add(this.chkReflectLoader);
            this.mainpnl.Controls.Add(this.lblreflectloader);
            this.mainpnl.Controls.Add(this.refelectloaderpath);
            this.mainpnl.Controls.Add(this.lblProxy);
            this.mainpnl.Controls.Add(this.txtProxy);
            this.mainpnl.Controls.Add(this.grpAgentType);
            this.mainpnl.Controls.Add(this.lblC2);
            this.mainpnl.Controls.Add(this.txtEndPoint);
            this.mainpnl.Controls.Add(this.panel1);
            this.mainpnl.Controls.Add(this.grpAgentBinType);
            this.mainpnl.Controls.Add(this.grpEXEType);
            this.mainpnl.Controls.Add(this.lblSaveAs);
            this.mainpnl.Controls.Add(this.lblUserAgent);
            this.mainpnl.Controls.Add(this.btnBuild);
            this.mainpnl.Controls.Add(this.txtUserAgent);
            this.mainpnl.Controls.Add(this.btnShowAgent);
            this.mainpnl.Controls.Add(this.txtSaveAs);
            this.mainpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpnl.Location = new System.Drawing.Point(0, 0);
            this.mainpnl.Margin = new System.Windows.Forms.Padding(4);
            this.mainpnl.Name = "mainpnl";
            this.mainpnl.Size = new System.Drawing.Size(1345, 629);
            this.mainpnl.TabIndex = 16;
            // 
            // chkReflectLoader
            // 
            this.chkReflectLoader.AutoSize = true;
            this.chkReflectLoader.Location = new System.Drawing.Point(323, 364);
            this.chkReflectLoader.Margin = new System.Windows.Forms.Padding(4);
            this.chkReflectLoader.Name = "chkReflectLoader";
            this.chkReflectLoader.Size = new System.Drawing.Size(181, 27);
            this.chkReflectLoader.TabIndex = 21;
            this.chkReflectLoader.Text = "Reflect Loader";
            this.chkReflectLoader.UseVisualStyleBackColor = true;
            this.chkReflectLoader.CheckStateChanged += new System.EventHandler(this.chkReflectLoader_CheckStateChanged);
            // 
            // lblreflectloader
            // 
            this.lblreflectloader.AutoSize = true;
            this.lblreflectloader.BackColor = System.Drawing.Color.Transparent;
            this.lblreflectloader.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblreflectloader.Location = new System.Drawing.Point(317, 395);
            this.lblreflectloader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblreflectloader.Name = "lblreflectloader";
            this.lblreflectloader.Size = new System.Drawing.Size(196, 21);
            this.lblreflectloader.TabIndex = 20;
            this.lblreflectloader.Text = "Loader Serever Path";
            // 
            // refelectloaderpath
            // 
            this.refelectloaderpath.Location = new System.Drawing.Point(321, 420);
            this.refelectloaderpath.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.refelectloaderpath.Name = "refelectloaderpath";
            this.refelectloaderpath.Size = new System.Drawing.Size(655, 30);
            this.refelectloaderpath.TabIndex = 19;
            // 
            // lblProxy
            // 
            this.lblProxy.AutoSize = true;
            this.lblProxy.BackColor = System.Drawing.Color.Transparent;
            this.lblProxy.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblProxy.Location = new System.Drawing.Point(317, 179);
            this.lblProxy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(62, 21);
            this.lblProxy.TabIndex = 18;
            this.lblProxy.Text = "Proxy";
            // 
            // txtProxy
            // 
            this.txtProxy.Location = new System.Drawing.Point(320, 204);
            this.txtProxy.Margin = new System.Windows.Forms.Padding(2);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(654, 30);
            this.txtProxy.TabIndex = 17;
            // 
            // grpAgentType
            // 
            this.grpAgentType.Controls.Add(this.cmbAgentType);
            this.grpAgentType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpAgentType.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgentType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpAgentType.Location = new System.Drawing.Point(770, 112);
            this.grpAgentType.Margin = new System.Windows.Forms.Padding(2);
            this.grpAgentType.Name = "grpAgentType";
            this.grpAgentType.Padding = new System.Windows.Forms.Padding(2);
            this.grpAgentType.Size = new System.Drawing.Size(208, 65);
            this.grpAgentType.TabIndex = 7;
            this.grpAgentType.TabStop = false;
            this.grpAgentType.Text = "Agent Type";
            this.grpAgentType.Visible = false;
            // 
            // cmbAgentType
            // 
            this.cmbAgentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAgentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgentType.FormattingEnabled = true;
            this.cmbAgentType.Items.AddRange(new object[] {
            "C# http",
            "Go http"});
            this.cmbAgentType.Location = new System.Drawing.Point(12, 24);
            this.cmbAgentType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAgentType.Name = "cmbAgentType";
            this.cmbAgentType.Size = new System.Drawing.Size(182, 28);
            this.cmbAgentType.TabIndex = 0;
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.BackColor = System.Drawing.Color.Transparent;
            this.lblC2.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblC2.Location = new System.Drawing.Point(318, 36);
            this.lblC2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(35, 21);
            this.lblC2.TabIndex = 16;
            this.lblC2.Text = "C2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFormClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1294, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 629);
            this.panel1.TabIndex = 15;
            // 
            // lblSelectedFormHeader
            // 
            this.lblSelectedFormHeader.AutoSize = true;
            this.lblSelectedFormHeader.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFormHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSelectedFormHeader.Location = new System.Drawing.Point(441, 6);
            this.lblSelectedFormHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedFormHeader.Name = "lblSelectedFormHeader";
            this.lblSelectedFormHeader.Size = new System.Drawing.Size(288, 25);
            this.lblSelectedFormHeader.TabIndex = 17;
            this.lblSelectedFormHeader.Text = "Shadower Agent Builder";
            // 
            // lblSaveAsRemoteAgent
            // 
            this.lblSaveAsRemoteAgent.AutoSize = true;
            this.lblSaveAsRemoteAgent.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveAsRemoteAgent.Enabled = false;
            this.lblSaveAsRemoteAgent.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSaveAsRemoteAgent.Location = new System.Drawing.Point(317, 456);
            this.lblSaveAsRemoteAgent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaveAsRemoteAgent.Name = "lblSaveAsRemoteAgent";
            this.lblSaveAsRemoteAgent.Size = new System.Drawing.Size(229, 21);
            this.lblSaveAsRemoteAgent.TabIndex = 23;
            this.lblSaveAsRemoteAgent.Text = "Save As (Remote Agent)";
            // 
            // txtRemoteAgentName
            // 
            this.txtRemoteAgentName.Enabled = false;
            this.txtRemoteAgentName.Location = new System.Drawing.Point(322, 481);
            this.txtRemoteAgentName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoteAgentName.Name = "txtRemoteAgentName";
            this.txtRemoteAgentName.Size = new System.Drawing.Size(654, 30);
            this.txtRemoteAgentName.TabIndex = 22;
            // 
            // AgentBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1345, 800);
            this.Controls.Add(this.lblSelectedFormHeader);
            this.Controls.Add(this.mainpnl);
            this.Controls.Add(this.bottompnl);
            this.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AgentBuilderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shadower Agent Builder";
            this.Load += new System.EventHandler(this.AgentBuilderForm_Load);
            this.grpAgentBinType.ResumeLayout(false);
            this.grpAgentBinType.PerformLayout();
            this.grpEXEType.ResumeLayout(false);
            this.mainpnl.ResumeLayout(false);
            this.mainpnl.PerformLayout();
            this.grpAgentType.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbtnExe;
        private System.Windows.Forms.RadioButton rdbtnDll;
        private System.Windows.Forms.GroupBox grpAgentBinType;
        private System.Windows.Forms.GroupBox grpEXEType;
        private System.Windows.Forms.ComboBox cmbExeType;
        private System.Windows.Forms.Button btnFormClose;
        private System.Windows.Forms.TextBox txtSaveAs;
        private System.Windows.Forms.Label lblSaveAs;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnShowAgent;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label lblUserAgent;
        private System.Windows.Forms.TextBox txtUserAgent;
        private System.Windows.Forms.Panel bottompnl;
        private System.Windows.Forms.Panel mainpnl;
        private System.Windows.Forms.Label lblC2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelectedFormHeader;
        private System.Windows.Forms.GroupBox grpAgentType;
        private System.Windows.Forms.ComboBox cmbAgentType;
        private System.Windows.Forms.Label lblProxy;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.CheckBox chkReflectLoader;
        private System.Windows.Forms.Label lblreflectloader;
        private System.Windows.Forms.TextBox refelectloaderpath;
        private System.Windows.Forms.Label lblSaveAsRemoteAgent;
        private System.Windows.Forms.TextBox txtRemoteAgentName;
    }
}