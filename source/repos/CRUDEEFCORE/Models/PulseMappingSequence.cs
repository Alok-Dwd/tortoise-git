using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PulseMappingSequence
    {
        public int SequenceNo { get; set; }
        public string TabFileName { get; set; }
        public bool Processed { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string TableType { get; set; }
        public bool? Active { get; set; }
    }
}
