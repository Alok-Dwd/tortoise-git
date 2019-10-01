using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MobInEmployeeLog
    {
        public string FkLocationCode { get; set; }
        public string FkEmployeeCode { get; set; }
        public string ServiceCallUrl { get; set; }
        public string FarEyeOrderMessage { get; set; }
        public string EmployeeStatusMessage { get; set; }
        public string EmployeeStatusCode { get; set; }
        public DateTime? CallInvokeTimeStamp { get; set; }
        public DateTime? CallCompleteTimeStamp { get; set; }
        public bool IsSucess { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }

        public virtual Employee Fk { get; set; }
    }
}
