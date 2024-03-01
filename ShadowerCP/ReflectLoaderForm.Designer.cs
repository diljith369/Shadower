namespace ShadowerCP
{
    partial class ReflectLoaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReflectLoaderForm));
            this.grpReflectorEndpoint = new System.Windows.Forms.GroupBox();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnServerSettingClose = new System.Windows.Forms.Button();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.lblSelectedFormHeader = new System.Windows.Forms.Label();
            this.grpReflectorEndpoint.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReflectorEndpoint
            // 
            this.grpReflectorEndpoint.Controls.Add(this.txtEndPoint);
            this.grpReflectorEndpoint.Controls.Add(this.btnBuild);
            this.grpReflectorEndpoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpReflectorEndpoint.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpReflectorEndpoint.Location = new System.Drawing.Point(41, 31);
            this.grpReflectorEndpoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReflectorEndpoint.Name = "grpReflectorEndpoint";
            this.grpReflectorEndpoint.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReflectorEndpoint.Size = new System.Drawing.Size(787, 71);
            this.grpReflectorEndpoint.TabIndex = 7;
            this.grpReflectorEndpoint.TabStop = false;
            this.grpReflectorEndpoint.Text = "Loader Server";
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(14, 28);
            this.txtEndPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(635, 26);
            this.txtEndPoint.TabIndex = 2;
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBuild.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBuild.FlatAppearance.BorderSize = 0;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuild.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBuild.Location = new System.Drawing.Point(661, 26);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(110, 31);
            this.btnBuild.TabIndex = 5;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = false;
            // 
            // btnServerSettingClose
            // 
            this.btnServerSettingClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServerSettingClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServerSettingClose.BackgroundImage")));
            this.btnServerSettingClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnServerSettingClose.FlatAppearance.BorderSize = 0;
            this.btnServerSettingClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerSettingClose.Location = new System.Drawing.Point(6, 2);
            this.btnServerSettingClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnServerSettingClose.Name = "btnServerSettingClose";
            this.btnServerSettingClose.Size = new System.Drawing.Size(22, 25);
            this.btnServerSettingClose.TabIndex = 8;
            this.btnServerSettingClose.UseVisualStyleBackColor = true;
            this.btnServerSettingClose.Click += new System.EventHandler(this.btnServerSettingClose_Click);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.btnServerSettingClose);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightpanel.Location = new System.Drawing.Point(857, 0);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(38, 534);
            this.rightpanel.TabIndex = 9;
            // 
            // lblSelectedFormHeader
            // 
            this.lblSelectedFormHeader.AutoSize = true;
            this.lblSelectedFormHeader.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFormHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSelectedFormHeader.Location = new System.Drawing.Point(410, 9);
            this.lblSelectedFormHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedFormHeader.Name = "lblSelectedFormHeader";
            this.lblSelectedFormHeader.Size = new System.Drawing.Size(230, 20);
            this.lblSelectedFormHeader.TabIndex = 16;
            this.lblSelectedFormHeader.Text = "Shadower Reflect Loader";
            // 
            // ReflectLoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(895, 534);
            this.Controls.Add(this.lblSelectedFormHeader);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.grpReflectorEndpoint);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReflectLoaderForm";
            this.Text = "Reflect Loader";
            this.grpReflectorEndpoint.ResumeLayout(false);
            this.grpReflectorEndpoint.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReflectorEndpoint;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnServerSettingClose;
        private System.Windows.Forms.Panel rightpanel;
        private System.Windows.Forms.Label lblSelectedFormHeader;
    }
}