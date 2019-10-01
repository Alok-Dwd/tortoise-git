using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ViewSecurityClassOverride
    {
        public string LocationCode { get; set; }
        public string EmployeeCode { get; set; }
        public int VbMenuItemId { get; set; }
        public bool? Enabled { get; set; }
        public string VbMenuItem { get; set; }
        public bool? SpecialFunction { get; set; }
    }
}
