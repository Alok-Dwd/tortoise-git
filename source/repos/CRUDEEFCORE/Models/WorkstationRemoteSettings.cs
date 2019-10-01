using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class WorkstationRemoteSettings
    {
        public string LocationCode { get; set; }
        public int WorkstationId { get; set; }
        public string IpAddress { get; set; }
        public string SecurityKey { get; set; }
        public string RemoteEmployeeCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
