using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ReportGroupDetail
    {
        public string LocationCode { get; set; }
        public int Id { get; set; }
        public int Groupid { get; set; }
        public short ReportId { get; set; }
        public short Copies { get; set; }
        public int RangeId { get; set; }
        public int Parameter1 { get; set; }
    }
}
