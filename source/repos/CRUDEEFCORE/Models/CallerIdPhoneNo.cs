using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CallerIdPhoneNo
    {
        public string FromPhoneNo { get; set; }
        public string ToPhoneNo { get; set; }
        public string Description { get; set; }
        public string TelephoneNo { get; set; }
        public bool? Active { get; set; }
    }
}
