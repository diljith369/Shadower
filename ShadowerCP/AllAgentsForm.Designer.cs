namespace ShadowerCP
{
    partial class AllAgentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllAgentsForm));
            this.bottompanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtwAllAgents = new System.Windows.Forms.DataGridView();
            this.gridpanel = new System.Windows.Forms.Panel();
            this.gridclosepanel = new System.Windows.Forms.Panel();
            this.btnControllerPanel = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.ChildFormHolderPanel = new System.Windows.Forms.Panel();
            this.lblSelectedFormHeader = new System.Windows.Forms.Label();
            this.bottompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtwAllAgents)).BeginInit();
            this.gridpanel.SuspendLayout();
            this.gridclosepanel.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.ChildFormHolderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.bottompanel.Controls.Add(this.btnRefresh);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(0, 882);
            this.bottompanel.Margin = new System.Windows.Forms.Padding(2);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(1602, 80);
            this.bottompanel.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(650, 1);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(206, 39);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtwAllAgents
            // 
            this.dtwAllAgents.AllowUserToAddRows = false;
            this.dtwAllAgents.AllowUserToDeleteRows = false;
            this.dtwAllAgents.AllowUserToResizeRows = false;
            this.dtwAllAgents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtwAllAgents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtwAllAgents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.dtwAllAgents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtwAllAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwAllAgents.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtwAllAgents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.dtwAllAgents.Location = new System.Drawing.Point(0, 0);
            this.dtwAllAgents.Margin = new System.Windows.Forms.Padding(2);
            this.dtwAllAgents.Name = "dtwAllAgents";
            this.dtwAllAgents.RowHeadersWidth = 35;
            this.dtwAllAgents.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.dtwAllAgents.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.AliceBlue;
            this.dtwAllAgents.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dtwAllAgents.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.dtwAllAgents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtwAllAgents.Size = new System.Drawing.Size(1561, 326);
            this.dtwAllAgents.TabIndex = 0;
            this.dtwAllAgents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtwAllAgents_CellClick);
            this.dtwAllAgents.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtwAllAgents_DataBindingComplete);
            // 
            // gridpanel
            // 
            this.gridpanel.BackColor = System.Drawing.Color.DimGray;
            this.gridpanel.Controls.Add(this.gridclosepanel);
            this.gridpanel.Controls.Add(this.dtwAllAgents);
            this.gridpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridpanel.Location = new System.Drawing.Point(0, 556);
            this.gridpanel.Margin = new System.Windows.Forms.Padding(2);
            this.gridpanel.Name = "gridpanel";
            this.gridpanel.Size = new System.Drawing.Size(1602, 326);
            this.gridpanel.TabIndex = 0;
            // 
            // gridclosepanel
            // 
            this.gridclosepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.gridclosepanel.Controls.Add(this.btnControllerPanel);
            this.gridclosepanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridclosepanel.Location = new System.Drawing.Point(1557, 0);
            this.gridclosepanel.Margin = new System.Windows.Forms.Padding(2);
            this.gridclosepanel.Name = "gridclosepanel";
            this.gridclosepanel.Size = new System.Drawing.Size(45, 326);
            this.gridclosepanel.TabIndex = 1;
            // 
            // btnControllerPanel
            // 
            this.btnControllerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnControllerPanel.BackgroundImage")));
            this.btnControllerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnControllerPanel.FlatAppearance.BorderSize = 0;
            this.btnControllerPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControllerPanel.Location = new System.Drawing.Point(9, 2);
            this.btnControllerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.btnControllerPanel.MaximumSize = new System.Drawing.Size(28, 31);
            this.btnControllerPanel.Name = "btnControllerPanel";
            this.btnControllerPanel.Size = new System.Drawing.Size(28, 30);
            this.btnControllerPanel.TabIndex = 12;
            this.btnControllerPanel.UseVisualStyleBackColor = true;
            this.btnControllerPanel.Click += new System.EventHandler(this.btnControllerPanel_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.ChildFormHolderPanel);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1602, 556);
            this.mainpanel.TabIndex = 4;
            // 
            // ChildFormHolderPanel
            // 
            this.ChildFormHolderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ChildFormHolderPanel.Controls.Add(this.lblSelectedFormHeader);
            this.ChildFormHolderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormHolderPanel.Location = new System.Drawing.Point(0, 0);
            this.ChildFormHolderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ChildFormHolderPanel.Name = "ChildFormHolderPanel";
            this.ChildFormHolderPanel.Size = new System.Drawing.Size(1602, 556);
            this.ChildFormHolderPanel.TabIndex = 4;
            // 
            // lblSelectedFormHeader
            // 
            this.lblSelectedFormHeader.AutoSize = true;
            this.lblSelectedFormHeader.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFormHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSelectedFormHeader.Location = new System.Drawing.Point(621, 0);
            this.lblSelectedFormHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedFormHeader.Name = "lblSelectedFormHeader";
            this.lblSelectedFormHeader.Size = new System.Drawing.Size(253, 25);
            this.lblSelectedFormHeader.TabIndex = 18;
            this.lblSelectedFormHeader.Text = "Botnet Control Panel";
            // 
            // AllAgentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1602, 962);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.gridpanel);
            this.Controls.Add(this.bottompanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "AllAgentsForm";
            this.Text = "Shaodwer Agents Control Panel";
            this.bottompanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtwAllAgents)).EndInit();
            this.gridpanel.ResumeLayout(false);
            this.gridclosepanel.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.ChildFormHolderPanel.ResumeLayout(false);
            this.ChildFormHolderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.DataGridView dtwAllAgents;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel gridpanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel gridclosepanel;
        private System.Windows.Forms.Button btnControllerPanel;
        private System.Windows.Forms.Panel ChildFormHolderPanel;
        private System.Windows.Forms.Label lblSelectedFormHeader;
    }
}