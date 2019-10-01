using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SystemAccountsSql
    {
        public string LocationCode { get; set; }
        public int AccountId { get; set; }
        public string SqlStatement { get; set; }
    }
}
