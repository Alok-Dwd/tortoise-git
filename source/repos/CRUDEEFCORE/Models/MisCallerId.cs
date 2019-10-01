using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MisCallerId
    {
        public Guid MisCallerId1 { get; set; }
        public string LocationCode { get; set; }
        public byte Line { get; set; }
        public string CallDate { get; set; }
        public string CallTime { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerName { get; set; }
        public bool Answered { get; set; }
        public DateTime? CallDateTime { get; set; }
        public DateTime? CreateDateTime { get; set; }
    }
}
