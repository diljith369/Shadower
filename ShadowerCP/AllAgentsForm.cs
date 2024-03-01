using ShadowerCP.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ShadowerCP
{
    public partial class AllAgentsForm : Form
    {
        private Form currentChildForm;

        public AllAgentsForm()
        {
            InitializeComponent();
            dtwAllAgents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtwAllAgents.ColumnHeadersHeight = 25;
            dtwAllAgents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dtwAllAgents.DataSource = GetAllAgents();

        }
        string strBaseURL = ShadowerForm.lblheaderapiendpoint.Text.Split(' ')[1].Trim() +  @"agenthandler/";
        

        private List<shadoweragent> GetAllAgents()
        {
            string strGetAllAgentsURL = strBaseURL + "ListAllAgents";
            List<shadoweragent> lstAllAgents = new List<shadoweragent>();
            try
            {
                using (var shadowerWebClient = new WebClient())
                {

                    shadowerWebClient.Headers.Add("Content-Type:application/json");

                    var jsonRes = shadowerWebClient.DownloadString(strGetAllAgentsURL);
                    lstAllAgents = new JavaScriptSerializer().Deserialize<List<shadoweragent>>(jsonRes);
                }
            }
            catch (Exception)
            {

               
            }

           
            return lstAllAgents;
        }

        private void dtwAllAgents_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dtwAllAgents.Rows)
            {
                    r.Cells[0] = new DataGridViewLinkCell();                   
                    DataGridViewLinkCell c = r.Cells["agentHostName"] as DataGridViewLinkCell;
                    c.LinkColor = Color.Green;
            }
        }

        private void dtwAllAgents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; //check if row index is not selected
            if (dtwAllAgents.CurrentCell!= null && dtwAllAgents.CurrentCell.ColumnIndex.Equals(0))
                if (dtwAllAgents.CurrentCell.Value != null)
                {
                    OpenAgentCPForm(new CommandForm(dtwAllAgents.SelectedRows[0].Cells["agentUniquID"].Value.ToString()));
                    
                }
                   
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtwAllAgents.DataSource = GetAllAgents();
        }

        #region Methods

        private void OpenAgentCPForm(Form agentCPForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = agentCPForm;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;
            ChildFormHolderPanel.Controls.Add(currentChildForm);
            ChildFormHolderPanel.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
            //lblAvBHeader.Text = currentChildForm.Text;
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnControllerPanel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
