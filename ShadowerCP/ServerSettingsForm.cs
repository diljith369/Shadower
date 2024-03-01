using ShadowerCP.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowerCP
{
    public partial class ServerSettingsForm : Form
    {
        public ServerSettingsForm()
        {
            InitializeComponent();
        }

        private void btnServerSettingClose_Click(object sender, EventArgs e)
        {
            this.Close();        }

        private void btnSetServerSettings_Click(object sender, EventArgs e)
        {
            checkandcloseform();
            setparentbuttonstate();
        }

        private void setparentbuttonstate()
        {
            foreach (Form form in Application.OpenForms)
            {
                // Check if the form is an instance of Form2
                ShadowerForm oshadowerform = form as ShadowerForm;

                if (oshadowerform != null)
                {
                    oshadowerform.btnAgentbuilder.Enabled = oshadowerform.btnControlPanel.Enabled =   true;
                }
                // Outside of this block, form2Instance is out of scope
            }

        }

        private void checkandcloseform()
        {
            string strAgentAPIEndPoint = txtEndPoint.Text.Trim();
            if (strAgentAPIEndPoint != string.Empty)
            {
                if (!strAgentAPIEndPoint.EndsWith("/"))
                {
                    strAgentAPIEndPoint = strAgentAPIEndPoint + '/';
                }
                ServerSettings.Instance.EndPointURL = strAgentAPIEndPoint;
                ShadowerForm.lblheaderapiendpoint.Visible = true;
                ShadowerForm.lblheaderapiendpoint.Text = "C2 " + strAgentAPIEndPoint;
                FormHeaderSettings.Instance.C2Configured = true;
                this.Close();
            }
        }

        
    }
}
