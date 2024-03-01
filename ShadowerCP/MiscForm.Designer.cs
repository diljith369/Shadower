namespace ShadowerCP
{
    partial class MiscForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiscForm));
            this.rtInput = new System.Windows.Forms.RichTextBox();
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.cmbOps = new System.Windows.Forms.ComboBox();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.mainleftpanel = new System.Windows.Forms.Panel();
            this.rightmainpanel = new System.Windows.Forms.Panel();
            this.btnFormClose = new System.Windows.Forms.Button();
            this.topmainpanel = new System.Windows.Forms.Panel();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblSelectedFormHeader = new System.Windows.Forms.Label();
            this.top2mainpanel = new System.Windows.Forms.Panel();
            this.top3mainpanel = new System.Windows.Forms.Panel();
            this.top4mainpanel = new System.Windows.Forms.Panel();
            this.top5mainpanel = new System.Windows.Forms.Panel();
            this.rightmainpanel.SuspendLayout();
            this.topmainpanel.SuspendLayout();
            this.top2mainpanel.SuspendLayout();
            this.top3mainpanel.SuspendLayout();
            this.top4mainpanel.SuspendLayout();
            this.top5mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtInput
            // 
            this.rtInput.BackColor = System.Drawing.Color.Silver;
            this.rtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtInput.Location = new System.Drawing.Point(0, 0);
            this.rtInput.Margin = new System.Windows.Forms.Padding(2);
            this.rtInput.Name = "rtInput";
            this.rtInput.Size = new System.Drawing.Size(1385, 374);
            this.rtInput.TabIndex = 1;
            this.rtInput.Text = "";
            // 
            // rtOutput
            // 
            this.rtOutput.BackColor = System.Drawing.Color.Gray;
            this.rtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtOutput.ForeColor = System.Drawing.Color.Azure;
            this.rtOutput.Location = new System.Drawing.Point(0, 0);
            this.rtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.ReadOnly = true;
            this.rtOutput.Size = new System.Drawing.Size(1385, 404);
            this.rtOutput.TabIndex = 3;
            this.rtOutput.Text = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOutput.Location = new System.Drawing.Point(0, 0);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(82, 24);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Output";
            // 
            // cmbOps
            // 
            this.cmbOps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOps.FormattingEnabled = true;
            this.cmbOps.Items.AddRange(new object[] {
            "Base64 Encode",
            "Base64 Decode",
            "Zip & B64Encode",
            "Unzip & B64Decode"});
            this.cmbOps.Location = new System.Drawing.Point(-2, 8);
            this.cmbOps.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOps.Name = "cmbOps";
            this.cmbOps.Size = new System.Drawing.Size(353, 32);
            this.cmbOps.TabIndex = 4;
            // 
            // btnGetResult
            // 
            this.btnGetResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.btnGetResult.FlatAppearance.BorderSize = 0;
            this.btnGetResult.ForeColor = System.Drawing.Color.White;
            this.btnGetResult.Location = new System.Drawing.Point(372, 5);
            this.btnGetResult.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(232, 39);
            this.btnGetResult.TabIndex = 8;
            this.btnGetResult.Text = "Get Result";
            this.btnGetResult.UseVisualStyleBackColor = false;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // mainleftpanel
            // 
            this.mainleftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainleftpanel.Location = new System.Drawing.Point(0, 0);
            this.mainleftpanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainleftpanel.Name = "mainleftpanel";
            this.mainleftpanel.Size = new System.Drawing.Size(30, 906);
            this.mainleftpanel.TabIndex = 9;
            // 
            // rightmainpanel
            // 
            this.rightmainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.rightmainpanel.Controls.Add(this.btnFormClose);
            this.rightmainpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightmainpanel.Location = new System.Drawing.Point(1415, 0);
            this.rightmainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightmainpanel.Name = "rightmainpanel";
            this.rightmainpanel.Size = new System.Drawing.Size(49, 906);
            this.rightmainpanel.TabIndex = 10;
            // 
            // btnFormClose
            // 
            this.btnFormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormClose.BackgroundImage")));
            this.btnFormClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFormClose.FlatAppearance.BorderSize = 0;
            this.btnFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormClose.Location = new System.Drawing.Point(10, 1);
            this.btnFormClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Size = new System.Drawing.Size(28, 31);
            this.btnFormClose.TabIndex = 6;
            this.btnFormClose.UseVisualStyleBackColor = true;
            this.btnFormClose.Click += new System.EventHandler(this.btnFormClose_Click);
            // 
            // topmainpanel
            // 
            this.topmainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.topmainpanel.Controls.Add(this.lblInput);
            this.topmainpanel.Controls.Add(this.lblSelectedFormHeader);
            this.topmainpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topmainpanel.Location = new System.Drawing.Point(30, 0);
            this.topmainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.topmainpanel.Name = "topmainpanel";
            this.topmainpanel.Size = new System.Drawing.Size(1385, 31);
            this.topmainpanel.TabIndex = 11;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.BackColor = System.Drawing.Color.Transparent;
            this.lblInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInput.Location = new System.Drawing.Point(0, 0);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(66, 24);
            this.lblInput.TabIndex = 19;
            this.lblInput.Text = "Input";
            // 
            // lblSelectedFormHeader
            // 
            this.lblSelectedFormHeader.AutoSize = true;
            this.lblSelectedFormHeader.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFormHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSelectedFormHeader.Location = new System.Drawing.Point(556, 4);
            this.lblSelectedFormHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedFormHeader.Name = "lblSelectedFormHeader";
            this.lblSelectedFormHeader.Size = new System.Drawing.Size(208, 25);
            this.lblSelectedFormHeader.TabIndex = 18;
            this.lblSelectedFormHeader.Text = "Shadower Misc !!";
            // 
            // top2mainpanel
            // 
            this.top2mainpanel.Controls.Add(this.rtInput);
            this.top2mainpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top2mainpanel.Location = new System.Drawing.Point(30, 31);
            this.top2mainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.top2mainpanel.Name = "top2mainpanel";
            this.top2mainpanel.Size = new System.Drawing.Size(1385, 374);
            this.top2mainpanel.TabIndex = 12;
            // 
            // top3mainpanel
            // 
            this.top3mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.top3mainpanel.Controls.Add(this.cmbOps);
            this.top3mainpanel.Controls.Add(this.btnGetResult);
            this.top3mainpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top3mainpanel.Location = new System.Drawing.Point(30, 405);
            this.top3mainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.top3mainpanel.Name = "top3mainpanel";
            this.top3mainpanel.Size = new System.Drawing.Size(1385, 45);
            this.top3mainpanel.TabIndex = 13;
            // 
            // top4mainpanel
            // 
            this.top4mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.top4mainpanel.Controls.Add(this.lblOutput);
            this.top4mainpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top4mainpanel.Location = new System.Drawing.Point(30, 450);
            this.top4mainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.top4mainpanel.Name = "top4mainpanel";
            this.top4mainpanel.Size = new System.Drawing.Size(1385, 30);
            this.top4mainpanel.TabIndex = 14;
            // 
            // top5mainpanel
            // 
            this.top5mainpanel.Controls.Add(this.rtOutput);
            this.top5mainpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top5mainpanel.Location = new System.Drawing.Point(30, 480);
            this.top5mainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.top5mainpanel.Name = "top5mainpanel";
            this.top5mainpanel.Size = new System.Drawing.Size(1385, 404);
            this.top5mainpanel.TabIndex = 15;
            // 
            // MiscForm
            // 
            this.AcceptButton = this.btnGetResult;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1464, 906);
            this.Controls.Add(this.top5mainpanel);
            this.Controls.Add(this.top4mainpanel);
            this.Controls.Add(this.top3mainpanel);
            this.Controls.Add(this.top2mainpanel);
            this.Controls.Add(this.topmainpanel);
            this.Controls.Add(this.rightmainpanel);
            this.Controls.Add(this.mainleftpanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MiscForm";
            this.Text = "Shadower Miscellaneous !!";
            this.Load += new System.EventHandler(this.MiscForm_Load);
            this.rightmainpanel.ResumeLayout(false);
            this.topmainpanel.ResumeLayout(false);
            this.topmainpanel.PerformLayout();
            this.top2mainpanel.ResumeLayout(false);
            this.top3mainpanel.ResumeLayout(false);
            this.top4mainpanel.ResumeLayout(false);
            this.top4mainpanel.PerformLayout();
            this.top5mainpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtInput;
        private System.Windows.Forms.RichTextBox rtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ComboBox cmbOps;
        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.Panel mainleftpanel;
        private System.Windows.Forms.Panel rightmainpanel;
        private System.Windows.Forms.Panel topmainpanel;
        private System.Windows.Forms.Panel top2mainpanel;
        private System.Windows.Forms.Panel top3mainpanel;
        private System.Windows.Forms.Panel top4mainpanel;
        private System.Windows.Forms.Panel top5mainpanel;
        private System.Windows.Forms.Button btnFormClose;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblSelectedFormHeader;
    }
}