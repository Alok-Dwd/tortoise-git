using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GovernmentReceipts
    {
        public string LocationCode { get; set; }
        public byte GovernmentId { get; set; }
        public string EnglishDescription { get; set; }
        public string Description { get; set; }
    }
}
