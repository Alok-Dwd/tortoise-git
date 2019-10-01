using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DbManagerLogger
    {
        public string FileName { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? Added { get; set; }
        public bool? Status { get; set; }
        public string Version { get; set; }
    }
}
