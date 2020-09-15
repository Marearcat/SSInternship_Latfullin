using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSInternship_Latfullin.Hubs
{
    public class GeneralData
    {
        public GeneralData()
        {
            History = new List<string>();
        }

        public List<string> History { get; set; }
    }
}
