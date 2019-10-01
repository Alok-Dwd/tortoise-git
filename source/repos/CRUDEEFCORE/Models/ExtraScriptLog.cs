using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ExtraScriptLog
    {
        public string StepNumber { get; set; }
        public string Message { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
