using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class BatchInstallerLogs
    {
        public int LogId { get; set; }
        public string LogName { get; set; }
        public string Discription { get; set; }
        public string ActionId { get; set; }
        public int? ActionType { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
