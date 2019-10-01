using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class EmployeeFingerprint
    {
        public string LocationCode { get; set; }
        public string EmployeeCode { get; set; }
        public string FingerprintTemplate1 { get; set; }
        public string FingerprintTemplate2 { get; set; }
        public string FingerprintTemplate3 { get; set; }
        public string FingerprintTemplate4 { get; set; }
    }
}
