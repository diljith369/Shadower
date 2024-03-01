using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowerCP.Misc
{
    public class shadoweragent
    {
       
        [System.ComponentModel.DisplayName("HostName")]
        public string agentHostName { get; set; }      
       
        
        [System.ComponentModel.DisplayName("IP")]

        public string agentIP { get; set; }
        [System.ComponentModel.DisplayName("OS")]
        public string agentOS { get; set; }
       
        [System.ComponentModel.DisplayName("MacID")]
        public string agentMacID { get; set; }
        [System.ComponentModel.DisplayName("Screen")]

        public string screen { get; set; }
        [System.ComponentModel.DisplayName("FileName")]

        public string filename { get; set; }
        [System.ComponentModel.DisplayName("File Content")]
        public string filecontent { get; set; }

        [System.ComponentModel.DisplayName("Last Command")]
        public string command { get; set; }

        [System.ComponentModel.DisplayName("Command Text Result")]
        public string commandtxtres { get; set; }
        [System.ComponentModel.DisplayName("Created At")]

        public string createdat { get; set; }

        [System.ComponentModel.DisplayName("AgentID")]
        public string agentUniquID { get; set; }

        [System.ComponentModel.DisplayName("AES Key")]
        public string aes_key { get; set; }

        [System.ComponentModel.DisplayName("AES IV")]
        public string aes_iv { get; set; }

        [System.ComponentModel.DisplayName("Pvt Key")]
        public string pvt_key { get; set; }

        [System.ComponentModel.DisplayName("Pub Key")]
        public string pub_key { get; set; }
    }
}
