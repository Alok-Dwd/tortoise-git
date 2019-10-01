using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class UsrPushPullStat
    {
        public string Dpinum { get; set; }
        public string Type { get; set; }
        public DateTime? Ppdt { get; set; }
        public DateTime? Sysdt { get; set; }
    }
}
