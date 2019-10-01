using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class EodError
    {
        public DateTime EodDate { get; set; }
        public string SpName { get; set; }
        public int? ErrorNumber { get; set; }
        public string ErrorSeverity { get; set; }
        public string ErrorState { get; set; }
        public string ErrorProcedure { get; set; }
        public int? ErrorLine { get; set; }
        public string ErrorMessage { get; set; }
    }
}
