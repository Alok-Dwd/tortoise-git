using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DriverTrackId
    {
        public int Id { get; set; }
        public string LocationCode { get; set; }
        public string DriverId { get; set; }
        public string RfId { get; set; }
        public string IsActive { get; set; }
        public DateTime? Added { get; set; }
        public string StatusCode { get; set; }
        public string ApproveState { get; set; }
        public string AssignType { get; set; }
        public DateTime? RfTimeStamp { get; set; }
        public DateTime? AsignDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}
