using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ViewRoutedriverReturnTimes
    {
        public string LocationCode { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? ReturnTime { get; set; }
    }
}
