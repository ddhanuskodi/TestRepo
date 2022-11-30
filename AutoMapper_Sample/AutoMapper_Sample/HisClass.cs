using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_Sample
{
    public enum HisStatus { started = 0, pending = 1, inprogress = 2, completed = 3 }
    public class HisClass
    {
        public string hisname { get; set; }
        public DateTime startdate { get; set; }
        public HisStatus GetStatus { get; set; }
        
    }
    public class HisDetails
    {
        public string hisname { get; set; }
        public string hisaddress { get; set; }
        public string email { get; set; }
    }
}
