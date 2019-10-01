using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DriverTrackExeInfo
    {
        public string LocationCode { get; set; }
        public byte ExeId { get; set; }
        public string ExeName { get; set; }
        public byte? TimeOut { get; set; }
        public string Status { get; set; }
        public string FieldFilter { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
