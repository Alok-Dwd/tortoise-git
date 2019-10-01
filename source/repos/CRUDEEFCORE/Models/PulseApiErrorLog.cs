using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PulseApiErrorLog
    {
        public int RequestId { get; set; }
        public string LocationCode { get; set; }
        public string Status { get; set; }
        public string StatusDesc { get; set; }
        public string Errormessage { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Errornumber { get; set; }
        public string Errorseverity { get; set; }
        public string Errorstate { get; set; }
        public string Errorprocedure { get; set; }
        public string Errorline { get; set; }
    }
}
