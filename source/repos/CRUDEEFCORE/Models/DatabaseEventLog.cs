using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DatabaseEventLog
    {
        public int LogId { get; set; }
        public DateTime EventDate { get; set; }
        public string EventType { get; set; }
        public DateTime? PostTime { get; set; }
        public string Spid { get; set; }
        public string ServerName { get; set; }
        public string LoginName { get; set; }
        public string UserName { get; set; }
        public string DatabaseName { get; set; }
        public string SchemaName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string Tsqlcommand { get; set; }
        public string EventDataXml { get; set; }
        public string HostName { get; set; }
        public string Ipadderss { get; set; }
        public string ProgramName { get; set; }
    }
}
