using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ViewUsrMissedCall
    {
        public Guid MisCallerId { get; set; }
        public string Location { get; set; }
        public byte Line { get; set; }
        public DateTime? CallDateTime { get; set; }
        public string PhoneNumber { get; set; }
        public bool Answered { get; set; }
    }
}
