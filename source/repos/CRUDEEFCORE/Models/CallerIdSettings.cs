using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CallerIdSettings
    {
        public string LocationCode { get; set; }
        public byte CallerIdConnectionTypeCode { get; set; }
        public short NumberOfLines { get; set; }
        public bool UseRemotely { get; set; }
        public byte? SerialPortCode { get; set; }
        public int? BaudRate { get; set; }
        public byte? DataBits { get; set; }
        public byte? StopBits { get; set; }
        public byte? ParityTypeCode { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string NetworkPort { get; set; }
        public string HostName { get; set; }
        public string Channel { get; set; }
        public string Url { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
