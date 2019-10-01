using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MobInEmployee
    {
        public int MobInEmployeeId { get; set; }
        public string FkEmployeeCode { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? ApiInvokeTimeStamp { get; set; }
        public DateTime? ApiCompleteTimeStamp { get; set; }
        public bool IsActive { get; set; }
        public bool ApiStatus { get; set; }
        public int IsModified { get; set; }
        public bool ModifiedApiStatus { get; set; }
        public int FailCount { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int? BcpStatus { get; set; }
    }
}
