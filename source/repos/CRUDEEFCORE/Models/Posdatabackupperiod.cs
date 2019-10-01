using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Posdatabackupperiod
    {
        public string TableName { get; set; }
        public int NoOfDays { get; set; }
        public string SystemDate { get; set; }
    }
}
