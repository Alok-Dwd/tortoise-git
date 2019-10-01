using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ExtraScriptDday
    {
        public string StepNumber { get; set; }
        public string Message { get; set; }
        public DateTime? TimeStamp { get; set; }
        public bool? Error { get; set; }
    }
}
