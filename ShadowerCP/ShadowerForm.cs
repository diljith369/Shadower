using ShadowerCP.Misc;
using ShadowerCP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowerCP
{
    public partial class ShadowerForm : Form
    {
        private Form currentChildForm;
        private bool bmouseDown;
        private Point ptlastLocation;
        private string strAgentAPIEndPoint;
        public static Label lblheaderapiendpoint;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // width of ellipse
              int nHeightEllipse // height of ellipse
          );
        public ShadowerForm()
        {
            InitializeComponent();
            setAPIEndPointLabel();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            FormHeaderSettings.Instance.FormHeader = "Shadower";
            btnAgentbuilder.Enabled = btnControlPanel.Enabled =  FormHeaderSettings.Instance.C2Configured;

        }

        private void setAPIEndPointLabel()
        {
            lblheaderapiendpoint = new System.Windows.Forms.Label();
            lblheaderapiendpoint.AutoSize = true;
            lblheaderapiendpoint.ForeColor = System.Drawing.Color.AliceBlue;
            //lblheaderapiendpoint.BackColor = System.Drawing.Color.Red;
            lblheaderapiendpoint.Location = new System.Drawing.Point(30, 3);
            lblheaderapiendpoint.Dock  =   DockStyle.Top; 
            lblheaderapiendpoint.Name = "lblheaderapiendpoint";
            lblheaderapiendpoint.Size = new System.Drawing.Size(150, 25);
            //lblheaderapiendpoint.TabIndex = 12;
            lblheaderapiendpoint.Text = "C2 ";
            lblheaderapiendpoint.Visible = true;
            lblheaderapiendpoint.BringToFront();
            this.mainareabottompanel.Controls.Add(lblheaderapiendpoint);
        }

       

        private void btnServerSettings_Click(object sender, EventArgs e)
        {
            //Thread serverSettingFormThread = new Thread(() => OpenChildForm(new AllAgentsForm(), sender));
            // serverSettingFormThread.Start();
            //serverSettingFormThread.Join();
            OpenChildForm(new ServerSettingsForm(), sender);
            (sender as Button).BackColor = System.Drawing.Color.Transparent;

            //Thread.Sleep(2000);
            //lblheaderapiendpoint.Text = ServerSettings.Instance.EndPointURL;
            btnAgentbuilder.Enabled = btnControlPanel.Enabled =  FormHeaderSettings.Instance.C2Configured;

        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
        private void ChildFormHolderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            bmouseDown = true;
            ptlastLocation = e.Location;
        }

        private void ChildFormHolderPanel_MouseMove(object sender, MouseEventArgs e)
        {

            if (bmouseDown)
            {
                this.Location = new Point((this.Location.X - ptlastLocation.X) + e.X, (this.Location.Y - ptlastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ChildFormHolderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            bmouseDown = false;

        }

        #region Methods
        private void OpenChildForm(Form childForm, object Sender)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;
            ChildFormHolderPanel.Controls.Add(currentChildForm);
            ChildFormHolderPanel.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
            //lblSelectedFormHeader.Text  = currentChildForm.Text;
        }

        #endregion

        private void btnControlPanel_Click(object sender, EventArgs e)
        {
            //lblSelectedFormHeader.Text = "Shadower Agent Control Panel";
            OpenChildForm(new AllAgentsForm(), sender);
            (sender as Button).BackColor = System.Drawing.Color.Transparent;

        }



        private void btnAgentbuilder_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Transparent;

            OpenChildForm(new AgentBuilderForm(), sender);

        }

        private void btnCommon_Leave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Transparent;

        }

        private void btnMisc_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Transparent;
            OpenChildForm(new MiscForm(), sender);

        }

        private void ShadowerForm_Load(object sender, EventArgs e)
        {
            ChildFormHolderPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ChildFormHolderPanel.Width-5 ,ChildFormHolderPanel.Height-30, 25, 25));
        }

        private void btnFormClose_Enter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Transparent;

        }

        private void btnReflection_Click(object sender, EventArgs e)
        {

            OpenChildForm(new ReflectLoaderForm(), sender);
        }
    }
}
