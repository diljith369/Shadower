using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowerCP.Misc
{
    public class ServerSettings
    {
        private static ServerSettings oServerSettings = null;
        public static ServerSettings Instance
        {
            get
            {
                if (oServerSettings == null)
                {
                    oServerSettings = new ServerSettings();
                }
                return oServerSettings;
            }
        }
        public string EndPointURL { get; set; }
    }
}
