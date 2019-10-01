using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class EodvarianceLog
    {
        public string LocationCode { get; set; }
        public DateTime? SystemDate { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime? Added { get; set; }
    }
}
