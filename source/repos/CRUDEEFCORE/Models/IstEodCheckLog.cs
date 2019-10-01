using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class IstEodCheckLog
    {
        public int Id { get; set; }
        public DateTime? SystemDate { get; set; }
        public DateTime? LastEodTime { get; set; }
    }
}
