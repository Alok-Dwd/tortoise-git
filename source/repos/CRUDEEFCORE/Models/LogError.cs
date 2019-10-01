using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class LogError
    {
        public string ErrorNumber { get; set; }
        public string LineNumber { get; set; }
        public string Message { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ProcName { get; set; }
        public string PageName { get; set; }
    }
}
