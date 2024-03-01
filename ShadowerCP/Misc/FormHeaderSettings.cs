using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShadowerCP.Misc.FormHeaderSettings;

namespace ShadowerCP.Misc
{
    public class FormHeaderSettings
    {
        private static FormHeaderSettings oFormHeaderSettings = null;
        public static FormHeaderSettings Instance
        {
            get
            {
                if (oFormHeaderSettings == null)
                {
                    oFormHeaderSettings = new FormHeaderSettings();
                }
                return oFormHeaderSettings;
            }
        }
        public string FormHeader { get; set; }
        public bool C2Configured { get; set; }
    }       
      
}
