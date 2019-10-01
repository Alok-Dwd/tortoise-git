using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class EmployeeClassOverride
    {
        public string LocationCode { get; set; }
        public string EmployeeCode { get; set; }
        public string SecurityClassCode { get; set; }
        public int VbMenuItemId { get; set; }
        public bool? Enabled { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
