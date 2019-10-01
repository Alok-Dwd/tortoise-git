using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class EodpromptMessage
    {
        public string LocationCode { get; set; }
        public DateTime? SystemDate { get; set; }
        public string PrompMsg { get; set; }
        public DateTime? Added { get; set; }
    }
}
