using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DailyBackup
    {
        public string LocationCode { get; set; }
        public string Ver { get; set; }
        public DateTime LastBackup { get; set; }
        public string BackType { get; set; }
    }
}
