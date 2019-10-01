using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PulseTableMapping
    {
        public long Id { get; set; }
        public string TabFileName { get; set; }
        public string HustleTableName { get; set; }
        public string PulseFieldName { get; set; }
        public string HustleFieldName { get; set; }
        public bool? Active { get; set; }
        public string DefaultVal { get; set; }
    }
}
